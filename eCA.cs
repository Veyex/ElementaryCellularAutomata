namespace ElementaryCellularAutomata
{
    class ECA
    {
        #region Properties & Fields
        public int length;
        public string[] ruleSet = new string[] {"111", "110", "101", "100", "011", "010", "001", "000"};
        public int rule = 0;
        public string binRule = "";
        public int[] currentGeneration;
        public int[] nextGeneration;
        #endregion

        #region Constructors
        public ECA()
        {
            currentGeneration = new int[length];
            nextGeneration = new int[length];
        }
        #endregion

        #region Methods
        public void Init()
        {
            Console.WriteLine("Enter Length:");
            length = Convert.ToInt32(Console.ReadLine());
            currentGeneration = new int[length];
            nextGeneration = new int[length];
            Console.WriteLine("Enter Rule:");
            rule = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 7; i++)
            {
                int placehold = (int)(256 / Math.Pow(2, i + 1));
                if ((rule - placehold) >= 0)
                {
                    binRule += "1";
                    rule -= placehold;
                }
                else
                {
                    binRule += "0";
                }
            }
            Console.WriteLine(binRule);
            currentGeneration[3] = 1;
        }
        public void CalculateNextGeneration()
        {
            for (int target = 0; target < length; target++)
            {
                string neighbourValue = "";
                for (int neighbour = target - 1; neighbour <= target + 1; neighbour++)
                {
                    if (neighbour >= 0 & neighbour < length)
                    {
                        if (currentGeneration[neighbour] != 0)
                        {
                            neighbourValue += '1';
                        }
                        else
                        {
                            neighbourValue += '0';
                        }
                    }
                    else
                    {
                        neighbourValue += '0';
                    }
                }
                for (int i = 0; i < binRule.Length; i++)
                {
                    if (binRule[i] == '1')
                    {
                        if (neighbourValue == ruleSet[i])
                        {
                            nextGeneration[target] = 1;
                        }
                        else
                        {
                            nextGeneration[target] = 0;
                        }
                    }
                }
            }
            currentGeneration = nextGeneration;
        }
        public void PrintCurrentGeneration()
        {
            for (int i = 0; i < currentGeneration.Length; i++)
            {
                if (currentGeneration[i] == 1)
                {
                    Console.Write("\u2588");
                }
                else
                {
                    Console.Write("\u00A0");
                }
            }
            Console.WriteLine();
        }
        public void PrintNextGeneration()
        {
            for (int i = 0; i < nextGeneration.Length; i++)
            {
                Console.WriteLine(nextGeneration[i]);
            }
            Console.WriteLine();
        }
        #endregion
    }
}