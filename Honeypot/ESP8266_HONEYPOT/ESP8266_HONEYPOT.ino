#include <ESP8266WiFi.h>
#include <ESP8266HTTPClient.h>

const char* ssid = "DLINK-DIR650IN";
const char* password = "******";
const char* canaryTokenURL = "http://canarytokens.com/terms/9bwr841apv79vx8wisam2ux70/index.html";

void setup() {
  Serial.begin(115200);
  WiFi.begin(ssid, password);

  while (WiFi.status() != WL_CONNECTED) {
    delay(1000);
    Serial.println("Connecting to WiFi...");
  }

  Serial.println("Connected to WiFi");
}

void loop() {
  if (WiFi.status() == WL_CONNECTED) {
    HTTPClient http;

    Serial.print("Checking Canarytoken: ");
    Serial.println(canaryTokenURL);

    // http.begin(canaryTokenURL);
    WiFiClient client;
    http.begin(client, canaryTokenURL);  // Updated line


    int httpCode = http.GET();

    if (httpCode > 0) {
      if (httpCode == HTTP_CODE_OK) {
        Serial.println("No intrusion detected");
      } else {
        Serial.println("Intrusion detected!");
      }
    } else {
      Serial.printf("HTTP GET request failed, error: %s\n", http.errorToString(httpCode).c_str());
    }

    http.end();
  }

  delay(5000);  // Wait for 5 seconds before checking again
}









