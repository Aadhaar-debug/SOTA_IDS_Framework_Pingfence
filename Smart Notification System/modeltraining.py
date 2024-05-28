import pandas as pd
import numpy as np
from sklearn.model_selection import train_test_split
import tensorflow as tf
from tensorflow.keras.models import Sequential
from tensorflow.keras.layers import Dense
from tensorflow.keras.optimizers import Adam

# Load the dataset
data = pd.read_csv('surveillance_data.csv', encoding='utf-8')
X = data[['sensor_reading']].values
y = data['threat_level'].values

# Normalize the feature data
X = X / np.max(X)

# Split the dataset into training and testing sets
X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.2, random_state=42)

# Build the neural network model
model = Sequential()
model.add(Dense(64, input_dim=X_train.shape[1], activation='relu'))
model.add(Dense(32, activation='relu'))
model.add(Dense(16, activation='relu'))
model.add(Dense(1, activation='linear'))

# Compile the model
model.compile(optimizer=Adam(learning_rate=0.001), loss='mean_squared_error')

# Train the model
try:
    model.fit(X_train, y_train, epochs=50, batch_size=10, validation_split=0.2)
except Exception as e:
    # Handle the exception and ensure proper encoding of error message
    error_msg = f"An error occurred during training: {str(e)}"
    print(error_msg.encode('utf-8').decode('utf-8'))  # Ensure proper encoding and decoding

# Save the model to a file
model.save('threat_classifier.h5')
print("Model trained and saved to 'threat_classifier.h5'")
