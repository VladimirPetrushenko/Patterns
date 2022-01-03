using Strategy.SecondExample;
using Strategy.ThirdExample;
using System;
using System.Collections.Generic;

namespace Strategy
{
    class ThirdExampleStrategy : IStrategy
    {
        public void Make()
        {
            IComparer<Employee> comparer = new EmployeeByIdComparer();
            var list = CreateListEmployee.Create();

            var set = new SortedSet<Employee>(list, comparer);

            foreach (var e in set)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            comparer = ComparerFactory.Create<Employee>((x, y) => x.Name.CompareTo(y.Name));

            set = new SortedSet<Employee>(list, comparer);

            foreach (var e in set)
            {
                Console.WriteLine(e);
            }
        }
    }
}
