// // Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Введите длину массива");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
Console.WriteLine("Введите начало диапазона");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите конец диапазона");
int B = Convert.ToInt32(Console.ReadLine());
Random random = new Random();
for( int i=0; i<length; i++)
{
   array[i] = random.Next(A, B+1); 
}
Console.WriteLine(string.Join(",", array));
Console.WriteLine(Sum(array));
int Sum(int[] array)
{
    int sum=0;
    for( int i=0; i<array.Length; i++)
    if (i%2==1)
        sum= sum+array[i];
    return sum;
}