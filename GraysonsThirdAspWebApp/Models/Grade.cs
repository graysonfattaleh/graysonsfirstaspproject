using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// gets error messages
using System.ComponentModel.DataAnnotations;
namespace GraysonsThirdAspWebApp.Models
{
    public class Grade {
        // get variables from post
        [Required(ErrorMessage = "Must be numeric value")]
        [Range( 0,100, ErrorMessage = "Assignments must be between 0 and 100")]
        public Double assignments { get; set; }
        [Required(ErrorMessage = "Must be numeric value")]
        [Range(0, 100, ErrorMessage = "Group Projects must be between 0 and 100")]
        public Double group_projects { get; set; }
        [Required(ErrorMessage = "Must be numeric value")]
        [Range(0, 100, ErrorMessage = "Quizzes must be between 0 and 100")]
        public Double quizzes { get; set; }
        [Required(ErrorMessage = "Must be numeric value")]
        [Range(0, 100, ErrorMessage = "Exams must be between 0 and 100")]
        public Double exams { get; set; }
        [Required (ErrorMessage = "Must be numeric value")][Range(0, 100, ErrorMessage = "Intex must be between 0 and 100")]
        public Double intex { get; set; }
       
       
    }
}
