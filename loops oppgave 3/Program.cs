namespace loops_oppgave_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool condition = true;
            int i = 0;
            while (condition)
            {
                if(i < 10)
                {
                    Console.WriteLine($"runde nr {i}");
                    i++;
                }
                else
                {
                    condition = false;
                }
            }
        }
    }
}
