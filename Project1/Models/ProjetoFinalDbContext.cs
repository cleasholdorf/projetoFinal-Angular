using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class ProjetoFinalDbContext : DbContext
    {
        public ProjetoFinalDbContext(DbContextOptions<ProjetoFinalDbContext> options) : base(options)
        {

        }
    }
}
