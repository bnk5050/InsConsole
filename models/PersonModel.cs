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
        public string FirstName { get; set; }
        public string? LastName { get; set; }

        public Person(long PersonId_, string FirstName_, string? LastName_)
        {
            this.PersonId = PersonId_;
            this.FirstName = FirstName_;
            this.LastName = LastName_;
        }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
