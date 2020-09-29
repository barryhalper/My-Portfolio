namespace Portfolio.Business.Models
{
    public interface ICourse
    {
        string Id { get; set; }
        string Title { get; set; }
        int Year { get; set; }
    }
}