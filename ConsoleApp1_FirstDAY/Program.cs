using System;


namespace ConsoleApp1_FirstDAY
{
     class Program1
    {
       static string name;
        static void Main(string[] args)//Calling
        {

            Program1.AcceptName();//Main is calling AcceptName(Called method)
            DisplayName();//Display is the called method

            string CaseChanged;
            int strlen;
            CalculateLengthOfStringAndConvertToUpperCase(name, out strlen, out CaseChanged);

            Console.WriteLine("The length of given string=" + strlen);
            Console.WriteLine("The upper case of given string= " + CaseChanged);

            Console.WriteLine("Enter your first number");
            int firstNo=Convert.ToInt32(Console.ReadLine());//first no and second no are variables
            Console.WriteLine("Enter your second number");
            int secondNo = Convert.ToInt32(Console.ReadLine());
            //power and remainder of division
            powerOfNumber(firstNo, secondNo);
            RemainderOfDiv(firstNo, secondNo);

            //double PowerAns;
            //int RemAns;

            double pa;
            int ra;
            PowerAndRemainder(firstNo, secondNo, out pa, out ra);
            Console.WriteLine(pa);
            Console.WriteLine(ra);

            




            //When to use output parameters? When the method is  having one or  multiple values as output calculated.

            //Ctrl+K+C----> Comment
            //Ctrl+ K +U-----> Uncomment
            //AddNumbers(firstNo, secondNo);//In this line firstno and secondno are called parameters
            //int multiplicationAnswer = MultiplyNos(firstNo, secondNo);
            //Console.WriteLine($"The  multiplication of {firstNo} * {secondNo}={multiplicationAnswer}");
            Console.ReadLine();
        }


        static void CalculateLengthOfStringAndConvertToUpperCase(string str,out int len,out string uCase)
        {
            len = str.Length;
            uCase=str.ToUpper();
        
        }

        static void PowerAndRemainder(int i, int j,out double PowerAns,out int RemAns) {
             PowerAns = Math.Pow(i, j);
             RemAns = i % j;


        }

        static void powerOfNumber(int number, int p)
        { 
        double PowerAns=Math.Pow(number, p);
            Console.WriteLine($"The power value of {number} to  the {p} = {PowerAns}");
        }
        static void RemainderOfDiv(int i, int j) 
        {
            int RemAns = i % j;
            Console.WriteLine($"The remainder of {i} divided by {j}= {RemAns}");

        }

        static int MultiplyNos(int i,int j)
        {
            //variable declared in  a method is a local variable(ans)
            int ans = i * j;
            return ans; 
       }
        static void AddNumbers(int i, int j) 
        {
        int ans=i+j;
            Console.WriteLine($"The addition of {i} and {j}={ans}");
        }

       static void AcceptName()
        {
            Console.WriteLine("Enter name");
           name=Console.ReadLine();
            

        }
        static void DisplayName()
        {

            Console.WriteLine(name);
        }



    }
}
