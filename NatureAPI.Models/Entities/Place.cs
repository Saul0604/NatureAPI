namespace NatureAPI.Models.Entities;

public class Place
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public int ElevationMeters {get; set;}
    public bool Accessible { get; set; }
    public double EntryFee { get; set; }
    public string OpeningHours { get; set; }
    public DateTime CreatedAt { get; set; }
    
    //navigation properties
    public List<Trail> Trail { get; set; }
    public List<Photo> Photo { get; set; }
    public List<Review> Review { get; set; }
    public List<PlaceAmenity> PlaceAmenity { get; set; }
    
    
}


