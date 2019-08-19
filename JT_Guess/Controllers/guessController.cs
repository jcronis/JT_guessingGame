using JT_Guess.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JT_Guess.Controllers
{
    public class guessController : Controller
    {
        // POST: guess
        [HttpPost]
        public string Guess(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                int guess = int.Parse(collection.Get("guess"));
                string guesstimate;
                guesstimate = JsonConvert.SerializeObject(guess);

                if (Session["number"] == null)
                {
                    Session["number"] = new Number().RandomNumber;
                }

                int randomCompare = int.Parse(Session["number"].ToString());


                if (guess > randomCompare)
                {
                    guesstimate = "Too High";
                }
                else if (guess < randomCompare)
                {
                    guesstimate = "Too Low";
                }
                else
                {
                    guesstimate = "NAILED IT";
                }

                if (guess == 42 && randomCompare == 42)
                {
                    guesstimate += " Wow, I didn't think that would work?";
                }

                if (guess == 42 && randomCompare != 42)
                {
                    guesstimate += " and you didn't think that would work did you?";
                }

                if (guess == 13 && randomCompare == 13)
                {
                    guesstimate += ", which is cool, because it's usually bad luck.";
                }

                if (guess == 13 && randomCompare != 13)
                {
                    guesstimate += ", which is to be expected, because it's bad luck.";
                }

                if (guess == 69 && randomCompare != 69)
                {
                    guesstimate += "So, you know, that didn't work (it never does)";
                }

                if (guess == 69 && randomCompare == 69)
                {
                    guesstimate += "heh heh Nailed heh heh";
                }

                if (guess <1)
                {
                    guesstimate = "That number is too low for comparison, read the directions.";
                }

                if (guess > 100)
                {
                    guesstimate = "That number is too high for comparison, read the directions.";
                }



                string testerdoodledoo = Session["number"].ToString();

                return guesstimate;// + " " + Session["number"].ToString();
            }
            catch
            {
                return "Boom!";
            }
        }
    }
}
