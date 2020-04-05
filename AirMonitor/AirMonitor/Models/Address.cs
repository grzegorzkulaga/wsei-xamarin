using System;
using System.Collections.Generic;
using System.Text;

namespace AirMonitor.Models
{
    public class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public int DisplayAddress1 { get; set; }
        public int DisplayAddress2 { get; set; }
    }
}