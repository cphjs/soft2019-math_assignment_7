using System;

namespace assignment_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Depositing negative amount ");
            new Account(5).deposit(-1);
        }
    }
}
