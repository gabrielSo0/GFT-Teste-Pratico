namespace cinco_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            bool isEqual = false;

            System.Console.Write("Por favor digite 5 números: ");
            numbers[0] = int.Parse(Console.ReadLine());

            int less = numbers[0];
            int greater = numbers[0];

            for(int i = 1; i < numbers.Length; i++)
            {
                System.Console.Write("Por favor digite 5 números: ");
                numbers[i] = int.Parse(Console.ReadLine());

                if(numbers[i] > greater)
                {
                    greater = numbers[i];
                }
                else if(numbers[i] < less)
                {
                    less = numbers[i];
                }
            }

            for(int i = 0; i < numbers.Length - 1; i++)
            {
                if(numbers[i] == numbers[i + 1])
                {
                    isEqual = true;
                }
                else
                {
                    isEqual = false;
                    break;
                }
            }

            if(isEqual)
            {
                System.Console.WriteLine("The five numbers are equals.");
            }
            else
            {
                int avg = (numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4]) / 5;

                System.Console.WriteLine("The Greater number is: " + greater);
                System.Console.WriteLine("The smaller number is: " + less);
                System.Console.WriteLine("The average is: " + avg);
            }


        }
    }
}