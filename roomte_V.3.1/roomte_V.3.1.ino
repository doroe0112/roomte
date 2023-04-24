#include <IRremote.h>
IRsend irsend;

long ir [] = {0x400501FE, 0x400510EF, 0x400557A8, 0x400550AF, 0x4005708F, 0x400555AA, 0x400556A9, 0x84C, 0x878, 0x41, 0x842, 0x43, 0x844, 0x45, 0x846, 0x47, 0x848, 0x49, 0x840, 0x60, 0x861, 0x70, 0x869, 0x52, 0x84A, 0x65, 0x854, 0x56, 0x853, 0x55, 0x875, 0xFF02FD, 0xFF3AC5, 0xFFBA45, 0xFFE817, 0xFFC837, 0xFF20DF, 0xFFA05F, 0xFF609F, 0xFFE01F, 0xFF1AE5, 0xFFA25D, 0xFF9A65, 0xFF22DD, 0xFF58A7, 0xFF926D, 0xFF8A75, 0xFFAA55, 0xFFB847, 0xFF18E7, 0xFF2AD5, 0xFF0AF5, 0xFF38C7, 0xFF986799};
String cd [54];

String TvPt;

void setup()
{
  Serial.begin(9600);
  Serial.setTimeout(200);
  pinMode(8, OUTPUT);
  digitalWrite(8, HIGH);

  Serial.println("Setup Begonnen");

  cd[15] = "07268";
  int i = 0;

  do
  {
    if (Serial.available() > 0)
    {
      cd[i] = Serial.readString();
      i ++;
    }
  }
  while (cd[15] == "07268");
  Serial.println("Setup abgeschlossen");
}

void loop()
{


  if (Serial.available() > 1)
  {
    String u = Serial.readString();
    int i = 0;
    bool test = false;

    do
    {
      if (u == cd[i])
      {

        test = true;

        if (i >= 0 and i <= 6)
          irsend.sendNEC(ir[i], 32);
        else
        {
          if (i >= 7 and i <= 30)
            irsend.sendRC5(ir[i], 8);
          else
          {
            if (i >= 32 and i <= 53)
              irsend.sendNEC(ir[i], 32);
          }
        }


      }
      else
        i++;
    }
    while (test == false or i < 54);
    /*
        {
          if (i < 0)
          {
            Serial.println(i);
            int y = 32768 - i;
            Serial.println(y);
            i = y + 32768;
            Serial.println(i);
          }
          else
            Serial.println(i);
          //Serial.println(ir[i]);
          /*if (i >= 7 and i <= 30)
            {
            irsend.sendRC5(ir[i], 12);
            }
            else
            {
            irsend.sendNEC(ir[i], 32);
            }*/

  }

}
