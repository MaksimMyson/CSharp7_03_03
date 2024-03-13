namespace CSharp7_03_03
{

    public interface IOutput2
    {
        void ShowEven();
        void ShowOdd();
    }

    public class Array : IOutput2
    {
        private int[] elements;

        public Array(int[] arr)
        {
            elements = arr;
        }

        public void ShowEven()
        {
            Console.WriteLine("Парні елементи масиву:");
            foreach (var element in elements)
            {
                if (element % 2 == 0)
                {
                    Console.Write(element + " ");
                }
            }
            Console.WriteLine();
        }

        public void ShowOdd()
        {
            Console.WriteLine("Непарні елементи масиву:");
            foreach (var element in elements)
            {
                if (element % 2 != 0)
                {
                    Console.Write(element + " ");
                }
            }
            Console.WriteLine();
        }

      
        public void Display()
        {
            Console.WriteLine("Весь масив:");
            foreach (var element in elements)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            int[] arr = { 3, 1, 4, 1, 5, 9, 2, 6, 5 };
            Array array = new Array(arr);

            
            array.Display();

            
            array.ShowEven();
            array.ShowOdd();
        }
    }
}
