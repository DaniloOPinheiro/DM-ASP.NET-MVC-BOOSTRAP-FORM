using System;

namespace DM_WEB.Models
{
    public class Pessoa
    {
        public string CPF { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Sex Sex { get; set; }
        public MaritialStatus MaritalStatus { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string PublicPlace { get; set; }
        public string AddressNumber { get; set; }
        public string AddOnAddress { get; set; }
        public string Income { get; set; }
    }
}