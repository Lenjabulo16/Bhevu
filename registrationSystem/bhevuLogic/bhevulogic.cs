using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using registrationSystem.data;

namespace registrationSystem.bhevuLogic
{
    public class bhevulogic
    {
        public List<Student> studlist { get; set; }
        public List<ClassGroupe> grouplist { get; set; }
        //public List<Teacher> teacherlist { get; set; }
    }
}