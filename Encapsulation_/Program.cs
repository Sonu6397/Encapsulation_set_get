using System;

namespace Encapsulation_
{
    class Employee
    {
        public int EmpNo;
        public string EmpName;

        public void SetEmpNo(int EmpNo)
        {
            this.EmpNo = EmpNo;
           
        }

        public int GetEmpNo()
        {
            return EmpNo;
          
        }

        public void SetEmpName(string EmpName)
        {
            this.EmpName = EmpName;

        }

        public string GetEmpName()
        {
            return EmpName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee E = new Employee();
            E.EmpNo = 12;
            E.EmpName = "sonu kuamr";
            Console.WriteLine(E.GetEmpNo());
            Console.WriteLine(E.GetEmpName());
            Console.ReadLine();
        }
    }
}
