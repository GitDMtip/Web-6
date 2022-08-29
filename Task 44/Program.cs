Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int[] fibonacci = new int[N];
int a = 0;
int b = 1;
fibonacci[0] = a;
fibonacci[1] = b;
for(int i = 2; i < N ; i++)
{
    int c = a + b;
    fibonacci[i] = c;
    a = b;
    b = c;
}
foreach(int cur in fibonacci)
{
    Console.WriteLine(cur);
}