Console.WriteLine("Введите количество элементов в массиве");
int Count = Convert.ToInt32(Console.ReadLine());
int[] array = new int[Count];
Console.WriteLine("Введите числа массива");
for(int i = 0; i < array.Length; i++)
{
   array[i] = Convert.ToInt32(Console.ReadLine());
}
int[] copy = new int[array.Length];
Array.Copy(array, copy, array.Length);
Console.WriteLine(String.Join(", ", copy));