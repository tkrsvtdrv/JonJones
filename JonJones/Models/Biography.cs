namespace JonJones.Models;

public class Biography
{
    public string FullName { get; set; } = string.Empty;
    public string Born { get; set; } = string.Empty;
    public string Nationality { get; set; } = string.Empty;
    public string Profession { get; set; } = string.Empty;
    public List<string> Highlights { get; set; } = new List<string>();
}
