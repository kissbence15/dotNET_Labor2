using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor2
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public double Percentage { get; set; }

        public Student(int id, string firstName, string lastName, double percentage)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Percentage = percentage;
        }

        public override string ToString()
        {
            return "Id: " + this.Id + " FirstName: " + this.FirstName + " LastName: " + this.LastName + " Percentage: " + this.Percentage;
        }
    }
}
