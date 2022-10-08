namespace WebApplication1.Models
{
    public class Invoice_DEtails
    {
        public int Invoice_Details_Id { get; set; }
        public int Invoice_Details_qty { get; set; }
        public decimal Invoice_Details_amount { get; set; }
        public int Invoice_Hed_Invoice_Hed_Id { get; set; }
        public int Products_Product_id { get; set; }
    }
}
