using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pes2009.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }

        public virtual ICollection<TeamTitle> TeamTitles { get; set; }
        public virtual int SeasonTitleID { get; set; }


    }
}