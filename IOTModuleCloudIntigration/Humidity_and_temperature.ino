#define BLYNK_PRINT Serial
#include <ESP8266WiFi.h>
#include <BlynkSimpleEsp8266.h>
#include<HCSR04.h>
#define trig D3
#define echo D2
HCSR04 hc(trig,echo);

char auth[] = "5IdFwfK_pKS6Nkhv0iIy2na7yEDwC-P2 ";
char ssid[] = " Home";   // your ssid 
char pass[] = "child@lock_222"; // your pass

 

BlynkTimer timer;

void sendSensor()
{
  int c = hc.dist();
  if ( c == 0 ) {
    Serial.println("Failed to read from DHT sensor!");
    return;
  }
 
  Blynk.virtualWrite(V4, c);  // select virtual pin (v5) in blynk app
  
 
}

void setup()
{
  // Debug console
  Serial.begin(9600);

  Blynk.begin(auth, ssid, pass);

timer.setInterval(1000L, sendSensor);
}

void loop()
{
  Blynk.run();
  timer.run();    }
