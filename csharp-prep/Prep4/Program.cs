using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> store = new List<int>();
        int last = 1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        while (last != 0) {
            Console.Write("Enter number: ");
            last = int.Parse(Console.ReadLine());
            if (last != 0){
                store.Add(last);
            }
            
        }
        int sum = 0;
        foreach (int num in store) {
            sum += num;
        }
        float average = ((float)sum) / store.Count;
        int max = 0;
        foreach (int num in store) {
            if (num > max) {
                max = num;
            }
        }
        int small = 1000000000;
        foreach (int num in store) {
            if (num > 0 && num < small) {
                small = num;
            }
        }
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {small}");
    }
}