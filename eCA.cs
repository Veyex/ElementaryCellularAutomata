namespace ElementaryCellularAutomata
{
    class eCA
    {
        #region Properties & Fields
        public int length;
        public string? rule;
        public int[]? currentGeneration;
        public int[]? nextGeneration;
        #endregion

        #region Methods
        public void Init()
        {
            Console.WriteLine("Enter Length:");
            length = Convert.ToInt32(Console.ReadLine());
            currentGeneration = new int[length];
            nextGeneration = new int[length];
            Console.WriteLine("Enter Rule:");
            rule = Console.ReadLine();
            currentGeneration[5] = 1;
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
                        neighbourValue += Convert.ToString(currentGeneration[neighbour]);
                    }
                    else
                    {
                        neighbourValue += "0";
                    }
                }
                if (neighbourValue == rule)
                {
                    nextGeneration[target] = 1;
                }
                else
                {
                    nextGeneration[target] = 0;
                }
            }
        }
        public void ProgressGenerations()
        {
            currentGeneration = nextGeneration;
        }
        #endregion
    }
}