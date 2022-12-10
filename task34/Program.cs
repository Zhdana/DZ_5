// // Задайте массив заполненный случайными положительнымы трезначными числами
// Напишите программу, которая покажет количество четных чисел в массиве
int[] array = new int[10];
Random random = new Random();
for( int i=0; i<array.Length; i++)
{
   array[i] = random.Next(100,1000); 
}
Console.WriteLine(string.Join(",", array));

Console.WriteLine(Count(array));
 int Count(int[] array)
 {
    int count=0;
    for( int i=0; i<array.Length; i++)
    if (array[i]%2==0)
        count=count+1;
    return count;
 }

