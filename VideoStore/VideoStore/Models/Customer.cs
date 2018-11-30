using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; // [Required]

namespace VideoStore.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(256)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public  MembershipType MembershipType{ get; set; }
        public byte MembershipTypeId { get; set; }
    }
}