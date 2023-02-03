namespace ElementaryCellularAutomata
{
    class eCA
    {
        #region Properties & Fields
        public int length;
        public int rule;
        public int[] cellArray;
        public int[] neighbourArray;
        #endregion

        #region Methods
        public void Init()
        {
            Console.WriteLine("Enter Length:");
            length = Convert.ToInt32(Console.ReadLine());
            cellArray = new int[length];
            Console.WriteLine("Enter Rule:");
        }
        public void CalculateNextGeneration()
        {
            for (int target = 0; target < length; target++)
            {
                for (int neighbour = target - 1; neighbour <= target + 1; neighbour++)
                {

                }
            }
        }
        #endregion
    }
}