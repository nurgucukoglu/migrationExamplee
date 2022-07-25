using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MigrationExample.Models
{
    public partial class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string  age { get; set; }
        public string classroom { get; set; }


    }
}