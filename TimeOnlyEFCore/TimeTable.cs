﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace TimeOnlyEFCore
{
    public partial class TimeTable
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
    }
}