using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SampleStack
/*
 * C# Program to Implement basic Stack operations
 */
{
    public class StackProgram
    {
        static void Main(string[] args)
        // Main program for user inputs
        {
            Stack myStack = new Stack();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nStack MENU");
                Console.WriteLine("1. Add an element");
                Console.WriteLine("2. See the Top element.");
                Console.WriteLine("3. Remove top element.");
                Console.WriteLine("4. Display stack elements.");
                Console.WriteLine("5. Total number of elements .");
                Console.WriteLine("6. Is stack empty?");
                Console.WriteLine("7. Exit");
                Console.Write("Select your choice with value 1 to 7: ");

                int choice = 0;
                if (choice > 7 || choice < 0)
                {
                    choice = 0;
                }
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.Write("Enter a number from 1 to 7: ");
                    choice = 0;
                }
                switch (choice)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("Enter an Element : ");
                        StackPush(Console.ReadLine(), myStack);
                        break;

                    case 2: Console.WriteLine("Top element is: {0}", StackPeek(myStack));
                        break;

                    case 3: Console.WriteLine("Element removed: {0}", StackPop(myStack));
                        break;

                    case 4: PrintValues(myStack, '\n');
                        break;

                    case 5: Console.WriteLine("Total Number of elements: {0}", StackCount(myStack));
                        break;

                    case 6: Console.WriteLine("\nIs stack empty?: {0}", IsStackEmpty(myStack));
                        break;

                    case 7: System.Environment.Exit(1);
                        break;
                }
                Console.WriteLine("\nEnter any key ..... ");
                Console.ReadKey();
            }
        }
        public static void PrintValues(IEnumerable myCollection, char mySeparator)
        // Display contents of Stack
        {
            foreach (Object obj in myCollection)
                Console.Write("{0}{1}", mySeparator, obj);
            Console.WriteLine();
        }
        public static void StackPush(Object element, Stack st)
        // Pushes element to Stack
        {
            st.Push(element);
        }
        public static object StackPop(Stack st)
        // Pops last element in the Stack
        {
            object obj = null;
            if (st.Count != 0)
                obj = st.Pop();
            return obj;
        }
        public static object StackPeek(Stack st)
        // Gives top element in the Stack
        {
            object obj = null;
            if (st.Count != 0)
                obj = st.Peek();
            return obj;
        }
        public static Int32 StackCount(Stack st)
        //Gives number of element(s) in the stack 
        {
            return st.Count;
        }
        public static bool IsStackEmpty(Stack st)
        // Check stack is empty or not and returns true or false
        {
            bool flag = false;
            if (st.Count == 0)
                flag = true;
            return flag;
        }

    }
}
