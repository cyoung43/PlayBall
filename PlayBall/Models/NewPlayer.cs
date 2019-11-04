using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PlayBall.Models
{
    public class NewPlayer
    {
        [Key]
        public int playerID { get; set; }
        public String playerLastName { get; set; }
        public String playerFirstName { get; set; }
        public String positionCode { get; set; }
        public String positionDesc { get; set; }
        public String teamID { get; set; }
        public String teamName { get; set; }
    }
}