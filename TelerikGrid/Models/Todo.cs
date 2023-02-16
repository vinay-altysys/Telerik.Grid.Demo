﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelerikGrid.Shared;

namespace TelerikGrid.Models
{
    public class Todo
    {
        public int id { get; set; }
        public int userId { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }
        public OpsType EditStatus { get; set; } = OpsType.None;
    }
}
