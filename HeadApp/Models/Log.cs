﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HeadApp.Models
{
    public class Log
    {
        public int logId { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public string Description { get; set; }
    }
}