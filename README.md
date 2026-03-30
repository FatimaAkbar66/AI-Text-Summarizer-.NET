# AI Text Summarizer (.NET Windows Forms)

A professional desktop application built using C# and Windows Forms that leverages the Google Gemini 2.5 Flash API to provide instant, highly accurate text summarization. The application features a modern, side-by-side "Soft-UI" layout that allows users to toggle between paragraph and bullet-point summary formats.

## 📌 Project Overview
This project was developed as a practical programming assignment to demonstrate API integration, asynchronous programming in .NET, and advanced UI/UX design practices in desktop environments.

## ✨ Key Features
* **Real-Time AI Summarization:** Connects seamlessly to the Gemini 2.5 Flash model for fast and intelligent text processing.
* **Dual-Format Output:** Fully functional toggle buttons allowing users to choose between a cohesive Paragraph or structured Bullet Points.
* **Modern Side-by-Side UI:** A clean widescreen experience with separate panels for input and output to maximize readability.
* **Automated Word Counter:** Live character/word counters for both the input and result boxes.
* **Smart Placeholders:** Interactive text boxes that clear instructions automatically upon focus.
* **Advanced Error Handling:** Comprehensive try-catch blocks to gracefully handle network dropouts or API quota limitations.

## 🛠️ Tech Stack & Dependencies
* **Language:** C# (.NET Framework / .NET Core)
* **Framework:** Windows Forms (WinForms)
* **API Used:** Google Gemini 2.5 Flash (via `HttpClient` and JSON payload mapping)
* **Libraries:** `Newtonsoft.Json` (for robust API response parsing)

---

## 🚀 How to Run the Project

### 1. Prerequisites
* **Visual Studio** (2019 or newer recommended) with the .NET Desktop Development workload installed.
* **Newtonsoft.Json** NuGet Package. (If not installed, go to `Tools` > `NuGet Package Manager` > `Manage NuGet Packages for Solution` and install `Newtonsoft.Json`).

### 2. Setting up the API Key
For security purposes, the actual API Key has been omitted from the public repository. To run the application successfully:
1. Obtain a free API Key from [Google AI Studio](https://aistudio.google.com/).
2. Open `Form1.cs` in Visual Studio.
3. Locate the `GetSummaryFromAI` method.
4. Replace the placeholder string in `string geminiApiKey = "Api";` with your actual generated key.

### 3. Execution
1. Open the project's `.sln` file in Visual Studio.
2. Press **F5** or click the **Start** button to build and execute the project.

---

## 🔄 Version Control & Commits
This repository strictly follows the parallel commit guidelines required for this coursework. Significant layout adjustments, API troubleshooting maneuvers, and control integrations have been logged systematically. 

## Screenshots of Application

<img width="775" height="380" alt="imageUI" src="https://github.com/user-attachments/assets/664137a5-5ffd-4f50-a08e-54e499654c30" />

## Output:
<img width="767" height="384" alt="output" src="https://github.com/user-attachments/assets/50d1731e-8d5d-4469-8fbd-116b5f7efde4" />



