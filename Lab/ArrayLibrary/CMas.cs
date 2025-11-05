namespace Lab
{
    public class CMas
    {
        private int[] mas;

        public int GetLengthMas
        {
            get { return mas.Length; }
        }

        public int this[int index]
        {
            get { return mas[index]; }
            set { mas[index] = value; }
        }

        public CMas(int length)
        {
            mas = new int[length];
        }

        public CMas(int[] masValue)
        {
            mas = new int[masValue.Length];
            Array.Copy(masValue, mas, masValue.Length);
        }

        public static int countPositiveNumbers(params CMas[] mass)
        {
            int totalCount = 0;
            foreach (var cMas in mass)
            {
                foreach (int num in cMas.mas)
                {
                    if (num > 0)
                    {
                        totalCount++;
                    }
                }
            }
            return totalCount;
        }
    }
}
