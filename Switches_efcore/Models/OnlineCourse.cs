﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Switches.Models
{
    public partial class OnlineCourse
    {
        public int CourseID { get; set; }
        public string URL { get; set; }

        public virtual Course Course { get; set; }
    }
}