using Strategy.SecondExample;
using System;

namespace Strategy
{
    class SecondExampleStrategy : IStrategy
    {
        public void Make()
        {
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
        }
    }
}
