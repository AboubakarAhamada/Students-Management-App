using System; 
using System.ComponentModel.DataAnnotations; 
  
namespace LastApp.Models 
{ 
  
     public class Student 
   { 
       public int Id { get; set; } 
  
       [Required] 
       [Display(Name="First Name")] 
       [StringLength(50)] 
       public string FirstName { get; set; } 
  
       [Required] 
       [Display(Name="Last Name")] 
       [StringLength(50)] 
       public string LastName { get; set; } 
  
       [Required] 
       [DataType(DataType.EmailAddress)] 
       public string Email { get; set; } 
   } 
  
}