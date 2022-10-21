// See https://aka.ms/new-console-template for more information

namespace CollectionsApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> st = new Stack<string>();
            st.Push("A");
            st.Push("R");
            st.Push("I");
            st.Push("M");
            Console.WriteLine("Current stack: ");
            foreach (string c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            st.Push("T");
            st.Push("Q");
            Console.WriteLine("The next poppable value in stack: {0}", st.Peek());
            Console.WriteLine("Current stack: ");
            foreach (string c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Removing values");
            st.Pop();
            st.Pop();
            st.Pop();
            Console.WriteLine("Current stack: ");
            foreach (string c in st)
            {
                Console.Write(c + " ");
            }
            Console.ReadKey(true);
        }
    }
}
