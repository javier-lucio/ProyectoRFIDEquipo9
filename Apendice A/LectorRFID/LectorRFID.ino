#include <SPI.h>
#include <MFRC522.h>

#define SS_PIN 10
#define RST_PIN 9
MFRC522 mfrc522(SS_PIN, RST_PIN);  // CREA INSTANCIA
/////////////////////////////////////////////////////////////////////////
int lectura;
byte targeta[4];
char caracter[32] = "";
String UID;
////////////////////////////////////////////////////////////////////////
void setup() {
  Serial.begin(9600); //INICIALIZA  LA COMNUNICACION SERIAL CON EL ORDENADOR
  SPI.begin();      // INICIA SPI BUS
  mfrc522.PCD_Init(); // INICIA MFRC522 
}
///////////////////////////////////////////////////////////////////////
void loop() {
  lectura = obtenerUID();
 
  if(lectura){
    Serial.print(UID);
    delay(1000);
  }
}
//////////////////////////////////////////////////////////////////////
int obtenerUID()
{  
  if(!mfrc522.PICC_IsNewCardPresent()){
    return 0;
  }
  if(!mfrc522.PICC_ReadCardSerial()){
    return 0;
  }
  for(int i=0;i<4;i++){
    targeta[i]=mfrc522.uid.uidByte[i]; //ALMACENA EL UID DE LA ETIQUETA EN LA TARGETA
    matrizdecadena(targeta, 4, caracter);
    UID = caracter;
  }
  mfrc522.PICC_HaltA();
  return 1;
}
//////////////////////////////////////////////////////////////////////
void matrizdecadena(byte array[], unsigned int len, char buffer[])
{
    for (unsigned int i = 0; i < len; i++)
    {
        byte nib1 = (array[i] >> 4) & 0x0F;
        byte nib2 = (array[i] >> 0) & 0x0F;
        buffer[i*2+0] = nib1  < 0xA ? '0' + nib1  : 'A' + nib1  - 0xA;
        buffer[i*2+1] = nib2  < 0xA ? '0' + nib2  : 'A' + nib2  - 0xA;
    }
    buffer[len*2] = '\0';
}
