using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_HandsOn3.Models;

namespace WebApi_HandsOn3
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Salary { get; set; }

        public bool Permanent { get; set; }

        public Department Department { get; set; }

        public List<Skill> Skills { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
