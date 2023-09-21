namespace TextToConsoleToText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä asiakkaiden lukumäärä: ");
            int numberOfCustomers = int.Parse(Console.ReadLine());

            // Kerää ja kirjoita asiakastiedot tekstitiedostoon.
            using (StreamWriter writer = new StreamWriter("customer_info.txt"))
            {
                for (int i = 1; i <= numberOfCustomers; i++)
                {
                    Console.WriteLine("Data for customer #{0}", i);
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("E-mail: ");
                    string email = Console.ReadLine();
                    Console.Write("Phone number: ");
                    string phoneNumber = Console.ReadLine();

                    // Asiakastietojen kirjoittaminen tiedostoon
                    writer.WriteLine("Data for customer #{0}", i);
                    writer.WriteLine("Name: {0}", name);
                    writer.WriteLine("E-mail: {0}", email);
                    writer.WriteLine("Phone number: {0}", phoneNumber);
                }
            }

            Console.WriteLine("Customer information has been saved to the file.");


        }
    }
}