﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AddPermissionModel
    {
        public int UserId { get; set; }
        public string PermissionType { get; set; }
        public DateTime  StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
