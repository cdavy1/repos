using System;
using System.Collections.Generic;
using System.Collections;
using PlayWithEquality;

namespace PlayWithEquality
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Stack<string> myStack = new Stack<string>();

            myStack.Push("Barack");
            myStack.Push("barack obama0");
            myStack.Push("barack obama1");
            myStack.Push("barack obama2");
            myStack.Push("barack obama3");
            myStack.Push("barack obama4");
            myStack.Push("barack obama5");

            foreach (string item in myStack)

            Console.WriteLine(item);
            Console.WriteLine(myStack.Count);
            Console.WriteLine("press any key to continue..");
            Console.ReadLine();

            //======================================================
            //Console.ReadLine();
            // NonBlankStringList myList = new NonBlankStringList();
            //
            //myList.Add("Barack Obama");
            //myList[0] = "Changed index 0 value from Barack to this..";
            //myList.Add("Item added at Index 1");
            //myList.Insert(2, "Item added at index of 2");
            //
            //foreach (string item in myList)
            //Console.WriteLine(item);
            //Console.WriteLine(myList.Count);
            //Console.WriteLine("Press any key to continue..");
            //Console.ReadLine();

            //===========================================================
            //      var presidents = new List<string> {
            //      "Barack Obama",
            //      "George Bush Jr.",
            //      "Bill Clinton",
            //      "George Bush Sr.",
            //      "Ronald Regan",
            //      "Jimmy Carter"
            //
            //  };

            //  Console.WriteLine("Before capacity is: " + presidents.Capacity);
            //  Console.WriteLine("Before count is: " + presidents.Count);
            //  presidents.Add("Gerald Ford");
            //  Console.WriteLine("After capacity is: " + presidents.Capacity);
            //  Console.WriteLine("After count is: " + presidents.Count);

            //  foreach (string president in presidents)

            //  Console.WriteLine(president);
            //  Console.WriteLine("Press any key to continue..");
            //  Console.ReadLine();

            //===============================================================
            //string[] arr1 = { "apple", "pineapple", "orange" };
            //string[] arr2 = { "apple", "pineapple", "orange" };
            //
            //var arrayEq = (IStructuralEquatable)arr1;
            //bool structEqual = arrayEq.Equals(arr2, StringComparer.OrdinalIgnoreCase);
            //Console.WriteLine(structEqual);
            //Console.ReadLine();
            //==================

            //var names = new HashSet<string>(StringComparer.CurrentCultureIgnoreCase);
            //names.Add("apple");
            //names.Add("pear");
            //names.Add("Pineapple");
            //names.Add("Apple");

            //foreach (string name in names)
            //    Console.WriteLine(name);
            //Console.ReadLine();

            //Location Loc1 = new Location();
            //Location Loc2 = new Location();

            //Loc1.strName = "Home";
            //Loc1.strMaterial = "Brick";
            //Loc2.strName = "Home";
            //Loc2.strMaterial = "Wood";

            //Console.WriteLine("Object Equals Result: " + Loc1.Equals(Loc2));
            //bool strOperator = Loc1 == Loc2;
            //Console.WriteLine("Operator == Result: " + strOperator);

            //Console.ReadLine();

        }
    }
}
