﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRestaurant
{
    class Heir: Dish
    {
        public override string ToString()
        {
            return base.ToString() + " Время готовки: " + TimeCooking;
        }
    }
}
