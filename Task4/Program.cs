using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Store st = new Store();

            int index = Int32.Parse(Console.ReadLine());
            st.PrintByIndex(index);

            string title = Console.ReadLine();
            st.PrintByTitle(title);
        }
    }
}
