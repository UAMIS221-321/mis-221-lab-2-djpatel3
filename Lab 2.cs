const double COST_OF_SANDWICH = 4.75;
const double COST_OF_TOPPING = 0.55;
const double DISCOUNT_AMOUNT = 0.1;

int NumberofSandwiches = 0;
int NumberofToppings = 0;
double tip = 0;

Console.WriteLine("Enter number of sandwiches");
NumberofSandwichegits = int.Parse(Console.ReadLine());

Console.WriteLine("Enter number of toppings");
NumberofToppings = int.Parse(Console.ReadLine());

Console.WriteLine("Enter tip amount expressed as a decimal");
tip = double.Parse(Console.ReadLine());

double TotalSandwichCost = 0;
TotalSandwichCost = COST_OF_SANDWICH * NumberofSandwiches;
double TotalToppingCost = 0;
TotalToppingCost = COST_OF_TOPPING * NumberofToppings;

double BaseCost = 0;
BaseCost = TotalSandwichCost + TotalToppingCost;

double OrderCost = 0;
OrderCost = tip + BaseCost * (1-DISCOUNT_AMOUNT);

Console.WriteLine("Your total cost is " + OrderCost);