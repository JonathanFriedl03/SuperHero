using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroes.Models
{
    public class SuperHero
    {
        [Key]//when KEY is red select using dataannotations
        public int Id { get; set; }
        //[Required(ErrorMessage = "Suoer Hero is required.")]
        public string Super_Hero { get; set; }
        //[Required(ErrorMessage = "Alter Ego is required.")]
        public string Alter_Ego { get; set; }
        //[Required(ErrorMessage = "Power is required.")]
        public string Main_Power { get; set; }
        public string Secondary_Power { get; set; }
        //[Required(ErrorMessage = "Catch Phrase is required.")]
        public string Catch_Phrase { get; set; }
    }
}
