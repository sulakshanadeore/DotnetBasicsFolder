using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_FirstDAY
{
     class SecondProgram
    {


        


        static void SwapNumbers(int no1,int no2)
        {
            int temp;
            temp = no1;
            no1 = no2;
            no2 = temp;
            Console.WriteLine("The firstnumber=" + no1);
            Console.WriteLine("The secondnumber=" + no2);
        }
        static void SwapNumbersByReference(ref int no1, ref int no2)
        {
            //ref--reference--address
            int temp;
            temp = no1;
            no1 = no2;
            no2 = temp;
            Console.WriteLine("The firstnumber=" + no1);
            Console.WriteLine("The secondnumber=" + no2);
            //The values are swaped at their addresses in the memory
        }

        //Either default value or [Optional] keyword, only one of them can be specified
        static int DivideNos(int i, [Optional] int j)
        {
            return i / j;  
        
        }

        static string PassValuesByName(string fname, string mname, string lname)
        {
            //Named Parameter Example
            return fname + mname + lname;

        }



        static void Main(string[] args)
        {

           string fullname= PassValuesByName(fname: "Amitabh ", lname: "Bacchan ", mname: "HariwanshRai ");
            Console.WriteLine(fullname);

            //int ans=DivideNos(i:10);
            int ans = DivideNos(10);
            Console.WriteLine(ans);

            //Console.WriteLine("Enter first number");
            //int fno=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter second number");
            //int sno = Convert.ToInt32(Console.ReadLine());
            ////SwapNumbers(fno, sno);//Call by value--u are passing the values of the variables as parameters to the method

            //SwapNumbersByReference(ref fno, ref sno);
            //Console.WriteLine("The FIRST NUMBER =" + fno);
            //Console.WriteLine("The SECOND NUMBER =" + sno);

            Console.ReadLine();
        }
    }
}
