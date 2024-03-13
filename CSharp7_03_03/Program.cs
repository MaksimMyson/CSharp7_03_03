namespace CSharp7_03_03
{

    public interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }

    public class Array : ICalc
    {
        private int[] elements;

        public Array(int[] arr)
        {
            elements = arr;
        }

        public int Less(int valueToCompare)
        {
            int count = 0;
            foreach (var element in elements)
            {
                if (element < valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;
            foreach (var element in elements)
            {
                if (element > valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            int[] arr = { 3, 1, 4, 1, 5, 9, 2, 6, 5 };
            Array array = new Array(arr);

            int valueToCompare = 4;
            Console.WriteLine($"Кількість елементів масиву менших за {valueToCompare}: {array.Less(valueToCompare)}");
            Console.WriteLine($"Кількість елементів масиву більших за {valueToCompare}: {array.Greater(valueToCompare)}");
        }
    }
}
