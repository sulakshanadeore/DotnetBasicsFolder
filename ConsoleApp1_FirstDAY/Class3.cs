using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_FirstDAY
{
     class Class3
    {
        static void Main(string[] args)
        {
            //object datatype is a class , reference type
            object obj;
            //int is struct so a value type
            //every datatype inherits from object, Object is parent of all data types
            float i=100.333f;

            obj = i;//When we put a value type inside reference type, and reference is bigger and if it is a object type, it can hold any value-- it is called Boxing.
            Console.WriteLine("Type of object as obj is holding i= " + obj.GetType());
            Console.WriteLine("Type of i=" + i.GetType());

            Console.WriteLine("--------------------");
            string s;
            s = i.ToString();
            Console.WriteLine("Type of s= " + s.GetType());
            Console.WriteLine("Type of i=" + i.GetType());
            Console.ReadLine();
        }

    }
}
