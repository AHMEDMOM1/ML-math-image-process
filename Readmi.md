# Math, Image Processing & KNN ML Application

This Windows Forms application demonstrates three independent modules:
1. **Mathematical Operations Module**
2. **Image Processing Module**
3. **Machine Learning Module (KNN Classifier)**

Each module is fully separated using OOP principles such as interfaces, services, and models.

---

## 🧮 1. Math Module

### Features
- Sum of numbers
- Average calculation
- Standard deviation calculation

### Architecture
- `IMathService` — Interface defining the math operations  
- `MathService` — Implementation of math logic  
- UI Tab: Allows user to enter numbers and view results  

### Purpose
This module introduces numerical processing and demonstrates how to structure logic using service classes.

---

## 🖼️ 2. Image Processing Module

### Features
- Load image  
- Convert to grayscale  
- Invert image  
- Save processed image  

### Architecture
- `IImageService` — Interface defining image operations  
- `ImageService` — Implements pixel-level processing  
- Two picture boxes: Input & Output  
- Buttons for each transformation  

### Purpose
Shows how to handle bitmap manipulation using C#, and applies OOP separation of concerns between UI and processing logic.

---

## 🤖 3. Machine Learning (KNN Classifier)

### Features
- Displays training data in a grid  
- User enters new values (Feature1 & Feature2)  
- Predicts class label using KNN (k=3)  

### Architecture
- `DataPoint` model  
- `IClassifier` — Interface for classifiers  
- `KnnClassifier` — Implements KNN algorithm  
- UI Tab: Inputs, output, and training data grid  

### Purpose
Introduces fundamental ML classification through a simple yet effective algorithm (KNN).  
Teaches distance calculation, pattern matching, and decision-making logic.

---

## 💡 Technologies Used
- C# (.NET Framework)
- Windows Forms
- DevExpress Controls
- Object-Oriented Programming (OOP)

---

## 🎯 Key Learning Outcomes
- Modular application design  
- Service-based architecture  
- Image processing fundamentals  
- Basic machine learning concept (KNN)  
