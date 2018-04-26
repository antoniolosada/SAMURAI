
int pin(int iNumServo)
{
  switch (iNumServo+2)
  {
    case 2: return 39;
    case 3: return 35;
    case 4: return 37;
    case 5: return 36;
    case 6: return 46;
    case 7: return 47;
    case 8: return 38;
    case 9: return 3;
    case 10: return 2;
    case 11: return 4;
    case 12: return 13;
    case 13: return 12;
    case 14: return 42;
    case 15: return 40;
    case 16: return 43;
    case 17: return 44;
    case 18: return 45;
    case 19: return 17;
    case 20: return 19;
    case 21: return 20;
    case 22: return 21;
    case 23: return 16;
    case 24: return 15;
  }
}

//Establecer como posición inicial la posición actual
void PosicionInicial()
{
   AsignarServo(2,133, GRADOS);
   AsignarServo(3,73, GRADOS);
   AsignarServo(4,79, GRADOS);
   AsignarServo(5,124, GRADOS);
   AsignarServo(6,113, GRADOS);
   AsignarServo(7,82, GRADOS);
   AsignarServo(8,89, GRADOS);
   AsignarServo(9,88, GRADOS);
   AsignarServo(10,108, GRADOS);
   AsignarServo(11,75, GRADOS);
   AsignarServo(12,54, GRADOS);
   AsignarServo(13,95, GRADOS);
   AsignarServo(14,81, GRADOS);
   AsignarServo(15,174, GRADOS);
   AsignarServo(16,132, GRADOS);
   AsignarServo(17,86, GRADOS);
   AsignarServo(18,99, GRADOS);
   AsignarServo(19,19, GRADOS);
   AsignarServo(20,60, GRADOS);
   AsignarServo(21,86, GRADOS);
   AsignarServo(22,56, GRADOS);
   AsignarServo(23,91, GRADOS);
   AsignarServo(24,133, GRADOS);
}


void AsignarServo(int iNumServo, int iValor, int iUnidad)
{
  int iMin, iMax;
  
  iMin = 0;
  iMax = 179;


//switch de asignación de rangos de seguridad
   switch (iNumServo)
   {
       case 2: {iMin = 82; iMax = 162; break;}
       case 3: {iMin = 47; iMax = 96; break;}
       case 4: {iMin = 69; iMax = 179; break;}
       case 5: {iMin = 35; iMax = 136; break;}
       case 6: {iMin = 30; iMax = 140; break;}
       case 7: {iMin = 53; iMax = 105; break;}
       case 8: {iMin = 18; iMax = 93; break;}
       case 9: {iMin = 51; iMax = 111; break;}
       case 10: {iMin = 31; iMax = 172; break;}
       case 11: {iMin = 63; iMax = 140; break;}
       case 12: {iMin = 10; iMax = 150; break;}
       case 13: {iMin = 73; iMax = 130; break;}
       case 14: {iMin = 0; iMax = 255; break;}
       case 15: {iMin = 0; iMax = 179; break;}
       case 16: {iMin = 24; iMax = 162; break;}
       case 17: {iMin = 0; iMax = 179; break;}
       case 18: {iMin = 0; iMax = 136; break;}
       case 19: {iMin = 0; iMax = 179; break;}
       case 20: {iMin = 37; iMax = 172; break;}
       case 21: {iMin = 0; iMax = 179; break;}
       case 22: {iMin = 24; iMax = 164; break;}
       case 23: {iMin = 75; iMax = 104; break;}
       case 24: {iMin = 118; iMax = 145; break;}
   }


   if (iUnidad == GRADOS)
   {
     if ((iValor >= iMin) && (iValor <= iMax))
       aServo[iNumServo-2].write(iValor);
       aPosServos[iNumServo-2].iValor = iValor;
       aPosServos[iNumServo-2].iUnidad = iUnidad;
   }
   else
   {
     //aServo[iNumServo].writeMicroseconds(iValor);
   }
}

