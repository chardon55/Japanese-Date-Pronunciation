using System;
using System.Collections.Generic;
using System.Text;

namespace Japanese_Date_Pronunciation
{
    public class DateQuestion
    {
        //public string Year { get; set; }

        public string Month { get; set; }

        public string Day { get; set; }

        public Answer TheAnswer { get; set; }

        public class Answer
        {
            public string Month { get; set; }
            public string Day { get; set; }
        }
    }
}
