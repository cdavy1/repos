using System;

namespace Delegate_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            People Person = new People();
                       
            Person.AddName("First Person");
                for (int i = 0; i < 3; i++)
                {
                Console.WriteLine("Enter Name");
                string NewName = Console.ReadLine();
                Person.AddName(NewName);
                }

            Person.WriteCallTree();
            Console.ReadLine();
            


        }
    }
}
