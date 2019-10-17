using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HUE02_Friedl_trippin
{
    public class People
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string CityName { get; set }
        public string Country { get; set; }
    }
}
