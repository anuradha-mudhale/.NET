using System.ComponentModel.DataAnnotations;

public class Student
{
    [Required(ErrorMessage = "Name Field required")]
    public string name{get;set;}

    [Range(18,60)]
    public int age{get;set;}

    [EmailAddress]
    public string email{get;set;}

}