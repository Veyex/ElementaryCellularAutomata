using System.Threading;

namespace ElementaryCellularAutomata
{
    class Program
    {
        static void Main(string[] args)
        {
            eCA eca = new eCA();
            eca.Init();
            while (true)
            {
                eca.CalculateNextGeneration();
                eca.ProgressGenerations();
            }
            
        }
    }
}