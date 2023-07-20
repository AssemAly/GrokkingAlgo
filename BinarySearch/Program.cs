// See https://aka.ms/new-console-template for more information

/**
 - list must be sorted
 - Start from middle
 - Check in number > middle so skip first half
 - Do the same git the middle for second half and so on
 - repeat till you get the number
 * **/


int[] numbers = new int[100];

for (int i = 0; i < numbers.Length; i++)    
    numbers[i] = i + 1;

Console.Write("Enter Number to Search: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(binarySearch(numbers, number));

int binarySearch(int[] numbers, int searchNumber)
{
    int low = 0;
    int high = numbers.Length - 1;
    while (low <= high)
    {
        int mid = (low + high) / 2;
        int guess = numbers[mid];
        if (guess == searchNumber)
        {
            return mid;
        }
        else if (guess > searchNumber)
        {
            high = mid - 1;
        }
        else
        {
            low = mid + 1;
        }
    }
    return 0;
}