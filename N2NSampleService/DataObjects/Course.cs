﻿using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace N2NSample.Service.DataObjects
{
    public class Course: EntityData
    {
        public string Name { get; set; }
    }
}