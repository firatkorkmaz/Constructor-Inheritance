# Constructor Inheritance
A simple program written in C-Sharp to show inheritance in constructor of classes.

## General Information
This program simply prints a list of cars with their brand names, model names, rate numbers and speeds by reading a raw string data and converting it to readable data.  

There are 4 different files in the project:
1. **Program.cs**: This is the main code file that reads the raw string data and adds splitted parts of it to a List of class Register instances, then prints the final results.
2. **Register.cs**: Register class adds further splitted parts of the received data to a List of class Car instances.
3. **Car.cs**: Car class has the " : base(...)" function on its constructor which also initializes the Vehicle class when the received data is processed.
4. **Vehicle.cs**: Vehicle class is initialized by the constructor of Car class with the help of inheritance by using the " : base(...)" function.

## Technologies
This project is created with:
* Microsoft Visual Studio
  * C# Console Application

## Setup & Run
To run this project, open the **ConstructorInheritance.sln** solution file with Visual Studio, then build and run this solution, or use C# compiler to directly compile all the (.cs) files together and run the created executable (.exe) file:
```
csc Program.cs Register.cs Car.cs Vehicle.cs
```
