using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SkillsTracker.Controllers
{
    [Route("/skills")]
    public class SkillsController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<h1>" + "Skills Tracker" + "</h1>" +
                "<h2>" + "Coding Skills To Learn:" + "</h2>" +
                "<ol>" + "<li>" + "C#" + "</li>" + "</ol>" +
                "<ol>" + "<li>" + "JavaScript" + "</li>" + "</ol>" +
                "<ol>" + "<li>" + "Python" + "</li>" + "</ol>";
            return Content(html, "text/html");
        }

        //GET: /skills/form
        [HttpGet("form/")]
        [HttpPost("form")]
        public IActionResult Form()
        {
            string html = "<form method='post' action='/skills/form'>" +
                "<h2>Date:</h2>" +
                "<input type='date' id='date' name='date of progress' value='mm/dd/yyyy'>" +

                "<h2>C#:</h2>" +
                "<select name = 'C# progress'>" +
                    "<option value = ''> -Please Choose Your Level Of Expertise- </option>" +
                    "<option value = 'easy'> Novice </option>" +
                    "<option value = 'medium'> Intermediate </option>" +
                    "<option value = 'hard'> Expert </option>" +
                "</select>" +

                "<h2>JavaScript:</h2>" +
                "<select name = 'JS progress'>" +
                    "<option value = ''> -Please Choose Your Level Of Expertise- </option>" +
                    "<option value = 'easy'> Novice </option>" +
                    "<option value = 'medium'> Intermediate </option>" +
                    "<option value = 'hard'> Expert </option>" +
                "</select>" +

                "<h2>Python:</h2>" +
                 "<select name = 'Python progress'>" +
                    "<option value = ''> -Please Choose Your Level Of Expertise- </option>" +
                    "<option value = 'easy'> Novice </option>" +
                    "<option value = 'medium'> Intermediate </option>" +
                    "<option value = 'hard'> Expert </option>" +
                "</select>" +

                "<input type='submit' value='Submit'/>" +
                "</form>";

            return Content(html, "text/html");

        }

    }
}
