#include <IRremote.h>
IRsend irsend;

String cd [54];


void setup()
{
  Serial.begin(9600);
  Serial.setTimeout(200);
  pinMode(10, OUTPUT);
  pinMode(11, OUTPUT);
  pinMode(13, OUTPUT);
  pinMode(20, OUTPUT);
  pinMode(30, OUTPUT);
  pinMode(31, OUTPUT);

  digitalWrite(13, HIGH);
  delay(1000);
  digitalWrite(13, LOW);
  delay(1000);
  digitalWrite(13, HIGH);
  delay(1000);
  digitalWrite(13, LOW);
  delay(1000);




  Serial.println("Setup Begonnen");

  cd[6] = "07268";

  int i = 0;
  do
  {

    if (Serial.available() > 0)
    {
      cd[i] = Serial.readString();
      i ++;
    }
  }
  while (cd[6] == "07268");
  Serial.println("Setup abgeschlossen");

  digitalWrite(13, HIGH);
  delay(1000);
  digitalWrite(13, LOW);
  delay(1000);
  digitalWrite(13, HIGH);
  delay(1000);
  digitalWrite(13, LOW);
  delay(1000);
}

void loop()
{


  if (Serial.available() > 1)
  {
    String u = Serial.readString();
    int i = 0;


    if (cd[0] == u) //esstisch aus
    {
      digitalWrite(10, HIGH);
      delay(300);
      digitalWrite(10, LOW);
    }

    if (cd[1] == u) //esstisch an
    {
      digitalWrite(11, HIGH);
      delay(300);
      digitalWrite(11, LOW);
    }

    if (cd[2] == u)
      digitalWrite(20, HIGH);

    if (cd[3] == u)
      digitalWrite(20, LOW);


    if (cd[4] == u) //rolladen runter
    {
      digitalWrite(30, HIGH);
      delay(300);
      digitalWrite(30, LOW);
    }

    if (cd[5] == u) //rolladen hoch
    {
      digitalWrite(31, HIGH);
      delay(300);
      digitalWrite(31, LOW);
    }

  }

}
