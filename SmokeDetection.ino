
#define BLYNK_TEMPLATE_ID "TMPL3jf_7NQTf"
#define BLYNK_TEMPLATE_NAME "Smoke Detection"

#include <ESP8266WiFi.h>
#include <BlynkSimpleEsp8266.h>
#include <SimpleTimer.h>
#define BLYNK_PRINT Serial    // Comment this out to disable prints and save space
char auth[] = "mbmK8fcNlG3XDY1S3kYq40YD95fhFwoH"; //Enter Authentication code sent by Blynk
 

char ssid[] = "Home"; //Enter WIFI Name
char pass[] = "child@lock_222"; //Enter WIFI Password
 
SimpleTimer timer;
 
int mq2 = D1; // smoke sensor is connected with the D1 
int data = 0; 
void setup() 
{
  Serial.begin(115200);
  Blynk.begin(auth, ssid, pass);
  timer.setInterval(1000L, getSendData);
}
 
void loop() 
{
  timer.run(); // Initiates SimpleTimer
  Blynk.run();
}
 
void getSendData()
{
data = analogRead(mq2); 
  Blynk.virtualWrite(V2, data);
 
  if (data > 700 )
  {
    Blynk.notify("Smoke Detected!"); 
  }
 
}
