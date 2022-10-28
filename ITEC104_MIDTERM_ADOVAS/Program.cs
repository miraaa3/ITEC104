internal class Program
{
    private static void Main(string[] args)
    {
        Stack<int> st = new Stack<int> (10);
       

        Console.WriteLine("Stack MENU (size--10)");
        Console.WriteLine("\t 1. Add an Element");
        Console.WriteLine("\t 2. See Top Element");
        Console.WriteLine("\t 3. Remove Top Element");
        Console.WriteLine("\t 4. Display stack Element");
        Console.WriteLine("\t 5. Exit");

        while (true)
        {
            Console.Write("\nSelect your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter an Element: ");
                    int Element = Convert.ToInt32(Console.ReadLine());
                    if (st.Count != 10)
                    {
                        st.Push(Element);
                        Console.WriteLine("Item Pushed Successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Stacks is already complete.");
                    }
                    break;
                    
                case 2:
                Console.WriteLine("Top Element is: {0} ", st.Peek());
                break;

                case 3:
                st.Pop();
                Console.WriteLine("Top Element was removed successfully!");
                break;

                case 4:
                foreach( var item in st)
                {
                    Console.WriteLine(" " + item);
                }
                break;

                case 5: 
                Environment.Exit(0);
                break;

                default:
                Console.WriteLine("Creating Stack is unsuccessful!");
                break;
            }
        }
    }
}