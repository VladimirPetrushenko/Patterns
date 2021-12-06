using System.Collections.Generic;

namespace Strategy.SecondExample
{
    class EmployeeByIdComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }
}
