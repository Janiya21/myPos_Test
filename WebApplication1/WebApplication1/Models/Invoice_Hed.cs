using Microsoft.VisualBasic;
using System;

namespace WebApplication1.Models
{
   public class Invoice
    {
        public int Invoice_Head_id { get; set; }
        public string Invoice_Head_Customer { get; set; }
        public string Invoice_Head_Amount { get; set; }
        public DateTime Invoice_Head_Date { get; set; }
    }
}
