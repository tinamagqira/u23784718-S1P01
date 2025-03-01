using System.ComponentModel.DataAnnotations; 

namespace u23784718_Prac1.Models
{
    public class PersonModel
    {
        public global::System.Int32 MyProperty { get; set; }
      

        [Display(Name = "First Name")] 
        public string FirstName { get; set; }

        [Display(Name = "Last Name")] 
        public string LastName { get; set; }
        
        [Display(Name = "Student Number")] 
        public int Age { get; set; } = 0;

        [Display(Name = "Email Address")] 
        public string EmailAddress { get; set; }
    }
}