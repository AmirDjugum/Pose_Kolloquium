/*--------------------------------------------------------------
*				HTBLA-Leonding / Class: 5ABIF
*--------------------------------------------------------------
*              HA
*--------------------------------------------------------------
* Description: ArrayStatistic
*--------------------------------------------------------------
*/


using System;

Console.WriteLine("Array Statistic");
Console.WriteLine("********************");

Console.Wriet("Please enter the count of numbers: ");

int countNumbers = int.Parse(Console.ReadLine());
int[] numbers = new int[countNumbers];

for(int i = 0; i < countNumbers; i++)
{
	Console.Write($"Please enter number {i + 1}: ");
	numbers[i] = int.Parse(Console.ReadLine());
}

Console.Write("Please enter lower bound: ");
int minBound = int.Parse(Console.ReadLine());

Console.Write("Please enter upper bound: ");
int maxBound = int.Parse(Console.ReadLine());

int countInRange = 0;

for(int i = 0; i < countNumbers; i++)
{
	if(numbers[i] >= minBound && numbers[i] <= maxBound)
	{
		countInRange++;
	}
}

if(countInRange > 0)
{
	Console.WriteLine($"{countInRange} numbers are in the range of [{minBound}..{maxBound}]");
}
else
{
	Console.WriteLine($"No number is in the range of [{minBound}..{maxBound}]");
}