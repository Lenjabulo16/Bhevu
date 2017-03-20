using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace registrationSystem.data
{
    [Table("user")]
    public class user
    {

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        /*internal static object FirstOrDefault()
        {
            throw new NotImplementedException(user.Equals();
        }*/
    }
}