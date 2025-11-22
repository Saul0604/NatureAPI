namespace NatureAPI;

using System.Text;
using NatureAPI.Models.DTOs;
 
public static class Prompts
{
    public static string GenerateData(string jsonData)
    {
        return $@"
            Eres un asistente experto en turismo y viajes en México.
            Analiza los siguientes datos sobre lugares naturales en México (en JSON): {jsonData}
            
            Debes responder **exclusivamente** en formato JSON válido con la siguiente estructura:
            {{
                ""DatoCurioso"": ""string con un dato interesante o curiosidad histórica del lugar"",
                ""HotelesCercanos"": [
                    {{
                        ""NombreHotel"": ""string con el nombre del hotel"",
                        ""DireccionHotel"": ""string con la dirección completa"",
                        ""TelefonoHotel"": ""string con el teléfono"",
                        ""SitioWebHotel"": ""string con la URL del sitio web""
                    }}
                ],
                ""RestaurantesCercanos"": [
                    {{
                        ""NombreRestaurante"": ""string con el nombre del restaurante"",
                        ""DireccionRestaurante"": ""string con la dirección completa"",
                        ""TelefonoRestaurante"": ""string con el teléfono"",
                        ""SitioWebRestaurante"": ""string con la URL del sitio web""
                    }}
                ]
            }}
            
            IMPORTANTE: 
            - Proporciona de 2 a 3 hoteles y 2 a 3 restaurantes cercanos al lugar.
            - Si no encuentras información exacta, proporciona opciones realistas basadas en la ubicación.
            - Todos los valores deben ser strings válidos.
            - NO incluyas texto adicional fuera del JSON.
            - Asegúrate de que el JSON sea válido y parseable.
        

            SI NO puedes cumplir con estas instrucciones, responde **solo** con 'error'.
            No saludes, no des explicaciones, no agregues texto adicional.";
    }
}