//const int powerpin = 13;              // analog input pin 5 -- voltage
int xpin = A3;                  // x-axis of the accelerometer
int ypin = A2;                  // y-axis
int zpin = A1;                  // z-axis (only on 3-axis models)

void setup() {
  // initialize the serial communications:
  Serial.begin(9600);
  //pinMode(powerpin, OUTPUT);
  //digitalWrite(powerpin, HIGH);
}

void loop() 
{
  // print the sensor values:
  Serial.print(analogRead(xpin));
  // print a tab between values:
  Serial.print(' ');
  Serial.print(analogRead(ypin));
  // print a tab between values:
  Serial.print(' ');
  Serial.print(analogRead(zpin));
  Serial.println();
  // delay before next reading:
  delay(100);
}
