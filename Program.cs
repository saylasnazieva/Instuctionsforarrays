// Задача 34. Задайте массив заполненный случайными положительными трехзначными числами.Напишите программу, которая покажет количество четных чисел в массиве.
// [345,897,568,234] -> 2

int EvenNumber(int[] array)
    {
        int evenNum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                evenNum = array[i];
            }
        }
        return evenNum; 
    }
 void ShowArray(int[] array)
{
    for(int i = 0;i < array.Length; i++)
       Console.Write(array[i] + " ");

    Console.WriteLine();
}
Console.Write("Input a number of evens: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of numbers is " + EvenNumber);


// Задайте одномерный массив, заполненный случайными числами . Напишите сумму элементов, стоящих на нечетной позициях.
// [3,7,23,12] -> 19 
// [-4,-6,89,6] -> 0


int[] array = {3,7,23,12};

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Enter a number:  ");
    array[i] = int.Parse(Console.ReadLine());
}
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 1)
        sum += array[i];
}
Console.WriteLine($"Number of odd {sum}");

//Задача 38. Задача массив вещестенных чисел. Напишите разницу между максимальной и минимальных элементов массива.
// [3,7,22,2,78] ->76.


int[] Main = (string[] args)
{
    int n = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[n];
    int min = int.MaxValue;
    int max = int.MinValue;
    Random random = new Random();
    int a = 0 ;
    for (int i = 0; i < array.Length; i++ )
    {
        ArrayRandom(array,a);
        a = random.Next(-50,50);
        array[i] = a;

        if(array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
}
Console.WriteLine($"Minimum value: {min}");
Console.WriteLine($"Maximum value: {max}");
int difference = int.MaxValue - int.MinValue;
Console.WriteLine($" The difference between the larges and smalles value: {differebce}");

Console.ReadLine();

double ArayRandom(int[] array, int a) 
 {
     for (int i = 0; i < array.Length; i++)
     {
     if (array[i] == a)
 {
 return true;
 }
 }
 return false;
}

