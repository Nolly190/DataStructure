namespace AppZoneTest
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var result = MissingArrayNumber.GetMissingNumber(new int [7] {9,10,16,11,14,12,15});
            System.Console.WriteLine(result.ToString());
        }

    }
}
