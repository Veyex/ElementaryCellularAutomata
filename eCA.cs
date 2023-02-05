namespace ElementaryCellularAutomata
{
    class ECA
    {
        #region Properties & Fields
        public int length;
        public int rule = 0;
        public string neighbourValue = "";
        public string binRule = "";
        public int[] currentGeneration;
        public string[] neighbourArray;
        public string[] ruleSet = new string[] { "111", "110", "101", "100", "011", "010", "001", "000" };
        #endregion

        #region Constructors
        public ECA()
        {
            currentGeneration = new int[length];
            neighbourArray = new string[length];
        }
        #endregion

        #region Methods
        public void Init()
        {
            Console.WriteLine("Enter Length:");
            length = Convert.ToInt32(Console.ReadLine());
            currentGeneration = new int[length];
            neighbourArray = new string[length];
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
            currentGeneration[Convert.ToInt32(length /2)] = 1;
        }
        public void CalculateNeighbourArray()
        {
            for (int target = 0; target < length; target++)
            {
                string neighbourValue = "";
                for (int neighbour = target - 1; neighbour <= target + 1; neighbour++)
                {
                    if (neighbour >= 0 & neighbour < length)
                    {
                        if (currentGeneration[neighbour] == 1)
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
                neighbourArray[target] = neighbourValue;
            }
        }
        public void ProgressGenerations()
        {
            for (int target = 0; target < length; target++)
            {
                for (int i = 0; i < ruleSet.Length; i++)
                {
                    if (binRule[i] == '1')
                    {
                        if (neighbourArray[target] == ruleSet[i])
                        {
                            currentGeneration[target] = 1;
                            break;
                        }
                        else
                        {
                            currentGeneration[target] = 0;
                        }
                    }
                }
            }
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
        #endregion
    }
}