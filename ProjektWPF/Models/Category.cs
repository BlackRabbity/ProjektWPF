﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPF.Models
{
    public class Category
    {
        public string Name { get; set; }
        public List<Task> Tasks { get; set; }
        public Category(string name)
        {
            Name = name;
            Tasks = new List<Task>();
        }

    }
}
