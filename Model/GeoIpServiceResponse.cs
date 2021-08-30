﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingPracticalTest.Model
{
    public class GeoIpServiceResponse
    {
        public string ip { get; set; }
        public string country_code { get; set; }
        public string country_name { get; set; }
        public string region_code { get; set; }
        public string region_name { get; set; }
        public string city { get; set; }
        public string zip_code { get; set; }
        public string time_zone { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public int metro_code { get; set; }

        public DomainDetail ConvertToDomainDetail()
        {
            return new DomainDetail
            {
                ServiceName = Constants.GeoIp,
                Address = this.ip,
                Country = this.country_name,
                Region = this.region_name,
            };
        }
    }
}
