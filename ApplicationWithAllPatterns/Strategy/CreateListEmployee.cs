using Strategy.SecondExample;
using System.Collections.Generic;

namespace Strategy
{
    static class CreateListEmployee
    {
        public static List<Employee> Create()
        {
            return new List<Employee>
            {
                new Employee { Id = 0, Name = "Markiz" },
                new Employee { Id = 8, Name = "Alexander" },
                new Employee { Id = 3, Name = "Vladimir" }
            };
        }
    }
}
