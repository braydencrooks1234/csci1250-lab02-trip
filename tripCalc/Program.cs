/*
 * Name: Brayden Crooks
 * Course: CSCI 1250, Section 001
 * Assignment: Lab 02, Trip Calculator
 * Date: September 23, 2026
 * Description: Calculates the fuel, food, and work hours behind one road trip.
 */

Console.WriteLine("=== Part 1: Road Trip ===");

Console.Write("What was the round trip in miles? ");
int milesForTheTrip = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the miles per gallon of the car you are using? ");
int milesPerGallon = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the gas price? ");
double gasPrice = Convert.ToDouble(Console.ReadLine());

//do the math

double gallonsNeeded = milesForTheTrip / (double)milesPerGallon;
double fuelCost = gallonsNeeded * gasPrice;

//do the output

Console.WriteLine("");
Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
Console.WriteLine("Fuel Cost: " + fuelCost.ToString("C"));
Console.WriteLine("");

//Pizza Party

const int slicesPerPizza = 8;

//Gather the data

Console.WriteLine("=== Part 2: Pizza Party ===");

Console.WriteLine("How many people are going? ");
int peopleGoing = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many pizzas will there be? ");
double pizzaAmount = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("What was the price per pizza? ");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());

//do the math

double totalSlices = pizzaAmount * slicesPerPizza;
double slicesPerPerson = totalSlices / (double)peopleGoing;
double pizzaCost = pizzaAmount * pricePerPizza;

Console.WriteLine("");
Console.WriteLine("Total slices: " + totalSlices.ToString());
Console.WriteLine("Slices per person: " + slicesPerPerson.ToString("F1"));
Console.WriteLine("Pizza cost: " + pizzaCost.ToString("C"));
Console.WriteLine("");

//Paycheck

double taxRate = 0.18;

//collect data

Console.WriteLine("=== Part 3: Paycheck ===");

Console.WriteLine("How many hours did you work this week? ");
double hoursWorked = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("What is your hourly rate? ");
double hourlyRate = Convert.ToDouble(Console.ReadLine());

//Do the Math

double grossPay = hoursWorked * hourlyRate;
double taxWithheld = grossPay * taxRate;
double takeHomePay = grossPay - taxWithheld;

//Print the Output

Console.WriteLine("");
Console.WriteLine("Gross pay: " + grossPay.ToString("C"));
Console.WriteLine("Tax withheld: " + taxWithheld.ToString("C"));
Console.WriteLine("Take home pay: " + takeHomePay.ToString("C"));
Console.WriteLine("");

//The Whole Trip

Console.WriteLine("=== Part 4: The Whole Trip ===");

//do the math

double tripTotal = fuelCost + pizzaCost;
double costPerPerson = tripTotal / peopleGoing;
double takeHomePayPerHour = takeHomePay / hoursWorked;
double hourToWork = costPerPerson / takeHomePayPerHour;

//print the output

Console.WriteLine("Trip total: " + tripTotal.ToString("C"));
Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));
Console.WriteLine("Take homr pay per hour: " + takeHomePayPerHour.ToString("C"));
Console.WriteLine("Hours you must work to cover your share: " + hourToWork.ToString("F2"));
