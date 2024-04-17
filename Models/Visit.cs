namespace APBD5.Models;

public class Visit
{
    public DateTime DateOfVisit {get; set;}
    public Animal Animal { get; set; }
    public string Description { get; set; }
    public float cost { get; set; }
}