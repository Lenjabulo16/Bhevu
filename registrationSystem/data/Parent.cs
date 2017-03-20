using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace registrationSystem.data
{
    [Table("parent")]
    public class Parent
    {

        [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.None)]

            public string Parent_Identity { get; set; }
            public string Title { get; set; }
            public string ParentName { get; set; }
            public string ParentSurname { get; set; }
            public string ParentNumber { get; set; }
            public string ParentAdress { get; set; }
            public string ParentEmail { get; set; }
            public ICollection<Student> Students { get; set; }
        
    }
}