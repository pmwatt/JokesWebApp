﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesWebApp.Models
{
    public class Joke
    {
        public int Id { get; set; } // prop tab tab whoa
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }
        public Joke()
        {

        }
}
}
