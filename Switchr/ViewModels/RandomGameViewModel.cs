using Switchr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Switchr.ViewModels
{
    public class RandomGameViewModel
    {
        public Game Game { get; set; }
        public List<Customer> Customers { get; set; }
    }
}