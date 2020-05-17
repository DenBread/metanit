﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Third_Glava
{
    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string name, string company) : base(name)
        {
            Company = company;
        }
    }
}
