internal class Program
{
    private static void Main(string[] args)
    {
        int m = -20;
        int n = 50;

        int[] massiv = Enumerable.Range(m, n - m + 1).ToArray();
        Console.WriteLine("Числа массива:");
        foreach (var item in massiv)
        {
            Console.WriteLine(item);
        }
        double summ = 0;
        double chislo = 0;
        for (int i = 0; massiv.Length > i; i++)
        {
            if (massiv[i] > 0)
            {
                chislo += massiv[i];
                summ += 1;
            }
        }
        Console.WriteLine($"Среднее арифметическое = {chislo / summ}");
    }
}