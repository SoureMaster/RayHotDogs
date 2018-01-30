using System;
using System.Collections.Generic;
using System.Text;

namespace RayHotDogs.Core.Model
{
   public class HotDogGroup
    {
        public int HotDogGroupID { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public List<HotDogs> HotDogs { get; set; }
  
    }
}
