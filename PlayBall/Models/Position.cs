using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PlayBall.Models
{
    [Table("Position")]
    public class Position
    {
        [Key]
        public String teamID { get; set; }
        public String teamName { get; set; }
    }
}