namespace NatureAPI.Models.DTOs;

public class CreatePlaceDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public int ElevationMeters { get; set; }
    public bool Accessible { get; set; }
    public double EntryFee { get; set; }
    public string OpeningHours { get; set; }

    public List<CreateTrailDto>? Trails { get; set; }
    public List<CreatePhotoDto>? Photos { get; set; }
    public List<int>? AmenityIds { get; set; }
}