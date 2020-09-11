namespace Portfolio.Business.Models
{
    public interface IAbout
    {
        string Desc { get; set; }
        string Id { get; set; }
        int Order { get; set; }
        string Type { get; set; }
    }
}