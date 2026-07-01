# DEVELOPMENT-OF-CYBER-PHYSICAL-SIMULATION-FOR-FLOOD-EARLY-WARNING-SYSTEM-WITH-.NET-MAUI-AND-OPENCV
Project ini merupakan implementasi sistem pemantauan banjir cerdas yang dirancang untuk mengatasi kerentanan sistemik pada stasiun pemantauan tradisional. Menggunakan arsitektur .NET MAUI, sistem ini mengimplementasikan dua lapisan keamanan: autentikasi kredensial dan verifikasi wajah berbasis Haar Cascad

# Cyber-Physical Simulation for Flood Early Warning System (FFEWS)
A robust, cost-effective Flash Flood Early Warning System (FFEWS) utilizing Cyber-Physical System (CPS) principles. This application replaces traditional, expensive, and physically vulnerable sensor hardware with a software-based approach, leveraging a single commodity webcam for both biometric security and real-time visual water level monitoring.

# Overview
This project, developed using **C# .NET MAUI**, implements a two-step authentication gateway and a real-time computer vision monitoring dashboard. By utilizing **OpenCV (OpenCvSharp)**, the system performs identity verification and processes live video feeds to detect and track water levels using HSV color segmentation.

## 🔑 Key Features
*   **Biometric Access Protection**: Two-step authentication combining password-based login with facial verification (Haar Cascade).
*   **Software-Based Sensing**: Eliminates dedicated hardware dependence by repurposing a single webcam for dual roles (Identity verification & Water-level monitoring).
*   **Real-Time Computer Vision**: Uses HSV color-space thresholding to track floating markers and estimate water levels in real-time.
*   **Autonomous Control Logic**: Implements a three-zone control loop (Safe, Warning, Danger) that automatically actuates simulated pumps and triggers audio-visual alarms.
*   **Edge-Ready Performance**: Demonstrates high responsiveness with control latency between 35–42 milliseconds.

## 🛠 Tech Stack
*   **Framework**: .NET MAUI (Cross-platform)
*   **Vision Library**: OpenCV (via OpenCvSharp)
*   **Language**: C#
*   **Interface**: XAML

## 📋 System Architecture
The system operates on a linear three-page architecture:
1.  **Authentication Layer**: Login and Register pages secured with Role-Based Access Control (RBAC).
2.  **Verification Layer**: Facial recognition gateway using Haar Cascade classification.
3.  **Command Center (Dashboard)**: Real-time telemetry, visual water level analysis, and automated actuator control.

## 📊 System Design & Workflow

Berikut adalah visualisasi arsitektur sistem dan alur kerja aplikasi yang diimplementasikan:

### 1. UML Class Diagram
Diagram ini memetakan hubungan antara komponen halaman, layanan basis data, dan model data user dalam FloodWarnApp.

![UML Class Diagram](<img width="3091" height="3190" alt="uml" src="https://github.com/user-attachments/assets/18e3bc75-c1de-4153-b561-6803b4761cf7" />
)

### 2. System Flowcharts
Alur kerja sistem dibagi menjadi dua logika utama:

*   **Registration Logic**: Menjelaskan proses pembuatan akun pengguna baru.
    ![Flowchart Registration] <img width="2363" height="6115" alt="Flowchart RegisterPage-2026-06-20-051759" src="https://github.com/user-attachments/assets/0325fa66-ee2e-4a69-b8bf-505de8a46366" />

*   **Authentication Logic**: Alur verifikasi kredensial saat login.
    ![Flowchart Login] <img width="3948" height="6204" alt="Flowchart LoginPage-2026-06-20-051723" src="https://github.com/user-attachments/assets/92358c56-0e18-4e91-8a03-ed0c9965fbdf" />

*   **Verification Logic**: Alur deteksi wajah menggunakan OpenCV pada `VerificationPage`.
    ![Flowchart Verification] <img width="2448" height="7775" alt="Flowchart VerificationPage-2026-06-20-052019" src="https://github.com/user-attachments/assets/b9ff864f-a8ef-49b4-9c3a-d2be3fd9046e" />

*   **DatabaseService innitAsync**: 
    ![DatabaseService innitAsync] <img width="1912" height="5417" alt="DatabaseService - InitAsync Flowchart-2026-06-20-052335" src="https://github.com/user-attachments/assets/afaeed3e-cc94-4e14-ae8e-48cd2070274d" />

*   **DatabaseService AddUserAsync**: 
    ![DatabaseService AddUserAsync] <img width="1152" height="2680" alt="DatabaseService - AddUserAsync Flowchart-2026-06-20-052836" src="https://github.com/user-attachments/assets/93719e08-baf3-4725-8ea2-d7a16a444a69" />

*   **DatabaseService GetUserAsync**: 
    ![Flowchart Verification] <img width="1697" height="3389" alt="DatabaseService - GetUserAsync Flowchart-2026-06-20-052850" src="https://github.com/user-attachments/assets/4a069eac-bd63-46b7-a726-30a6940e626c" />

## ⚙️ How It Works (Control Logic)
The system maps detected water levels (TMA) to a 0-100% scale and executes commands based on defined zones:
*   **Safe (0-49%)**: Baseline standby.
*   **Warning (50-79%)**: Enhanced monitoring, visual alerts.
*   **Danger (80-100%)**: Automated pump activation and emergency siren trigger.

## 📂 Repository Structure
*   `/src`: Contains the .NET MAUI source code.
*   `/assets`: Project documentation and supporting media.
*   `/docs`: Detailed research and methodology papers.

## 📜 Citation/Reference
This project is based on the study: "DEVELOPMENT OF CYBER-PHYSICAL SIMULATION FOR FLOOD EARLY WARNING SYSTEM WITH BIOMETRIC ACCESS PROTECTION USING .NET MAUI AND OPENCV" by Vyanda Kartika Fajarina et al. [cite: 1]

---
*Maintained by the Instrumentation Engineering Department, Institut Teknologi Sepuluh Nopember.*
README.md
Menampilkan README.md.
