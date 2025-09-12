namespace NatureAPI.Models.Entities;

public class Photo
{
    public int Id { get; set; }
    public int PlaceId { get; set; }
    public string Url { get; set; }

    public Place Place { get; set; }
}