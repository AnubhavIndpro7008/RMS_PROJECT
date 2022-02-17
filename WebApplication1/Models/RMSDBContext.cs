using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class RMSDBContext : DbContext
    {
        public RMSDBContext() : base("reg_Page")
        {

        }
        public DbSet<reg_Page> Reg_Pages { get; set; }
    }
   
}