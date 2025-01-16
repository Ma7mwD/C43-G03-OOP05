namespace AssignmentOOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var intRange = new Range<int>(10, 20);
                Console.WriteLine("Integer Range: 10 to 20");
                Console.WriteLine($"Is 15 in range? {intRange.IsInRange(15)}");
                Console.WriteLine($"Is 25 in range? {intRange.IsInRange(25)}");
                Console.WriteLine($"Length of range: {intRange.Length()}");

                var doubleRange = new Range<double>(5.5, 10.5);
                Console.WriteLine("\nDouble Range: 5.5 to 10.5");
                Console.WriteLine($"Is 7.5 in range? {doubleRange.IsInRange(7.5)}");
                Console.WriteLine($"Is 11.5 in range? {doubleRange.IsInRange(11.5)}");
                Console.WriteLine($"Length of range: {doubleRange.Length()}");

                var decimalRange = new Range<decimal>(100.25m, 200.75m);
                Console.WriteLine("\nDecimal Range: 100.25 to 200.75");
                Console.WriteLine($"Is 150.50 in range? {decimalRange.IsInRange(150.50m)}");
                Console.WriteLine($"Is 99.99 in range? {decimalRange.IsInRange(99.99m)}");
                Console.WriteLine($"Length of range: {decimalRange.Length()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
