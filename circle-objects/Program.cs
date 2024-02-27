/*Circle Objects
 * Mattie Darden
 * 2/25/24 8 */
using circle_objects;
using System;

double radius = 0;
string grow = "y";

//Prompt the user to enter a radius
Console.WriteLine("Entera a radius. You may enter a number with decimals.");

// Keep asking the user until a valid radius is entered
while (true)
{
    Console.Write("Enter the radius: ");
    string input = Console.ReadLine();

    // Try to parse the input as a double
    if (double.TryParse(input, out radius))
    {
        // Check if the radius is valid (greater than 0)
        if (radius > 0)
        {
            // Valid radius entered, break out of the loop
            break;
        }
        else
        {
            // Invalid radius (less than or equal to 0)
            Console.WriteLine("Error: Radius must be greater than 0. Please try again.");
        }
    }
    else
    {
        // Invalid input (not a valid double)
        Console.WriteLine("Error: Invalid input. Please enter a valid number.");
    }
}

Circle circle = new Circle(radius);
double diameter = circle.CalculateDiameter();
double circumference = circle.CalculateCircumference();
double area = circle.CalculateArea();

// Display the valid radius entered by the user
Console.WriteLine($"Valid radius entered: {radius}");
Console.WriteLine($"Diameter: {diameter}");
Console.WriteLine($"Circumference: {circumference}");
Console.WriteLine($"Area: {area}");

do
{
    Console.WriteLine("Should the circle grow?");
    grow = Console.ReadLine();

    if (grow == "y")
    {
        Console.WriteLine("The circle is magically growing.");

        circle.Grow();
        diameter = circle.CalculateDiameter();
        circumference = circle.CalculateCircumference();
        area = circle.CalculateArea();

        Console.WriteLine($"Diameter: {diameter}");
        Console.WriteLine($"Circumference: {circumference}");
        Console.WriteLine($"Area: {area}");
        Console.WriteLine($"Radius {circle.GetRadius()}");
    }
}
while (grow.ToLower().Trim() == "y");

Console.WriteLine($"The circle's final radius is {circle.GetRadius()}");

