﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Switchr.DTOs
{
    public class NewRentalDto
    {
        public int CustomerId { get; set; }
        public List<int> GameIds { get; set; }
    }
}