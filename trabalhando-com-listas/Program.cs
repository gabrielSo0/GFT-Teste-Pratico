namespace trabalhando_com_listas.src
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();

            List<Person> people = new List<Person>();

            people.Add(new Person("João", 15));
            people.Add(new Person("Leandro", 21));
            people.Add(new Person("Paulo", 17));
            people.Add(new Person("Jessica", 18));

            int oldest = people[0].Age;

            foreach (var person in people)
            {
                if(person.Age > oldest)
                {
                    oldest = person.Age;
                }

                System.Console.WriteLine("Name: " + person.Name); 
                System.Console.WriteLine("Age: " + person.Age);
            }

            System.Console.WriteLine($"The oldest: {oldest}");

            System.Console.WriteLine($"Before remove people less than 18 years old: " + people.Count);

            for (int i = 0; i < people.Count; i++)
            {
                if(people[i].Age < 18)
                {
                    people.RemoveAt(i);
                }
            }

            System.Console.WriteLine($"Before remove people less than 18 years old: " + people.Count);

            var personQuery = 
                from person in people
                where person.Name == "Jessica"
                select person;

            foreach (var person in personQuery)
            {
                System.Console.WriteLine(person.Name);
            }
        }
    }
}