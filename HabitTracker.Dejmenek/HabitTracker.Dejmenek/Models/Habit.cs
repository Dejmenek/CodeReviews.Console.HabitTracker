﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitTracker.Dejmenek.Models
{
    public class Habit
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long Quantity { get; set; }
        public string QuantityUnit { get; set; }
        public string Date { get; set; }
    }
}