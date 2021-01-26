using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GraysonsThirdAspWebApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GraysonsThirdAspWebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpGet("Calculator")]

        public IActionResult Calculator()
        {

            return View();
        }
        [HttpPost("Calculator")]

        public IActionResult Calculator(Grade model)
        {
            if (ModelState.IsValid)
            {
                // calc grade 
                Double calc_grade = model.assignments * 0.5
                    + model.group_projects * 0.1  + model.quizzes * 0.1
                    + model.exams *0.2 + model.intex * 0.1;

                // get letter grade
                string letter_grade = "";
            if (calc_grade >= 94)
                    {
                    letter_grade = "A";

            }
                    else if (calc_grade >= 90)
                    {
                    letter_grade = "A-";
        
            }
                    else if (calc_grade >= 87)
                    {
                    letter_grade = "B+";
        
            }
                    else if (calc_grade >= 84)
                    {
                    letter_grade = "B";
        
            }
                    else if (calc_grade >= 80)
                    {
                    letter_grade = "B-";
        
            }
                    else if (calc_grade >= 77)
                    {
                    letter_grade = "C+";
        
            }
                    else if (calc_grade >= 74)
                    {
                    letter_grade = "C";
        
            }
                    else if (calc_grade >= 70)
                    {
                    letter_grade = "C-";
                    }
                    else if (calc_grade >= 67)
                    {
                    letter_grade = "D+";
        
            }
                    else if (calc_grade >= 64)
                    {
                    letter_grade = "D";
        
            }
                    else if (calc_grade >= 60)
                    {
                    letter_grade = "D-";
        
            }
                    else
                    {
                    letter_grade = "E";
        
            }
                string final_grade = letter_grade + " " + Math.Round(calc_grade,2) + "%";
                ViewBag.final_grade = final_grade;
                return View("Calculator");
            }
            return View();
           
        }
    }
}
