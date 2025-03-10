using System.ComponentModel.DataAnnotations; 

namespace u23784718_S1P01.Models
{
    public class PersonModel
    {
      

        [Display(Name = "First Name")] 
        public string FirstName { get; set; }

        [Display(Name = "Last Name")] 
        public string LastName { get; set; }
        
        [Display(Name = "Student Number")] 
        public int Age { get; set; } = 0;

        [Display(Name = "Email Address")] 
        public string EmailAddress { get; set; }

        [Display(Name = "Student Number")]
        public int StudentNumber { get; internal set; }

        [Display(Name ="Link to personal page")]
        public string MyLink { get; set; }


    }
}