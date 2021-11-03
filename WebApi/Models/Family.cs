﻿using System.Collections.Generic;

namespace WebApi.Models
{
    public class Family
    {
        public string StreetName { get; set; }
        public int HouseNumber{ get; set; }
        public List<Adult> Adults { get; set; }
        //public List<Child> Children{ get; set; }
        //public List<Pet> Pets{ get; set; }

        public Family() {
            Adults = new List<Adult>();     
        }
    }
}