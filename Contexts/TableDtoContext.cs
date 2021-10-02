using Intellig.Api.Entities;
using Intellig.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intellig.Api.Contexts
{
    public class TableDtoContext : DbContext
    {
        public TableDtoContext(DbContextOptions<TableDtoContext> options) : base(options)
        {

            Database.EnsureCreated();

        }
        public DbSet<TableDto> TableData {get; set;}
    }
}
