// // задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива


Console.WriteLine("Введите длину массива");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = new double[length];

Random random = new Random();
for( int i=0; i<length; i++)
{
   array[i] = Convert.ToDouble(Console.ReadLine()); 
}

Console.WriteLine(Diference(array));
double Diference(double[] array)
{
    
    double max=array[0];
    double min=array[0];
    double dif = 0;
    for(int i=0; i<array.Length; i++)
    { if (array[i]>max)
        max = array[i];
      if (array[i]<min)
        min = array[i];   
    }
    dif = max - min;
    return dif;
}
