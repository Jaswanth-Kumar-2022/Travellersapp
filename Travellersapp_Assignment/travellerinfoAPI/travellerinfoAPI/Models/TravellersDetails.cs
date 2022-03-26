using System;
using System.Collections.Generic;

namespace travellerinfoAPI.Models
{
    public partial class TravellersDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Mobile { get; set; }
        public string Boarding { get; set; }
        public string Destination { get; set; }
        public string Transport { get; set; }
    }
}
