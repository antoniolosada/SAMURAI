// Controlling a servo position using a potentiometer (variable resistor) 
// by Michal Rinott <http://people.interaction-ivrea.it/m.rinott> 

#include <Servo.h> 

#define DEBUG  0

#define OP_INICIAR		1
#define OP_CONSULTAR		2

#define TIEMPO_CICLO_MS  20

#define FIN_SECUENCIA  0
#define FIN_MOVIMIENTO 0
#define SECUENCIA_EN_PROCESO  1

#define MAX_SEC 100

#define RUN 1
#define STOP 2
#define PAUSE 3

#define LECTURA_FIN  1
#define SIN_ASIGNAR  -1
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

struct Movimiento 
{
  byte BNumMov;
  int iTiempo;
  int pos[23]; 
};

Movimiento Secuencia[100];

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
} 

int CargarSecuencia()
{
  /*
    En la primera entrada identificamos si hay asignado algún movimiento para algún servo
    Si no hay asignado ningún valor para los servos localizamos el primer movimiento de la secuencia, y el número de movimientos
    Comenzando en el primer movimiento intentamos asignar valores a todos los servos buscando valores desde el movimiento inicial.
    Junto con el valor del valor destino del servo guardamos el tiempo que tiene que pasar para que el servo alcance el valor
    Para cada servo se guarda el valor de tiempo inicial en ms para controlar el tiempo transcurrido desde la asignación
    
  */
  int i;
  int iNum;

    if (iNumMovActivo == SIN_ASIGNAR)
      return FIN_MOVIMIENTO;
    else
    {
      if (iNumSecActiva == SIN_ASIGNAR)
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
          iNumMovActivo = SIN_ASIGNAR;
          iNumSecActiva = SIN_ASIGNAR;
          return FIN_MOVIMIENTO;
        }
      }
      Serial.print(">CARGA_SEC-");
      Serial.println(iNumSecActiva);    
      for (i=0; i<=22; i++)
      {
        aPosServos[i].iValorInicial = aPosServos[i].iValor;
        aPosServos[i].iValorFinal = Secuencia[iNumSecActiva].pos[i];
        aPosServos[i].iIteraciones = 1;
        //Si el valor del servo no está asignado o no tiene que moverse se colocan a 0 las iteraciones
        if ((aPosServos[i].iValorFinal == SIN_ASIGNAR))
          aPosServos[i].iMaxIteraciones = 0;
        else
          aPosServos[i].iMaxIteraciones = Secuencia[iNumSecActiva].iTiempo/TIEMPO_ITERACION_MS+1;
      }
    }
    return SECUENCIA_EN_PROCESO;
}

int EjecutarSecuencia()
{
  int i;
  int iPos;
  int iCambio = FIN_SECUENCIA;
  //Ejecutamos la iteracción de la secuencia actual
  
  if (iNumSecActiva != SIN_ASIGNAR)
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
