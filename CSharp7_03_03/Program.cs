using System.Reflection.Metadata;

namespace CSharp7_03_03
{

    public interface IOutput
    {
        void Show();
        void Show(string info);
    }

    public class Array : IOutput
    {
        private int[] elements;

        public Array(int[] arr)
        {
            elements = arr;
        }

        public void Show()
        {
            Console.WriteLine("Елементи масиву:");
            foreach (var element in elements)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            Console.WriteLine("Елементи масиву:");
            foreach (var element in elements)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("\nІнформація: " + info);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            int[] arr = { 1, 2, 3, 4, 5 };
            Array array = new Array(arr);

            array.Show();


            array.Show("Це інформаційне повідомлення про масив.");
        }
    }
}
