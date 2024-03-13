namespace CSharp7_03_03
{

    public interface IMath
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int valueToSearch);
    }

    public class Array : IMath
    {
        private int[] elements;

        public Array(int[] arr)
        {
            elements = arr;
        }

        public int Max()
        {
            int max = elements[0];
            foreach (var element in elements)
            {
                if (element > max)
                {
                    max = element;
                }
            }
            return max;
        }

        public int Min()
        {
            int min = elements[0];
            foreach (var element in elements)
            {
                if (element < min)
                {
                    min = element;
                }
            }
            return min;
        }

        public float Avg()
        {
            float sum = 0;
            foreach (var element in elements)
            {
                sum += element;
            }
            return sum / elements.Length;
        }

        public bool Search(int valueToSearch)
        {
            foreach (var element in elements)
            {
                if (element == valueToSearch)
                {
                    return true;
                }
            }
            return false;
        }
    }


        public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            int[] arr = { 1, 2, 3, 4, 5 };
            Array array = new Array(arr);

            
            Console.WriteLine("Максимум: " + array.Max());
            Console.WriteLine("Мінімум: " + array.Min());
            Console.WriteLine("Середнє: " + array.Avg());
            Console.WriteLine("Пошук 3: " + array.Search(3));
            Console.WriteLine("Пошук 10: " + array.Search(10));
        }
    }
}
