using System;
using System.Collections.Generic;
using System.Text;

namespace Trains.Model
{
    public class City
    {
        public int CityId { get; set; }

        public string CityName { get; set; }

        public override string ToString()
        {
            return CityName;
        }
    }
}
