using static CodeHOmeWork_3_3.Calculator;

namespace CodeHOmeWork_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int Sum(int x, int y)
            {
                return x + y;
            }

            List<(string, int)> contacts = new List<(string, int)>
            {
                ("Ivan", 0933871242),
                ("Denis", 0957296124),
                ("Kostya", 0996216283),
                ("Sasha", 0961205284),
                ("Lera", 0993174863),
                ("Vasya", 0927195337),
                ("Nazar", 0974196274),
                ("Tamara", 0935257825),
            };

            object result = contacts.Where(x => x.Item1.EndsWith('a'))
                .OrderBy(x => x.Item2)
                .Distinct()
                .Take(2)
                .Select(x => x.Item1)
                .FirstOrDefault()
                .ToString();

            Console.WriteLine(result);

            Calculator calculate = new Calculator();

            calculate.SumEvent += Sum;
            calculate.SumEvent += Sum;

            calculate.Calculate();

            Console.WriteLine();
        }
    }
}