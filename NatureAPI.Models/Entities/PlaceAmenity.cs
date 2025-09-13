namespace NatureAPI.Models.Entities;

public class PlaceAmenity
{
    public int PlaceId  { get; set; }
    public int AmenityId { get; set; }
    
    // Propiedades de navegación
    public Place Place { get; set; }
    public Amenity Amenity { get; set; }
    
}