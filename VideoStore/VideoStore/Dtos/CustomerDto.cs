using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VideoStore.Models;

namespace VideoStore.Dtos
{ 
    //Żeby nie było dostepu do szkieletu aplikacji czyli w tym przypadku klasy customers
    public class CustomerDto
    {
       
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public byte MembershipTypeId { get; set; }
   
        //[Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}