// See https://aka.ms/new-console-template for more information


List<char> unSortedData = new List<char>() { 'C', 'F', 'D', 'Z', 'A', 'M', 'S', 'G'};
Console.WriteLine("Unsorted List:");
printList(unSortedData);
Console.WriteLine("After sorted: ");
selectioSort(unSortedData);


static void selectioSort(List<char> array)
{
    for (int i = 0; i < array.Count; i++)
    {
        var minIndex = i;
        for (int j = i + 1; j < array.Count; j++)
        {
            if (array[j] < array[minIndex])
            {
                minIndex = j;
            }
           
        }
        char temp = array[minIndex];
        array[minIndex] = array[i];
        array[i] = temp;

    }
    printList(array);
}

static void printList(List<char> array)
{
    foreach (var item in array)
    {
        Console.WriteLine(item);
    }
}


