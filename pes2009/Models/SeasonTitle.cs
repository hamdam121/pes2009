﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pes2009.Models
{
    public class SeasonTitle
    {
        public int ID { get; set; }

        public virtual int SeasonID { get; set; }
        public virtual int TeamTitleID { get; set; }


    }
}