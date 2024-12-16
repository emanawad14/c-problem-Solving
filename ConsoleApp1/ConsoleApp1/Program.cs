#region c# Problem Solving 
//-Write C# program that converts a string to an integer,
//but the string contains non-numeric characters. And mention what will happen
//========================================================================

/*
using System.Linq.Expressions;

Console.WriteLine("Enter your string");
string input = Console.ReadLine();

try
{
    int number = int.Parse(input);
    Console.WriteLine("converted number" + number);

}
catch (Exception ex)
{
    Console.WriteLine("Error: The string contains non-numeric characters and cannot be converted to an integer.");
}

*/

//=============================================================================















//Write C# program that take two string variables
//and print them as one variable

//========================================================

/*
Console.WriteLine("Enter the first string");
string firstString = Console.ReadLine();

Console.WriteLine("Enter the second string");
string secondString = Console.ReadLine();

string fullName = firstString + secondString;
Console.Write($"fullName" + fullName);
*/

//========================================================
/*
Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a
variable then display the
result.
Note :
a.that below 10 degrees is "Just Cold"
b. above 30 degrees is "Just Hot"
c. anything else is "Just Good "
*/

//===========================================================

Console.WriteLine("Enter the temperature in degrees:");
int temperature  =int .Parse(Console.ReadLine());

string result = temperature < 10 ? " just cold" : (temperature > 30 ? "just Hot" : "just Good");
Console.WriteLine( "The Temperature is \n" +   result);


#endregion
