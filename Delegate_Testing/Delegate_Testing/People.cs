using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate_Testing
{
    class People
    {
        List<string> names;

        public People()
        {
            names = new List<string>();
        }

        public string Name
        {
            get;
            set;
        }
               

        public void WriteCallTree()
        {
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
           
        }

        public void AddName(string _name)
        {
            names.Add(_name);
        }

        /*public string LastName
        {
            get;
            set;
        } 
        */
            

        
    }
}

