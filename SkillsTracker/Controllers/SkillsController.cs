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
                    "<ol>" +
                        "<li>" + "C#" + "</li>" +
                        "<li>" + "JavaScript" + "</li>" +
                        "<li>" + "Python" + "</li>" +
                    "</ol>";
            return Content(html, "text/html");
        }

        //GET: /skills/form
        [HttpGet]
        [Route("/skills/form")]
        public IActionResult Form()
        {
            string html = "<form method='post' action='/skills/form'>" +
                "<h2>Date:</h2>" +
                "<input type='date' id='date' name='date' value='mm/dd/yyyy'>" +

                "<h2>C#:</h2>" +
                "<select name = 'csharp'>" +
                    "<option value = ''> -Please Choose Your Level Of Expertise- </option>" +
                    "<option value = 'Novice'> Novice </option>" +
                    "<option value = 'Intermediate'> Intermediate </option>" +
                    "<option value = 'Expert'> Expert </option>" +
                "</select>" +

                "<h2>JavaScript:</h2>" +
                "<select name = 'js'>" +
                    "<option value = ''> -Please Choose Your Level Of Expertise- </option>" +
                    "<option value = 'Novice'> Novice </option>" +
                    "<option value = 'Intermediate'> Intermediate </option>" +
                    "<option value = 'Expert'> Expert </option>" +
                "</select>" +

                "<h2>Python:</h2>" +
                 "<select name = 'python'>" +
                    "<option value = ''> -Please Choose Your Level Of Expertise- </option>" +
                    "<option value = 'Novice'> Novice </option>" +
                    "<option value = 'Intermediate'> Intermediate </option>" +
                    "<option value = 'Expert'> Expert </option>" +
                "</select>" +
                "<br></br>" +
                "<input type='submit' value='Submit'/>" +
                "</form>";

            return Content(html, "text/html");

        }

        //POST: /skills/form
        [HttpPost]
        [Route("/skills/form")]
        public IActionResult DisplayForm(string date, string csharp, string js, string python)
        {
            string html = $"<h1>{date}</h1>" +
                            "<ol>" +
                                $"<li>C#: {csharp}</li>" +
                                $"<li>JavaScript: {js}</li>" +
                                $"<li>Python: {python}</li>" +
                            "</ol>";

            return Content(html, "text/html");
        }


    }
}
