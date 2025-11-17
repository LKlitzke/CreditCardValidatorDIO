[Leia em Português](./README.pt-BR.md) | [Read in English](./README.md)

# Credit Card Brand Validator

![.NET](https://img.shields.io/badge/.NET-8-blue.svg)
![C#](https://img.shields.io/badge/C%23-12-green.svg)
![License](https://img.shields.io/badge/License-MIT-yellow.svg)

A simple yet robust console application built with .NET 8 and C# 12 to identify the brand of a credit card based on its number. The project follows Clean Code principles, separating concerns for easy maintenance and extensibility.


This project was developed as part of a challenge proposed by the **[Digital Innovation One (DIO)](https://www.dio.me/)** learning platform. The goal is to recreate or enhance the original project, applying the concepts learned and using GitHub Copilot to accelerate development.

## 🚀 Features

-   **Brand Identification**: Identifies major credit card brands from the provided number.
-   **Regex-Powered**: Uses compiled regular expressions for efficient and accurate pattern matching.
-   **Clean Architecture**: The validation logic is decoupled from the user interface, making the code easy to read and test.
-   **Interactive Console UI**: A simple, looping console interface allows for multiple validations without restarting the application.
-   **Input Normalization**: Automatically sanitizes user input by removing spaces and non-numeric characters before validation.

## 💳 Supported Brands

The validator can identify the following credit card brands:

-   American Express
-   Aura
-   Diners Club
-   Discover
-   EnRoute
-   HiperCard
-   JCB
-   MasterCard
-   Visa
-   Voyager

## 🛠️ Technologies Used

-   **.NET 8**: The underlying framework for the application.
-   **C# 12**: The programming language used to build the logic.
-   **Regular Expressions**: For defining and matching card number patterns.

## ⚙️ How to Run

1.  Clone the repository:
    ```bash
    git clone https://github.com/LKlitzke/CreditCardValidatorDIO.git
    ```
2.  Navigate to the project directory:
    ```bash
    cd CreditCardValidatorDIO
    ```
3.  Run the application using the .NET CLI:
    ```bash
    dotnet run
    ```
4.  Enter a credit card number when prompted and press Enter. The application will display the identified brand.

## 🏗️ Code Structure

-   `Program.cs`: Contains the main application entry point and the user interaction loop. It is responsible for handling console input and output.
-   `CardUtils/`: A dedicated namespace for the core validation logic.
    -   `CreditCardValidator.cs`: A static class that orchestrates the validation process. It holds a list of supported brands and the main `IdentifyBrand` method.
    -   `CardBrand.cs`: A class representing a single credit card brand, containing its name and the regex pattern used for validation. This design makes it simple to add new brands without modifying the core validation logic.