using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace registrationSystem.data
{
    [Table("Students")]
    public class Student : UserProfile
    {
      
        [Key]
        
            public string StudentNumber { get; set; }
            public int Gradeid { get; set; }
            public virtual Grade Grade { get; set; }
            public string ClassGroupeid { get; set; }
            public virtual ClassGroupe ClassGroupe { get; set; }
            public string ParentIdentity { get; set; }
            public virtual Parent Parent { get; set; }
            public string StreamCode { get; set; }
            public virtual Stream Streams { get; set; }
            public string UserRole { get; set; }
            public int Year { get; set; }
            public int? FeeID { get; set; }
            public double OutStandingBalance { get; set; }
            public virtual SchoolFee SchoolFee { get; set; }
            public string BirthCertificateType { get; set; }
            public byte[] BirthCertificate { get; set; }
            public string ReportCopyType { get; set; }
            public byte[] ReportCopy { get; set; }
            public string status { get; set; }
        
    }
}