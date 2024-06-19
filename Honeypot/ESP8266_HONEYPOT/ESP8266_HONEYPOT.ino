#include <Keyboard.h>

// GPIO pin definitions for ESP8266
#define VRX_PIN A0      // Analog input
#define VRY_PIN A1      // Analog input

void setup() {
  Serial.begin(115200);
  delay(2000); // Delay for serial monitor to initialize
  Keyboard.begin(); // Initialize the keyboard
}

void loop() {
  // Read joystick values
  int vrxValue = analogRead(VRX_PIN);
  int vryValue = analogRead(VRY_PIN);

  // Determine joystick movement
  String joystickDirection = getJoystickDirection(vrxValue, vryValue);

  // Simulate key presses based on joystick direction
  sendKeyboardCommand(joystickDirection);

  delay(100);
}

String getJoystickDirection(int x, int y) {
  if (x < 100) {
    return "LEFT";
  } else if (x > 900) {
    return "RIGHT";
  } else if (y < 100) {
    return "UP";
  } else if (y > 900) {
    return "DOWN";
  } else {
    return "CENTER";
  }
}

void sendKeyboardCommand(String direction) {
  if (direction == "LEFT") {
    Keyboard.write(KEY_LEFT_ARROW); // Simulate pressing left arrow key
  } else if (direction == "RIGHT") {
    Keyboard.write(KEY_RIGHT_ARROW); // Simulate pressing right arrow key
  } else if (direction == "UP") {
    Keyboard.write(KEY_UP_ARROW); // Simulate pressing up arrow key
  } else if (direction == "DOWN") {
    Keyboard.write(KEY_DOWN_ARROW); // Simulate pressing down arrow key
  }
}
