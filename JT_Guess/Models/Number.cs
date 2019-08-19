using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JT_Guess.Models
{
    public class Number
    {
        public int RandomNumber { get; private set; }

        public Number()
        {
            Random rng = new Random();
            RandomNumber = rng.Next(1, 101);
        }
    }
}