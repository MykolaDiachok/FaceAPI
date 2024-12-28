# Face Recognition System for Employee and Customer Tracking

## Overview
This project implements a facial recognition system designed to track employees and customers passing through cameras in a retail environment. The system captures facial images or video frames, processes them to extract facial features, and identifies the individuals based on pre-stored facial vectors. The application allows for efficient monitoring of employee and customer activity, providing real-time data and statistics.

## Features
- **Employee and Customer Tracking**: The system can distinguish between employees and customers, storing relevant data.
- **Facial Recognition**: Uses machine learning models to process and identify faces.
- **Database Storage**: All captured data (metadata, face vectors, recognition events) is stored in a local database using Entity Framework Core.
- **Real-time Statistics**: Tracks the number of employees and customers passing through cameras, providing valuable insights into foot traffic.
- **Camera Integration**: Compatible with multiple cameras, allowing for flexible deployment in stores or other environments.
- **Machine Learning Integration**: Utilizes Microsoft.ML to process and train facial recognition models.

## Database Structure
The project uses the following tables:

- **Employees**: Stores information about employees (e.g., name, ID, etc.).
- **Customers**: Stores information about customers.
- **FaceMetadata**: Stores metadata related to captured faces, including gender, age, and image path.
- **FaceVectors**: Stores vectorized face data for employees and customers, used for recognition.
- **FaceRecognitionEvents**: Logs each recognition event with a timestamp, camera ID, and type of recognized individual (employee or customer).
- **Cameras**: Stores information about each camera, including camera ID and location.

## Technologies
- **C#**: Main programming language used for the backend and logic.
- **Microsoft.ML**: Used for machine learning and facial recognition tasks.
- **Entity Framework Core**: ORM for database management.
- **OpenCVSharp**: Library for capturing frames from USB cameras and processing images.
- **Swagger**: API documentation and testing interface.

## Prerequisites
- .NET 9.0 or higher
- SQL Server, SQLite, or another supported database
- A camera for capturing live video or images (USB or IP camera)
- Machine learning models for facial recognition (can be trained or pre-trained models)

## Setup Instructions

1. **Clone the repository:**
   ```bash
   git clone https://github.com/yourusername/face-recognition-system.git
   cd face-recognition-system
