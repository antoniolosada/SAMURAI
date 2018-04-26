#define GRADOS    0
#define MS        1

int LeerCadena(int *i, char *Cadena)
{
  char c;
  
  while (Serial.available() > 0)
  {
    c = Serial.read();
    if (*i < 400)
    {
      switch (c)
      {
        case '\r':
          break;
        case '\n':
          break;
        case '.':
        {
            Cadena[*i] = 0;
            *i = 0;
            return 1;
        }
        default:
        {
          Cadena[(*i)++] = c;
          Cadena[*i] = 0;
        }
      }
    }
    else return 2;
 }
 return 0;
}

void ProcesarCadena(char *Cadena)
{
  char cCar;
  char cCatTipoMov;
  int i;
  int iPosFin;
  int iNumServo;
  int iValor;
  int iModo;
  long CRC;
  
  cCar = Cadena[0];
  
  LOG2("c->", Cadena);
  
  if (cCar == ':')
  {
    cCar = Cadena[1];
    switch (cCar)
    {
      case 'p': 
      { //Posicion inmediata
        cCar = Cadena[2];
        
        if (cCar == 'g')
          iModo = GRADOS;
        else
           iModo = MS;
        
        iNumServo = RecValor(Cadena, 3, ',', &iPosFin);
        iValor = RecValor(Cadena, iPosFin+1, ';', &iPosFin);
        
        Serial.print("->");
        Serial.print(iNumServo);
        Serial.print(",");
        Serial.println(iValor);
        AsignarServo(iNumServo, iValor, iModo);
        
        break;
      }
      case 'e':
      case 'm':
      { // Movimiento temporizado
        cCatTipoMov = cCar;
        cCar = Cadena[2];
        if (cCar == 'g')
          iModo = GRADOS;
        else
           iModo = MS;
        
        LOG2("","CARGA_MOV");
  
        if (iPosSec < MAX_SEC-1)
        {
          Secuencia[iPosSec].BNumMov = RecValor(Cadena, 3, '|', &iPosFin);
          RecCadena(Cadena, iPosFin+1, '|', &iPosFin); //Descripción
          Secuencia[iPosSec].iTiempo = RecValor(Cadena, iPosFin+1, '|', &iPosFin);
          LOG2int("tiempo->", Secuencia[iPosSec].iTiempo);
    
          CRC = 0;
          for (i=0; i<=22; i++)
            Secuencia[iPosSec].pos[i] = SIN_ASIGNAR;
          for (i=0; i<=22; i++)
          {
            iNumServo = i;
            CRC += iNumServo;
            Secuencia[iPosSec].pos[iNumServo] = RecValor(Cadena, iPosFin+1, '|', &iPosFin);
            CRC += Secuencia[iPosSec].pos[iNumServo];
            LOG2int(",",Secuencia[iPosSec].pos[iNumServo]);
          }
          if ((CRC%32760) == RecValor(Cadena, iPosFin+1, '|', &iPosFin))
          {
            if (cCatTipoMov == 'e')
            { //Recibimos una orden de secuencia completa inmediata
              for (i=0; i<=22; i++)
                AsignarServo(i+2, Secuencia[iPosSec].pos[i], iModo);
              Serial.println(">SEC_EJEC-OK");
            }
            else
            {
              iPosSec++;
              Serial.print(">SEC_OK-");
              Serial.println(iPosSec);
            }
          }
          else
          {
            Serial.print(">SEC_ERROR-");
            Serial.println(iPosSec);
          }
        }
        else
            Serial.print(">SEC_ERROR_MAX_SEC");
        break;
      }
      case 'r':
      {
        iEstado = RUN;
        iNumMovActivo = RecValor(Cadena, 2, ';', &iPosFin);
        Serial.print(">RUN_OK-");
        Serial.println(iNumMovActivo);
        break;
      }
      case 's':
      {
        iEstado = STOP;
        iNumMovActivo = SIN_ASIGNAR;
        iNumSecActiva = SIN_ASIGNAR;
        Serial.println(">STOP_OK");
        break;
      }
      case 't':
      {
        iEstado = STOP;
        iPosSec = 0;
        iNumMovActivo = SIN_ASIGNAR;
        iNumSecActiva = SIN_ASIGNAR;
        Serial.println(">RESET_OK");
        break;
      }
      case 'i':
      {
        PosicionInicial();
        Serial.println(">POSINI_OK");
        break;
      }
    } //switch
  } //if cCar
}

int RecValor(char *Cadena, int iPosIni, char cDelimitador, int *iFinPos)
{
  char cTmp[50] = "\0";
  char cCar;
  int i,j;
  
  i = iPosIni;
  j = 0;
  cCar = Cadena[i];
  while (cCar != cDelimitador)
  {
    cTmp[j++] = cCar;
    cCar = Cadena[++i];
  }
  cTmp[j] = 0;
  *iFinPos = i;
  return atoi(cTmp);
}
char * RecCadena(char *Cadena, int iPosIni, char cDelimitador, int *iFinPos)
{
  static char cTmp[50] = "\0";
  char cCar;
  int i,j;
  
  cTmp[0] = 0;
  i = iPosIni;
  j = 0;
  cCar = Cadena[i];
  while (cCar != cDelimitador)
  {
    cTmp[j++] = cCar;
    cCar = Cadena[++i];
  }
  cTmp[j] = 0;
  *iFinPos = i;
  return cTmp;
}

