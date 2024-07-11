namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your ID: ");
            string Id = Console.ReadLine();

            
            Console.Write("Enter your name: ");
            string Name = Console.ReadLine();

            bool Number = false;
            int age;
            do
            {
                Console.Write("Enter your Age: ");
                string Age = Console.ReadLine();
                Number = int.TryParse(Age, out age);
            } while (Number == false);

            Console.WriteLine(Id);
            Console.WriteLine(Name);
            Console.WriteLine(age);
        }
    }
}
