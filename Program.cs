// Add code that uses a conditional operator

int salesAmount = 1001;
int discount = salesAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");
//Use the conditional operator inline
int salesAmt = 1001;
Console.WriteLine($"Discount: {(salesAmt > 1000 ? 100 : 50)}");



/////Code challenge: write code to display the result of a coin flip//////
/*
1 Use the Random class to generate a value.
Consider the range of numbers that is required.

2 Based on the value generated, use the conditional operator to display either heads or tails.
There should be a 50% chance that the result is either heads or tails.

3 Your code should be easy to read, but with as few lines as possible.
You should be able to accomplish the desired result in three lines of code.
*/

Random coins = new Random();
int flipValue = coins.Next(1, 10);
Console.WriteLine($"Coin is: {(flipValue >= 5 ? "head" : "tails")}");




/////Complete a challenge activity using Boolean expressions//////
//Initialize permission and level values
string permission = "Manager|Admin";
int level = 55;
//Your application will be using a combination of permission and level to apply/evaluate the business rules in this challenge scenario. The full list of conditions for business rules is specified in the next step. Your completed solution must use permission and level.

/* Important
You will need to use the Contains() helper method to determine whether the value assigned to the permission string contains one of the permission values specified by the "business rules". For example, the expression permission.Contains("Admin") will return true when using the initial data values specified in the code above.
*/

//If the user is an Admin with a level greater than 55, output the message:
//Welcome, Super Admin user.
//If the user is an Admin with a level less than or equal to 55, output the message:
//Welcome, Admin user.
if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}

//If the user is a Manager with a level 20 or greater, output the message:
//Contact an Admin for access.
//If the user is a Manager with a level less than 20, output the message:
//You do not have sufficient privileges.
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
//If the user is not an Admin or a Manager, output the message:
//You do not have sufficient privileges.
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}