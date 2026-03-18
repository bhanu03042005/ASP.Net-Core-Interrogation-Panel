using System.ComponentModel.DataAnnotations;

namespace ASPNET6_Template.Models
{
    public class Problem
    {
        // Implement code here
        [Key]
        public int Id { get; set;}
        [Required(ErrorMessage= "Please provide Problem")]
        public string InterrogatorsProblem { get; set; }
        [Required(ErrorMessage= "Please provide Choice1")]
        public string Choice1 { get; set; }
        [Required(ErrorMessage= "Please provide Choice2")]
        public string Choice2 { get; set; }
        [Required(ErrorMessage= "Please provide Choice3")]
        public string Choice3 { get; set; }
        [Required(ErrorMessage= "Please provide Choice4")]
        public string Choice4 { get; set; }
        [Required(ErrorMessage= "Please provide Solution")]
        public string Solution { get; set; }
        
    }
}

