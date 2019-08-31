using Microsoft.EntityFrameworkCore;
using PersonRepository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonRepository.SQL
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options) 
            : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
    }
}
