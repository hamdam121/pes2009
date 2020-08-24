using pes2009.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace pes2009.DAL
{
    public class DbPesContext : DbContext
    {
        public DbPesContext()
        {

        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamTitle> TeamTitles { get; set; }
        public DbSet<Season> Seasons { get; set; }

    }
}