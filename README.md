# Demo Face Recognition API

## Overview
This project provides a demo API for facial recognition. The API is designed for storing, managing, and recognizing individuals based on their facial features. It leverages Microsoft.ML for face recognition tasks and uses a lightweight SQLite database for storage.

## Features
- **Facial Recognition**: Identify individuals based on pre-processed facial vector features.
- **Face Metadata Storage**: Store information about individuals, including their age, gender, and associated facial data.
- **Face Vector Management**: Manage precomputed vector embeddings for efficient recognition.
- **GDPR Compliance**: Designed with privacy and data protection in mind.

## Database Structure
The project uses the following tables:

- **Persons**: Stores information about persons.
- **FaceMetadata**: Stores metadata related to captured faces, including gender, age, and image path.
- **FaceVectors**: Stores vectorized face data for persons, used for recognition.
- **FaceRecognitionEvents**: Logs each recognition event with a timestamp, camera ID, and type of recognized individual (employee or customer).
- **Cameras**: Stores information about each camera, including camera ID and location.

## GDPR Compliance
This project has been designed to align with the General Data Protection Regulation (GDPR) to ensure data privacy and protection:
- **Data Minimization**: Only essential data (name, age, gender, and facial vectors) is stored.
- **User Consent**: Ensure users provide explicit consent before their data is added to the system.
- **Right to Access**: Users can request access to their stored data.
- **Right to Erasure**: Users can request deletion of their data using the DELETE endpoint.
- **Data Security**: All data is stored securely using SQLite, and the API enforces strict authentication and authorization.
- **Data Anonymization**: When possible, facial data can be processed without linking it to personally identifiable information (PII).

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
   git clone https://github.com/MykolaDiachok/FaceAPI.git
   cd FaceAPI
2. **Navigate to the project directory:**
   ```bash   
   cd FaceAPI
3. **Restore dependencies:**
   ```bash   
   dotnet restore
4. **Run database migrations:**
   ```bash   
   dotnet ef database update
5. **Start the application:**
   ```bash   
   dotnet run
6. **Access the Swagger UI for API testing at http://localhost:5000/swagger.**

## Contributing
Contributions are welcome! Please open an issue or submit a pull request with improvements or bug fixes.

## License
This project is licensed under the MIT License.
