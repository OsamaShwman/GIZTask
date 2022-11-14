﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebApplication5.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext( )
          
        {
        }
    
    public DbSet<User> User { set; get; }
    public DbSet<Department> Department { set; get; }
       
       
    }
}