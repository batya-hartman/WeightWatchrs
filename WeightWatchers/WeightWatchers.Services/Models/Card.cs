﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WeightWatchers.Services.Models
{
   public class Card
    {
        public int id { get; set; }
        public int subscriberId { get; set; }
        public DateTime openDate { get; set; }
        public float BMI { get; set; }
        public float height { get; set; }
        public float weight { get; set; }

        public DateTime updateDate { get; set; }


        

    }
}
