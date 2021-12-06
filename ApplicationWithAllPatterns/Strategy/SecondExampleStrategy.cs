using Strategy.SecondExample;
using System;
using System.Collections.Generic;

namespace Strategy
{
    public class SecondExampleStrategy : IStrategy
    {
        public void Make()
        {
            Console.WriteLine("Start second strategy");

            var list = CreateListEmployee.Create();

            list.Sort(new EmployeeByIdComparer());
            foreach(var e in list)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            list.Sort((x, y) => x.Name.CompareTo(y.Name));
            foreach (var e in list)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("End");
        }
    }
}
