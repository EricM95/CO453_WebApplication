﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CO453_WebApplication.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, DataType(DataType.PhoneNumber)]
        public string MobileNumber { get; set; }

        [Required]
        public string Address { get; set; }
    }
}
