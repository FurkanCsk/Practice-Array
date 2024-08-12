

// 1. Define an array that will hold 10 integer values.

int[] numbers = new int[10];
Random rnd = new Random();

Console.WriteLine("------------------------------------------------------------------------");
// 2. Fill the elements of this array using a for loop and print them on the screen using a foreach loop.

for (int i = 0; i < numbers.Length; i++)
{
    // Generate random numbers between 1 and 50.
    numbers[i] = rnd.Next(1,50);
}

// Print the array using a foreach loop.
foreach (int number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("------------------------------------------------------------------------");

// 3. Add a new value to this array (as the 11th element) obtained from the user.

Console.WriteLine("Enter a number.");
int input = Convert.ToInt16(Console.ReadLine());

// Create a new array with one additional element to accommodate the user's input.
int[] numbersNew = new int[numbers.Length +1];

// Copy the original array into the new array.
for (int i = 0; i < numbers.Length;i++)
{
    numbersNew[i] = numbers[i];
}

// Add the user's input as the last element of the new array.
numbersNew[numbersNew.Length - 1] = input;

Console.WriteLine("New Array : ");

// Print the new array.
foreach (int number in numbersNew)
{
    Console.WriteLine(number);
}



Console.WriteLine("------------------------------------------------------------------------");

// 4. Print this array on the screen in descending order.

// 4. Sort the array in descending order
for (int i = 0; i < numbersNew.Length - 1 ; i++)
{
    for (int j = i + 1; j<numbersNew.Length; j++)
    {
        // Swap elements if the current element is less than the next element.
        if (numbersNew[i] > numbersNew[j])
        {
            int temp = numbersNew[j];
            numbersNew[j] = numbersNew[i];
            numbersNew[i] = temp;
        }
    }
}

// Print the sorted array in descending order.
foreach (int number in numbersNew)
{
    Console.WriteLine(number);
}

// We can use Array.Sort() as well to sort the array in ascending order,
// and then use Array.Reverse() to sort it in descending order.