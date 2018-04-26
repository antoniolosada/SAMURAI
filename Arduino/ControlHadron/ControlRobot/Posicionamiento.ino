
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
    AsignarServo(2,34, GRADOS);
    AsignarServo(3,75, GRADOS); // No tiene
    AsignarServo(4,88, GRADOS);
    AsignarServo(5,104, GRADOS);
    AsignarServo(6,135, GRADOS);
    AsignarServo(7,97, GRADOS);
    AsignarServo(8,163, GRADOS);
    AsignarServo(9,88, GRADOS); // No tiene
    AsignarServo(10,115, GRADOS);
    AsignarServo(11,57, GRADOS);
    AsignarServo(12,94, GRADOS);
    AsignarServo(13,75, GRADOS);
    AsignarServo(14,81, GRADOS); // No tiene
    AsignarServo(15,0, GRADOS);
    AsignarServo(16,157, GRADOS);
    AsignarServo(17,103, GRADOS);
    AsignarServo(18,99, GRADOS); // No tiene
    AsignarServo(19,179, GRADOS);
    AsignarServo(20,50, GRADOS);
    AsignarServo(21,51, GRADOS);
    AsignarServo(22,56, GRADOS); //No tiene
    AsignarServo(23,128, GRADOS);
    AsignarServo(24,133, GRADOS); // No tiene
}


void AsignarServo(int iNumServo, int iValor, int iUnidad)
{
  int iMin, iMax;
  
  iMin = 0;
  iMax = 179;

//switch de asignación de rangos de seguridad
   switch (iNumServo)
   {
        case 2: {iMin = 10; iMax = 162; break;}
        case 3: {iMin = 47; iMax = 96; break;}
        case 4: {iMin = 48; iMax = 171; break;}
        case 5: {iMin = 35; iMax = 140; break;}
        case 6: {iMin = 30; iMax = 140; break;}
        case 7: {iMin = 36; iMax = 112; break;}
        case 8: {iMin = 0; iMax = 179; break;}
        case 9: {iMin = 51; iMax = 111; break;}
        case 10: {iMin = 21; iMax = 172; break;}
        case 11: {iMin = 0; iMax = 140; break;}
        case 12: {iMin = 10; iMax = 140; break;}
        case 13: {iMin = 44; iMax = 163; break;}
       case 14: {iMin = 0; iMax = 255; break;}
        case 15: {iMin = 0; iMax = 179; break;}
        case 16: {iMin = 0; iMax = 179; break;}
        case 17: {iMin = 0; iMax = 179; break;}
        case 18: {iMin = 0; iMax = 136; break;}
        case 19: {iMin = 0; iMax = 179; break;}
        case 20: {iMin = 10; iMax = 179; break;}
        case 21: {iMin = 0; iMax = 158; break;}
        case 22: {iMin = 24; iMax = 164; break;}
        case 23: {iMin = 0; iMax = 179; break;}
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

