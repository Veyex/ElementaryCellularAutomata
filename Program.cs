﻿using System.Threading;

namespace ElementaryCellularAutomata
{
    class Program
    {
        static void Main()
        {
            ECA eca = new();
            eca.Init();
            while (true)
            {
                eca.PrintCurrentGeneration();
                eca.CalculateNextGeneration();
                //eca.PrintNextGeneration();
                Thread.Sleep(1000);
            }
        }
    }
}