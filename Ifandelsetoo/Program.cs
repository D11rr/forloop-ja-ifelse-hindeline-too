namespace Ifandelsetoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("üks või kaks?");
            int  i = 3;
            int o= 5;
            if (o > i)
            {
                Console.WriteLine("o on suurem kui i." +
                    " aga kas  o on võrdne 5ga?");
                if(o  == 5) 
                {
                    Console.WriteLine("yep");
                }
            }
            else
            {
                Console.WriteLine("nah");
            }

        }
    }
}
