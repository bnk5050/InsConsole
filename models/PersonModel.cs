using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsConsole.models
{
    public class Person
    {
        public long PersonId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
