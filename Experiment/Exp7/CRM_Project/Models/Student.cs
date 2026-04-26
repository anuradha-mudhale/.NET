using System.ComponentModel.DataAnnotations;

public class Student{
    [Required (ErrorMessage = "name field required")]
    public String Name{get; set;}

    [Range(18,60)]
    public int Age{get; set;}

    [EmailAddress]
    public String Email{get; set;}

    [StringLength(8)]
    public string Password{get; set;}
}