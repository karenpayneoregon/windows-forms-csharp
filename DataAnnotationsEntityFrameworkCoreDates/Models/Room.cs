﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DataAnnotationsEntityFrameworkCoreDates.Models
{
    public partial class Room
    {
        [Key]
        public int RoomIdentifier { get; set; }
        public int? Identifier { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? StartTime { get; set; }
    }
}