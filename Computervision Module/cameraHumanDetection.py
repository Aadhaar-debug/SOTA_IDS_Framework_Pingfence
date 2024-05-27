from ultralytics import YOLO
import cv2
import cvzone
import math
import time

cap = cv2.VideoCapture(0)  # For Webcam
cap.set(3, 1280)
cap.set(4, 720)

model = YOLO('yolov8n.pt')

classNames = ["person", "bicycle", "car", "motorbike", "aeroplane", "bus", "train", "truck", "boat",
              "traffic light", "fire hydrant", "stop sign", "parking meter", "bench", "bird", "cat",
              "dog", "horse", "sheep", "cow", "elephant", "bear", "zebra", "giraffe", "backpack", "umbrella",
              "handbag", "tie", "suitcase", "frisbee", "skis", "snowboard", "sports ball", "kite", "baseball bat",
              "baseball glove", "skateboard", "surfboard", "tennis racket", "bottle", "wine glass", "cup",
              "fork", "knife", "spoon", "bowl", "banana", "apple", "sandwich", "orange", "broccoli",
              "carrot", "hot dog", "pizza", "donut", "cake", "chair", "sofa", "pottedplant", "bed",
              "diningtable", "toilet", "tvmonitor", "laptop", "mouse", "remote", "keyboard", "cell phone",
              "microwave", "oven", "toaster", "sink", "refrigerator", "book", "clock", "vase", "scissors",
              "teddy bear", "hair drier", "toothbrush"
              ]

prev_frame_time = 0
new_frame_time = 0

while True:
    new_frame_time = time.time()
    success, img = cap.read()
    results = model(img, stream=True)
    for r in results:
        boxes = r.boxes
        for box in boxes:
            cls = int(box.cls[0])
            if cls == 0:  # if class is "person"
                # Bounding Box
                x1, y1, x2, y2 = box.xyxy[0]
                x1, y1, x2, y2 = int(x1), int(y1), int(x2), int(y2)
                w, h = x2 - x1, y2 - y1
                cvzone.cornerRect(img, (x1, y1, w, h))
                # Confidence
                #conf = math.ceil((box.conf[0] * 100)) / 100
                cvzone.putTextRect(img, f'{classNames[cls]}', (max(0, x1), max(35, y1)), scale=2, thickness=2)

    # fps = 1 / (new_frame_time - prev_frame_time)
    fps = 60
    prev_frame_time = new_frame_time
    print(fps)

    cv2.imshow("Image", img)

    # Check for "ESC" key press
    key = cv2.waitKey(1)
    if key == 27:  # "ESC" key
        break

# Release the resources and close the window
cap.release()
cv2.destroyAllWindows()


'''
from ultralytics import YOLO
import cv2
import cvzone
import math
import time
import requests

# Blynk configuration
BLYNK_TEMPLATE_ID = "TMPL3_1l3W4iB"
BLYNK_TEMPLATE_NAME = "Pingfence"
BLYNK_AUTH_TOKEN = "tzO3Xbu-U9g--VAP8PQeQsehOCCu-O1W"
BLYNK_PIN = 'V1'  # Replace with the virtual pin you are using

# Function to switch on the light via Blynk API
def switch_light_on():
    url = f'https://blynk.cloud/external/api/update?token={BLYNK_AUTH_TOKEN}&{BLYNK_PIN}=1'
    response = requests.get(url)
    if response.status_code == 200:
        print("Light switched on")
    else:
        print(f"Failed to switch on light. Status code: {response.status_code}")

cap = cv2.VideoCapture(0)  # For Webcam
cap.set(3, 1280)
cap.set(4, 720)

model = YOLO('yolov8l.pt')

classNames = ["person", "bicycle", "car", "motorbike", "aeroplane", "bus", "train", "truck", "boat",
              "traffic light", "fire hydrant", "stop sign", "parking meter", "bench", "bird", "cat",
              "dog", "horse", "sheep", "cow", "elephant", "bear", "zebra", "giraffe", "backpack", "umbrella",
              "handbag", "tie", "suitcase", "frisbee", "skis", "snowboard", "sports ball", "kite", "baseball bat",
              "baseball glove", "skateboard", "surfboard", "tennis racket", "bottle", "wine glass", "cup",
              "fork", "knife", "spoon", "bowl", "banana", "apple", "sandwich", "orange", "broccoli",
              "carrot", "hot dog", "pizza", "donut", "cake", "chair", "sofa", "pottedplant", "bed",
              "diningtable", "toilet", "tvmonitor", "laptop", "mouse", "remote", "keyboard", "cell phone",
              "microwave", "oven", "toaster", "sink", "refrigerator", "book", "clock", "vase", "scissors",
              "teddy bear", "hair drier", "toothbrush"
              ]

prev_frame_time = 0
new_frame_time = 0

while True:
    new_frame_time = time.time()
    success, img = cap.read()
    results = model(img, stream=True)
    for r in results:
        boxes = r.boxes
        for box in boxes:
            cls = int(box.cls[0])
            if cls == 0:  # if class is "person"
                # Bounding Box
                x1, y1, x2, y2 = box.xyxy[0]
                x1, y1, x2, y2 = int(x1), int(y1), int(x2), int(y2)
                w, h = x2 - x1, y2 - y1
                cvzone.cornerRect(img, (x1, y1, w, h))
                # Confidence
                # conf = math.ceil((box.conf[0] * 100)) / 100
                cvzone.putTextRect(img, f'{classNames[cls]}', (max(0, x1), max(35, y1)), scale=2, thickness=2)
                
                # Switch on the light
                switch_light_on()

    # fps = 1 / (new_frame_time - prev_frame_time)
    fps = 60
    prev_frame_time = new_frame_time
    print(fps)

    cv2.imshow("Image", img)

    # Check for "ESC" key press
    key = cv2.waitKey(1)
    if key == 27:  # "ESC" key
        break

# Release the resources and close the window
cap.release()
cv2.destroyAllWindows()

'''