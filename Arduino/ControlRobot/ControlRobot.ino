// Controlling a servo position using a potentiometer (variable resistor) 
// by Michal Rinott <http://people.interaction-ivrea.it/m.rinott> 

#include <Servo.h> 

#define DEBUG  0

#define OP_INICIAR		1
#define OP_CONSULTAR		2

#define TIEMPO_CICLO_MS  20

#define NO_INICIADO    -1
#define FIN_SECUENCIA  0
#define FIN_MOVIMIENTO 0
#define SECUENCIA_EN_PROCESO  1

#define MAX_SEC 100

#define RUN 1
#define STOP 2
#define PAUSE 3

#define LECTURA_FIN  1
#define SIN_ASIGNAR  255
#define SERVO_CONT_MOV  254
#define TIEMPO_ITERACION_MS  20

Servo aServo[23];
struct sPosServos 
{
  int iValor;
  int iUnidad;
  int iIteraciones;
  int iMaxIteraciones;
  int iValorInicial;
  int iValorFinal;
} aPosServos[23];

int iPosCad = 0;
char Cadena[400];
unsigned long TiempoMs = 0;

struct Movimiento 
{
  byte BNumMov;
  long iTiempo;
  byte pos[23]; 
};

Movimiento Secuencia[200];

int iPosSec = 0;
int iEstado = STOP;
int iNumSecActiva = SIN_ASIGNAR;
int iNumMovActivo = SIN_ASIGNAR;
int iFinSec = 0;

void setup() 
{ 
  int i;
  
  for(i=0; i<=22; i++)
  {
    aServo[i].attach(pin(i));
    aPosServos[i].iIteraciones = 0;
  }
  
  PosicionInicial();

  Serial.begin(115200);
  
} 
 
void loop() 
{ 
  Espera(TIEMPO_CICLO_MS, 0, OP_INICIAR);
  while(Espera(TIEMPO_CICLO_MS, 0, OP_CONSULTAR))
  {
    if (LeerCadena(&iPosCad, Cadena) == LECTURA_FIN)
    {
      ProcesarCadena(Cadena);
      Cadena[0] = 0;
    }
  }
  switch (iEstado)
  {
    case RUN:
    {
      if (iPosSec > 0) //Solo entramos si hay secuencias
      {
        if (EjecutarSecuencia() == FIN_SECUENCIA)
        {
          if (CargarSecuencia() == FIN_MOVIMIENTO) 
          {
            Serial.println(">STOP_FIN");
            iEstado = STOP;  //Finalizamos el último movimiento de la secuencia
            iNumSecActiva = SIN_ASIGNAR;
          }
        }
      }
      break;
    }
  }
  TiempoMs += TIEMPO_ITERACION_MS;
} 

/* Procedimiento de ejecución de movimientos
  - Identificamos el movimiento inicial y final de la secuencia
  - Cargamos el primer movimiento
  - Inicializamos el contador de tiempo
  - Recuperamos el tiempo transcurrido hasta la posición indicada por el movimiento restanto al tiempo del movimiento el tiempo actual
  - Comprobamos el número de iteraciones de 10ms de cada servo para llegar en el tiempo especificado a la posición destino
  - Si hay servos que no se mueven, se indica en el valor para que no se asigne
  - Si hay servos que continuan movimiento, debemos localizar la posición final de este movimiento
    - Buscamos en todos los movimientos posteriores hasta encontrar un valor. Según vamos buscando sumamos los tiempos de cada movimiento
    - Una vez encontrado el valor final calculamos el valor final del movimiento actual y lo asignamos
*/

int CargarSecuencia()
{

  int i;
  int iNum;

    if (iNumMovActivo == NO_INICIADO)
      return FIN_MOVIMIENTO;
    else
    {
      if (iNumSecActiva == NO_INICIADO)
      {
        
        //Recuperamos la primera posición del movimiento
        for (i=0; i<iPosSec; i++)
        {
          if (Secuencia[iNum].BNumMov == iNumMovActivo)
          {
            iNumSecActiva = iNum = i;
            break;
          }
        }
      }
      else
      {
        //Comprobamos que la secuencia sigue perteneciendo al mismo movimiento y no el la última
        iNumSecActiva++;
        if ((Secuencia[iNumSecActiva].BNumMov != iNumMovActivo) || (iNumSecActiva >= iPosSec))
        {
          Serial.print(">FIN_MOV-");
          Serial.println(iNumMovActivo);
          iNumMovActivo = NO_INICIADO;
          iNumSecActiva = NO_INICIADO;
          return FIN_MOVIMIENTO;
        }
      }
      unsigned long TiempoSec = Secuencia[iNumSecActiva].iTiempo;
      while ((Secuencia[iNumSec].BNumMov == iNumMovActivo) && (iNumSecActiva < iPosSec) && (Secuencia[iNumSecActiva].iTiempo == TiempoSec))
      {
        CargarDatosSecuencia(iNumSecActiva, TiempoSec, iNumMovActivo, iPosSec)
      }
    }
    return SECUENCIA_EN_PROCESO;
}

void CargarDatosSecuencia(int iNumSec, unsigned long TiempoSec, int iNumMov, int iFinSec)
{
  while ((Secuencia[iNumSec].BNumMov == iNumMovActivo) && (iNumSecActiva < iPosSec) && (Secuencia[iNumSec].iTiempo == TiempoSec))
  {
    Serial.print(">CARGA_SEC-");
    Serial.println(iNumSecActiva);    
    for (i=0; i<=22; i++)
    {
      aPosServos[i].iValorInicial = aPosServos[i].iValor;
      aPosServos[i].iValorFinal = Secuencia[iNumSecActiva].pos[i];
      aPosServos[i].iIteraciones = 1;
      if ((aPosServos[i].iValorFinal == SIN_ASIGNAR))
        aPosServos[i].iMaxIteraciones = 0;
      else if ((aPosServos[i].iValorFinal == SERVO_CONT_MOV))
      {
        //Localizamos el valor final
        int SecActiva = i;
        int UltimaSecuencia = iPosSec;
        int servo = i;
        int valor;
        aPosServos[i].iMaxIteraciones = 0;
        for (int j=iNumSecActiva+1; j<UltimaSecuencia; j++)
        { //Intentamos localizar el valor límite
          valor = Secuencia[j].pos[servo];
          if ((valor != SIN_ASIGNAR) && (valor != SERVO_CONT_MOV))
          {
              aPosServos[i].iMaxIteraciones = (Secuencia[iNumSecActiva].iTiempo-TiempoMs)/TIEMPO_ITERACION_MS+1; //+1 porque se inicia en 1
              aPosServos[i].iValorFinal = aPosServos[i].iValorInicial + 
                  (float)(valor-aPosServos[i].iValorInicial)*aPosServos[i].iMaxIteraciones/(Secuencia[j].iTiempo-TiempoMs)/TIEMPO_ITERACION_MS;
          }
        }
      } // else
      else
      {
        aPosServos[i].iMaxIteraciones = (Secuencia[iNumSecActiva].iTiempo-TiempoMs)/TIEMPO_ITERACION_MS+1; //+1 porque se inicia en 1
        LOG2long("t->", Secuencia[iNumSecActiva].iTiempo);
        LOG2int("tms->", TiempoMs);
      }
    } //for
  } //while
}

int EjecutarSecuencia()
{
  int i;
  int iPos;
  int iCambio = FIN_SECUENCIA;
  //Ejecutamos la iteracción de la secuencia actual
  
  if (iNumSecActiva != NO_INICIADO)
  {
      for (i=0; i<=22; i++)
      {
        if (aPosServos[i].iIteraciones <= aPosServos[i].iMaxIteraciones)
        {    
          LOG2int("servo->", i+2);
          LOG2int("i->", aPosServos[i].iIteraciones);
          iPos = aPosServos[i].iValorInicial + (aPosServos[i].iValorFinal-aPosServos[i].iValorInicial)*aPosServos[i].iIteraciones/aPosServos[i].iMaxIteraciones;
          LOG2int("vi->", aPosServos[i].iValorInicial);
          LOG2int("vf->", aPosServos[i].iValorFinal);
          LOG2int("p->", iPos);
          aPosServos[i].iIteraciones++;
          AsignarServo(i+2, iPos, aPosServos[i].iUnidad);  
          iCambio = SECUENCIA_EN_PROCESO;
        }
      }
  }   
  return iCambio;
}


void LOG2long(char *c1, long i2)
{
  if (DEBUG)
  {
    Serial.print(c1);
    Serial.println(i2);
  }
}
void LOG2int(char *c1, int i2)
{
  if (DEBUG)
  {
    Serial.print(c1);
    Serial.println(i2);
  }
}
void LOG2(char *c1, char *c2)
{
  if (DEBUG)
  {
    Serial.print(c1);
    Serial.println(c2);
  }
}
void LOG3(char *c1, char *c2, char *c3)
{
  if (DEBUG)
  {
    Serial.print(c1);
    Serial.print(c2);
    Serial.println(c3);
  }
}

void testCom()
{
  while (Serial.available() > 0)
  {
    char c = Serial.read();
    Serial.print(c);
    if (c =='.')
      Serial.println("");
    
  }
}

bool Espera(unsigned long ms, int contador, int op)
{
#define MAX_MS				4294967295

	static unsigned long ms_ini[10] = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
	unsigned long ms_actual[10];

	ms_actual[contador] = millis();

	if (op == OP_INICIAR)
		ms_ini[contador] = millis();
	else
	{
		if (ms_actual[contador] < ms_ini[contador])
		{
			ms_actual[contador] = MAX_MS - ms_ini[contador] + ms_actual[contador];
			ms_ini[contador] = 1;
		}

		if (ms_actual[contador] - ms_ini[contador] >= ms)
		{
			ms_ini[contador] = 0;
			return false;
		}
		else
			return true;
	}
}
