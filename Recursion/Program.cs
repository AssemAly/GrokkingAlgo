// See https://aka.ms/new-console-template for more information
/*
 * Function call itesel 
 * we have two imporatant parts 
 * 1) Recusive Case -> which function call itself 
 * 2) Base Case -> stop poit which say we all done 
 * Base case very important to prevent recusion from going to infite loop
 * It save in memery as stack
 * Using stack has cost, saving all info can take alot of memory 
 * if stack is too tall it may consume alot of memory space in this case we have two options
 * 1) Rewrite code using loop instead
 * 2) Use advanced recusrion called tail recusion, but not supported by all languages
 */
Console.Write("Enter number to get it's factorial: ");
int number  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Factorial of {0}, is {1}", number, factorial(number));

static int factorial(int number)
{
    if (number <= 1)
    {
        return 1; //Base case
    }
    else
    {
        return number * factorial(number - 1); // Recusive Case
    }
}