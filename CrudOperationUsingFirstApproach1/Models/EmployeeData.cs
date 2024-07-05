using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudOperationUsingFirstApproach1.Models
{
    public class EmployeeData
    {
        [Key]
        public int id { get; set; }
        [Column("EmployeeName", TypeName= "varchar(100)" )]
        public string Name { get; set; }

        public int Salary { get; set; }
        public string Email { get; set; }

        public int age { get; set; }
    }
}
