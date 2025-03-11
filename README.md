📱 Smartphone Customizer

A Windows Forms Application built in C# that allows users to customize smartphones, apply extra features, process orders, and generate detailed reports.

📌 Project Overview

The Smartphone Customizer is a dynamic application designed to simulate an e-commerce smartphone customization platform. Users can:

Customize smartphone specifications (Model, Processor, RAM, Storage).

Apply additional features like Extended Warranty and Custom Engraving.

Choose from different pricing strategies (Standard, Discount, Premium).

Process orders with payment, inventory updates, and shipping.

Generate detailed order reports with real-time status updates.

📐 Design Patterns Used

This project utilizes several design patterns to ensure modularity and maintainability:

🟢 Builder Pattern: For constructing customizable smartphone objects step-by-step.

🔵 Decorator Pattern: To dynamically add optional features (e.g., warranty, engraving).

🟡 Mediator Pattern: To handle communication between the Payment, Inventory, and Shipping modules.

🔴 Observer Pattern: For real-time notifications when the order status changes.

🟠 Strategy Pattern: To implement flexible pricing models (Standard, Discount, Premium).

🛠️ Features

✅ Customize a smartphone's Model, Processor, RAM, and Storage.

✅ Apply extra features:

Extended Warranty (+$50)

Custom Engraving (+$30)

✅ Choose from three Pricing Strategies:

Standard (Default price)

Discount (10% Off)

Premium (5% Increase)

✅ Process orders through the Order Mediator:

Payment Processing

Inventory Management

Shipping Scheduling

✅ Generate Color-Coded Order Reports displaying:

Customer Information

Smartphone Specifications

Payment, Inventory, and Shipping Status

✅ User-friendly interface with interactive buttons, combo boxes, and input fields.

📊 Technologies Used

C# (Windows Forms Application)

Object-Oriented Programming (OOP Principles)

Design Patterns (Builder, Decorator, Mediator, Observer, Strategy)

Windows Forms UI (Interactive Form Design)

🚀 How to Run the Project

Prerequisites

Ensure you have the following installed:

Visual Studio (with .NET Framework support)

Windows OS (for Windows Forms compatibility)

Steps to Run

Clone the Repository:

git clone https://github.com/MarwaMahmoudSoliman/Order-Processing-System.git
cd smartphone-customizer

Open the Project:
Open the SmartPhoneCustomizer.sln file in Visual Studio.

Restore Dependencies (if needed):

dotnet restore

Build the Project:

Ctrl + Shift + B

Run the Application:

Ctrl + F5

📖 Usage Guide

Customize Smartphone:

Enter model (e.g., "Galaxy S23 Ultra").

Choose processor (e.g., "Snapdragon 8 Gen 3").

Specify RAM (e.g., 16 GB) and storage (e.g., 512 GB).

Select Extras:

Check Extended Warranty or Engraving.

Choose Pricing Strategy:

Select Standard, Discount, or Premium from the dropdown.

Execute Actions:

🔨 Build Order – Create a smartphone object.

➕ Apply Extras – Apply selected extra features.

🚚 Process Order – Simulate payment, inventory update, and shipping.

View Reports:

Order status is displayed in a color-coded report.

📷 Screenshots

Main Interface


Order Report


🧑‍💻 Project Structure

📂 SmartPhoneCustomizer
├── 📁 Properties
├── 📁 bin
├── 📁 obj
├── 📂 Assets (for images)
├── 📄 MainForm.cs (Main UI)
├── 📄 SmartphoneBuilder.cs (Builder Pattern)
├── 📄 OrderMediator.cs (Mediator Pattern)
├── 📄 OrderProcessingReportForm.cs (Order Report UI)
└── 📄 Program.cs (Entry Point)

🗒️ Future Improvements

🔲 Add User Authentication for personalized orders.

🔲 Implement Export to PDF for detailed invoices.

🔲 Integrate REST API for external order tracking.

🔲 Allow multiple orders and batch processing.

📫 Contact

For questions, collaboration, or feedback:

Your Name – www.linkedin.com/in/marwa-m-soliman

GitHub – https://github.com/MarwaMahmoudSoliman

Email – marwasolimanmahmoud@gmail.com

⭐ Contributions Welcome!

Feel free to fork the repository, open pull requests, and share your ideas!
