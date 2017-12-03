﻿using System.Collections.Generic;

namespace FlightBooking.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        public string Email { get; set; }
        public string CcNumber { get; set; }
        public IEnumerable<Flight> BookingFlights { get; set; }
    }
}