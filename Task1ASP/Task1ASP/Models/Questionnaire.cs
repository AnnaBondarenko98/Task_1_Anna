using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Task1ASP.Models
{
    public class Questionnaire
    {
        public int ID { get; set; }

        public string About { get; set; }

        [Range(0, 100, ErrorMessage = "Enter correct data")]
        public int Age { get; set; }

        public  string Eye { get; set; }

        public ICollection<string> Animals { get; set; }

        


    }
}