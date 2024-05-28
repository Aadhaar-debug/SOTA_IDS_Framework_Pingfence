import RPi.GPIO as GPIO
import spidev
import time
import joblib
import smtplib
from email.mime.text import MIMEText

# Setup GPIO
GPIO.setmode(GPIO.BCM)
GPIO.setwarnings(False)

# SPI setup for MCP3008
spi = spidev.SpiDev()
spi.open(0, 0)
spi.max_speed_hz = 1350000

# Load the trained model
model = joblib.load('threat_classifier.h5')

# ADC Channel where the surveillance module is connected
adc_channel = 0

# Email setup
smtp_server = 'smtp.your_email_provider.com'
smtp_port = 587
smtp_user = 'ckeve911@gmail.com'
smtp_password = 'Fallinlovewithfailure@01'
recipient_email = 'aadhaarkoul2002@gmail.com'

def read_adc(channel):
    adc = spi.xfer2([1, (8 + channel) << 4, 0])
    data = ((adc[1] & 3) << 8) + adc[2]
    return data

def predict_threat_level(sensor_value):
    prediction = model.predict([[sensor_value]])
    return prediction[0]

def send_notification(threat_level):
    subject = f'Intrusion Detected: Threat Level {threat_level}'
    body = f'Threat level detected: {threat_level}\nTake appropriate action.'
    msg = MIMEText(body)
    msg['Subject'] = subject
    msg['From'] = smtp_user
    msg['To'] = recipient_email
    
    with smtplib.SMTP(smtp_server, smtp_port) as server:
        server.starttls()
        server.login(smtp_user, smtp_password)
        server.sendmail(smtp_user, recipient_email, msg.as_string())

try:
    while True:
        adc_value = read_adc(adc_channel)
        threat_level = predict_threat_level(adc_value)
        print(f'Threat Level: {threat_level}, ADC Value: {adc_value}')
        
        send_notification(threat_level)
        
        time.sleep(10)  # Delay between checks
except KeyboardInterrupt:
    pass
finally:
    GPIO.cleanup()
