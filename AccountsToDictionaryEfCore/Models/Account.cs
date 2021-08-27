using System;
using System.Collections.Generic;

#nullable disable

namespace AccountsToDictionaryEfCore.Models
{
    public partial class Account
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public string Location { get; set; }
    }
}