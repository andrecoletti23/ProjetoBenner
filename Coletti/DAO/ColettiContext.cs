﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Coletti.DAO
{
    public class ColettiContext : DbContext
    {
        public ColettiContext():base("Server=(localdb)\\mssqllocaldb;Database=ColettiDB;Trusted_Connection=true;")
        {
            
        }
    }
}