namespace CSharp7_03_03
{

    public interface ICalc2
    {
        int CountDistinct();
        int EqualToValue(int valueToCompare);
    }

    public class Array : ICalc2
    {
        private int[] elements;

        public Array(int[] arr)
        {
            elements = arr;
        }

        public int CountDistinct()
        {
            return elements.Distinct().Count();
        }

        public int EqualToValue(int valueToCompare)
        {
            return elements.Count(x => x == valueToCompare);
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

            
            Console.WriteLine($"Кількість унікальних значень в масиві: {array.CountDistinct()}");

            int valueToCompare = 5;
            Console.WriteLine($"Кількість елементів масиву, рівних {valueToCompare}: {array.EqualToValue(valueToCompare)}");
        }
    }
}
