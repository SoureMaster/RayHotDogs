﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RayHotDogs.Core.Model
{
    public class HotDogs
    {
        public int HotDogId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public int Price { get; set; }
        public bool Available { get; set; }
        public int PropTime { get; set; }
        public List<string> Ingredients { get; set; }
        public bool IsFavorite { get; set; }
        public string GroupName { get; set; }
    }
}
