using Coletti.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Coletti.DAO
{
    public class ColettiContext : DbContext
    {
        public DbSet<Teste> Testes { get; set; }
        public ColettiContext():base("Server=(localdb)\\mssqllocaldb;Database=ColettiDB;Trusted_Connection=true;")
        {
            
        }
    }
}