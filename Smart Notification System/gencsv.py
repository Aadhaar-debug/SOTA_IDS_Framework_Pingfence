import pandas as pd
import numpy as np

# Parameters
num_samples = 1000
sensor_min = 0
sensor_max = 3000

# Generate random sensor readings
sensor_readings = np.random.randint(sensor_min, sensor_max, num_samples)

# Define threat level based on sensor reading
def determine_threat_level(reading):
    if reading < 1500:
        return 1
    elif reading < 2100:
        return 2
    else:
        return 3

# Generate threat levels based on sensor readings
threat_levels = [determine_threat_level(reading) for reading in sensor_readings]

# Create a DataFrame
data = pd.DataFrame({
    'sensor_reading': sensor_readings,
    'threat_level': threat_levels
})

# Save to CSV
data.to_csv('surveillance_data.csv', index=False)

print("Synthetic dataset generated and saved to 'surveillance_data.csv'")
