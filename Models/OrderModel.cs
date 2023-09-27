using System.ComponentModel.DataAnnotations;

namespace WorkOrderSystem.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string ContactPerson { get; set; }
        public string Description { get; set; }
        public string CompanyName {  get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string AssignedWorker {  get; set; }
        public int OrderType { get; set; }


    }
}
