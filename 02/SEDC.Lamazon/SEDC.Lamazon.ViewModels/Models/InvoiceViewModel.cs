﻿using SEDC.Lamazon.ViewModels.Enums;
using System;
using System.Collections.Generic;

namespace SEDC.Lamazon.ViewModels.Models
{
    public class InvoiceViewModel
    {
        public int Id { get; set; }
        public OrderViewModel Order { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public UserViewModel User { get; set; }
        public InvoiceStatus InvoiceStatus { get; set; }

        public List<InvoiceLineItemViewModel> InvoiceLineItems { get; set; }
    }
}
