﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter08
{
    class ObjectInitializer
    {
        
        string home_number;
        string building;

        public ObjectInitializer(string home_number, string building)
        {
            this.Home_number = home_number;
            this.Building = building;
            Console.WriteLine(this.Home_number);
        }

        public string Home_number { get => home_number; set => home_number = value; }

        public string Building { get => building; set => building = value; }
    }
}