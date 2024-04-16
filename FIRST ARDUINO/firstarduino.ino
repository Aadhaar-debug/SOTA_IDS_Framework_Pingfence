// This code sets up and runs two ultrasonic sensors to measure distances and turn on an LED if the distance is below a certain threshold.

// Define the pins used for the ultrasonic sensors and the LED
const int TRIG_PIN = 6;
const int ECHO_PIN = 7;
const int TRIG_PI = 5;
const int ECHO_PI = 4;
const int LED_PIN = 3;

// Set the distance threshold for the LED to turn on
int DISTANCE_THRESHOLD = 20;

// Variables to store the duration of the sound wave and the distance calculated from it
float duration_us , distance_cm;

// Set up the Arduino board
void setup()
{
  // Begin serial communication at 9600 bits per second
  Serial.begin(9600);

  // Set the pins for the ultrasonic sensors as output and input
  pinMode(TRIG_PIN, OUTPUT);
  pinMode(ECHO_PIN, INPUT);
  pinMode(TRIG_PI, OUTPUT);
  pinMode(ECHO_PI, INPUT);

  // Set the LED pin as output
  pinMode(LED_PIN, OUTPUT);

  // Set pin 13 as output and pin 2 as input
  pinMode(13, OUTPUT);
  pinMode(2, INPUT);
}

// Continuously measure the distance using the ultrasonic sensors and turn on the LED if the distance is below the threshold
void loop()
{
  // Read the value from pin 2
  int value = digitalRead(2);

  // If the value is 1, turn on the LED
  if (value == 1)
  {
    digitalWrite(13,HIGH);
  }
  // If the value is 0, turn off the LED
  else
  {
    digitalWrite(13, LOW);
  }

  // Measure the distance using the first ultrasonic sensor
  distance_cm = SonarSensor(TRIG_PIN, ECHO_PIN);

  // If the distance is below the threshold, turn on the LED
  if(distance_cm < DISTANCE_THRESHOLD)
  {
    digitalWrite(LED_PIN,HIGH);
  }
  // If the distance is not below the threshold, measure the distance using the second ultrasonic sensor
  else
  {
    distance_cm = SonarSensor(TRIG_PI , ECHO_PI);
  }
  // If the distance is below the threshold, turn on the LED
  if(distance_cm < DISTANCE_THRESHOLD)
  {
    digitalWrite(LED_PIN , HIGH);
  }
  // If the distance is not below the threshold, turn off the LED
  else
  {
    digitalWrite(LED_PIN , LOW);
  }
  }
}

// Function to measure the distance using the ultrasonic sensor
float SonarSensor(int trigPin , int echoPin)
{
  // Send a 10 microsecond pulse to the ultrasonic sensor to trigger it
  digitalWrite(trigPin , HIGH);
  delayMicroseconds(10);
  digitalWrite(trigPin , LOW);

  // Measure the duration of the sound wave and calculate the distance from it
  float duration_us = pulseIn(echoPin , HIGH);
  float distance_cm = 0.017 * duration_us;

  // Return the distance calculated from the duration of the sound wave
  return distance_cm;
}
