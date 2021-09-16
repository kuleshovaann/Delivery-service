using System;

namespace DeliverySystem.DAL.Models
{
    public class Delivery : BaseModel
    {
        public string Name { get; set; }
        public int CostOfDelivery { get; set; }
    }
}
