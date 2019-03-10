using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace htx_web.Models
{
    public class Admin
    {
        public int id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
    }
}
