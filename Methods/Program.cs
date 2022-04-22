/*
 Let’s make a program that uses methods to accomplish a task. Let’s take an array and
reverse the contents of it. For example, if you have 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, it would
become 10, 9, 8, 7, 6, 5, 4, 3, 2, 1.
To accomplish this, you’ll create three methods: one to create the array, one to reverse the
array, and one to print the array at the end.
Your Main method will look something like this:
static void Main(string[] args) {
int[] numbers = GenerateNumbers();
Reverse(numbers);
PrintNumbers(numbers);
}
The GenerateNumbersmethod should return an array of 10 numbers. (For bonus points,
change the method to allow the desired length to be passed in, instead of just always
being 10.)
The PrintNumbersmethod should use a foror foreachloop to print out each item in the
array. The Reversemethod will be the hardest. Give it a try and see what you can make
happen. If you get
stuck, here’s a couple of hints:
Hint #1:To swap two values, you will need to place the value of one variable in a temporary
location to make the swap:
// Swapping a and b.
int a = 3;
int b = 5;
int temp = a;
a = b;
b = temp;
Hint #2:Getting the right indices to swap can be a challenge. Use a forloop, starting at 0
and going up to the length of the array / 2. The number you use in the forloop will be the
index of the first number to swap, and the other one will be the length of the array minus
the index minus 1. This is to account for the fact that the array is 0-based. So basically,
you’ll be swapping array[index]with array[arrayLength – index – 1].
*/

static int[] GenerateNumbers(int size)
{
    Random random = new Random();
    int[] numbers = new int[size];
    for (int i = 0; i < size; i++)
    {
        numbers[i] = random.Next(0,100);
    }
    return numbers;
}

static int[] Reverse(int[] numbers)
{
    int temp;
    for (int i = 0; i < numbers.Length/2; i++)
    {
        temp = numbers[i];
        numbers[i] = numbers[numbers.Length - 1 - i];
        numbers[numbers.Length - 1 - i] = temp;
    }
    return numbers;
}

static void PrintNumbers(int[] numbers)
{
    foreach(int number in numbers)
    {
        Console.WriteLine(number);
    }
}

//Main
    int[] numbers = GenerateNumbers(10);
    Reverse(numbers);
    PrintNumbers(numbers);


