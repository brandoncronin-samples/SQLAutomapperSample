using System;
using System.ComponentModel.DataAnnotations;

namespace SQLAutomapperSample.DataAccess.Models
{
    public class SampleOrder
    {
        [Key]
        public int Id { get; set; }
        public Guid OrderKey { get; set; }
        public Guid OrderTypeKey { get; set; }
        public Guid OrderStatusKey { get; set; }
        public string OrderNo { get; set; }
        public Guid ResidentKey { get; set; }
        public string Item { get; set; }
        public string ItemDescription { get; set; }
        public decimal Quantity { get; set; }
        public decimal QuantityMax { get; set; }
        public string UOM { get; set; }
        public decimal Total { get; set; }
        public Guid ScheduleKey { get; set; }
        public Guid SiteKey { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid VaccinationKey { get; set; }
        public Guid SubmittedByKey { get; set; }
        public DateTime SubmittedDatetime { get; set; }
        public Guid DiscontinuedByKey { get; set; }
        public DateTime DiscontinuedDatetime { get; set; }
        public Guid DeliveryMethodKey { get; set; }
        public bool PRN { get; set; }
        public string Instructions { get; set; }
        public string Comment { get; set; }
        public bool SendToPharmacy { get; set; }
        public decimal GCN_SEQNO { get; set; }
        public byte DEA { get; set; }
        public bool ForPain { get; set; }
        public bool DoNotCrush { get; set; }
        public string TranscribeMethod { get; set; }
        public Guid TranscribedForKey { get; set; }
        public bool OffFormulary { get; set; }
        public bool ProfileOrder { get; set; }
        public short DurationDays { get; set; }
        public byte Refills { get; set; }
        public short RefillMaxDays { get; set; }
        public byte KopPrivilegeStatusId { get; set; }
        public byte PharmacyDeliveryTypeId { get; set; }
        public DateTime ModifyDate { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string FP { get; set; }
    }
}
