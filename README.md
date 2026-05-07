 Employee Management System
A clean, object-oriented C# console application demonstrating Encapsulation, Inheritance, and Polymorphism — core principles of Object-Oriented Programming (OOP).

 Table of Contents
Overview

Features

Project Structure

Concepts Demonstrated

Sample Output

Getting Started

Code Explanation

Validation Rules

Bonus Features

Technologies Used

 Overview
This project implements a simple Employee Management System that manages different types of employees (Developer, Designer, Manager). It demonstrates how OOP principles help create maintainable, scalable, and organized code.

 Features
Feature	Description
 Base Employee Class	Common properties and methods for all employees
 Encapsulation	Private fields with validation logic
 Inheritance	Developer, Designer, and Manager inherit from Employee
 Polymorphism	Overridden Work() methods behave differently per class
 Display Info	Shows detailed employee information
 Input Validation	Prevents invalid IDs (≤ 0) and negative salaries
 Exception Handling	Gracefully handles invalid data
 
 Project Structure
<img width="485" height="370" alt="11" src="https://github.com/user-attachments/assets/e0a180d5-1417-45f8-bf1e-9a69f1a45228" />

Sample Output
--- Work Methods ---
Developer is writing code
Designer is creating UI designs
Manager is leading the team

--- Employee Details ---
ID: 1, Name: Alice, Department: IT, Salary: $75,000.00
Role: Developer, Language: C#

ID: 2, Name: Bob, Department: Design, Salary: $68,000.00
Role: Designer, Tool: Figma

ID: 3, Name: Charlie, Department: Management, Salary: $95,000.00
Role: Manager, Team Size: 5

