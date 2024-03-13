namespace CSharp7_03_03
{
    public interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }

    public class Array : ISort
    {
        private int[] elements;

        public Array(int[] arr)
        {
            elements = arr;
        }

        public void SortAsc()
        {
            Array.Sort(elements);
        }

        private static void Sort(int[] elements)
        {
            throw new NotImplementedException();
        }

        public void SortDesc()
        {
            Array.Sort(elements);
            Array.Reverse(elements);
        }

        private static void Reverse(int[] elements)
        {
            throw new NotImplementedException();
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }

       
        public void Display()
        {
            foreach (var element in elements)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }

    class Program
    { 
      

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            int[] arr = { 3, 1, 4, 1, 5, 9, 2, 6, 5 };
            Array array = new Array(arr);

            Console.WriteLine("Початковий масив:");
            array.Display();

            
            array.SortAsc();
            Console.WriteLine("Масив після сортування за зростанням:");
            array.Display();

            
            array.SortDesc();
            Console.WriteLine("Масив після сортування за спаданням:");
            array.Display();

           
            array.SortByParam(true); 
            Console.WriteLine("Масив після сортування за параметром (за зростанням):");
            array.Display();

            array.SortByParam(false); 
            Console.WriteLine("Масив після сортування за параметром (за спаданням):");
            array.Display();
        }
    }
}