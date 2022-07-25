using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MigrationExample.Models
{
    public class ProjectDb : DbContext
    {
        private static readonly string conn_str = @"Server=yourservername\SQLSERVER2019;Database=schooldatabase;User Id=sa;Password=yourpassword;";

        public ProjectDb(): base(conn_str)
        { }
        public virtual DbSet<Student>Students { get; set; } 
        public virtual DbSet<Teacher>Teachers { get; set; }
        public virtual DbSet<Parent> Parents { get; set; }

    }
    
}