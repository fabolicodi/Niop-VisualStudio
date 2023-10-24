namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            Random d = new Random();

            Console.WriteLine("Unesi broj od kojeg zelis da se bira random broj");
            int broja = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesi broj do kojeg zelis da se bira random broj");
            int brojb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"TOTALNO random broj je {roll(broja,brojb,d)} sto posto nemoj sumnjat u nas ovo definitivno nije izbacilo i prošlom korisniku");
        }

        private static int roll( Random dice) => dice.Next();
        private static int roll(int x, Random dice) => dice.Next(x);
        private static int roll(int x, int y, Random dice) => dice.Next(x,y);
    }
}