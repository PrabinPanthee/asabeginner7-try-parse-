using System;
class Program
{
    static void Main()
    {
        string strnumber = "5652";
        int result = 0;
        bool isconversionSucessful = int.TryParse(strnumber, out result);
        if (isconversionSucessful)
        {
            Console.WriteLine(result);
        }
       else
        {
            Console.WriteLine("it is invalid ");
        }
    }
}