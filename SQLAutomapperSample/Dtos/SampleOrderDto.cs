using System;

namespace SQLAutomapperSample.Dtos
{
    public class SampleOrderDto
    {
        public int Id { get; set; }
        public string OrderNo { get; set; }
        public string Item { get; set; }
        public string ItemDescription { get; set; }
        public decimal Total { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
