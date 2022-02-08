using System.Globalization;
namespace calcular_dias
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data1 = "Helena 28 03 1989".Split(" ");
            string[] data2 = "Romeu 21 04 1950".Split(" ");
            string[] data3 = "Raquel 14 01 2000".Split(" ");
            string[] data4 = "Enzo 25 12 2021".Split(" ");

            double firstPerson = CalculateTheDaysSinceBirthDay(data1);
            double secondPerson = CalculateTheDaysSinceBirthDay(data2);
            double tirdPerson = CalculateTheDaysSinceBirthDay(data3);
            double fourthPerson = CalculateTheDaysSinceBirthDay(data4);

            System.Console.WriteLine($"Helena lived until {firstPerson.ToString("F1")} days");
            System.Console.WriteLine($"Romeu lived until {secondPerson.ToString("F1")} days");
            System.Console.WriteLine($"Raquel lived until {tirdPerson.ToString("F1")} days");
            System.Console.WriteLine($"Enzo lived until {fourthPerson.ToString("F1")} days");

        }

        static double CalculateTheDaysSinceBirthDay(string[] data)
        {
            string data1 = $"{data[1]}/{data[2]}/{data[3]}";

            DateTime dataConverted = Convert.ToDateTime(data1);

            DateTime now = DateTime.UtcNow;

            double totalDays = (now - dataConverted).TotalDays;

            return totalDays;
        }
    }
}