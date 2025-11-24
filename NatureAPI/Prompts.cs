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
            
            Debes responder ÚNICAMENTE con un objeto JSON válido (SIN bloques de código markdown, SIN ```json, SIN texto adicional) con la siguiente estructura:
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
            
            REGLAS ESTRICTAS: 
            - Proporciona de 2 a 3 hoteles y 2 a 3 restaurantes cercanos al lugar.
            - Si no encuentras información exacta, proporciona opciones realistas basadas en la ubicación.
            - Todos los valores deben ser strings válidos.
            - Tu respuesta debe ser SOLO el objeto JSON, sin markdown, sin bloques de código, sin explicaciones.
            - NO uses ```json ni ``` en tu respuesta.
            - Empieza directamente con {{ y termina con }}.
        ";
    }

    public static string GenerateDataForSinglePlace(string jsonData)
    {
        return $@"
            Eres un asistente experto en turismo y viajes en México.
            Analiza los siguientes datos sobre este lugar natural en México (en JSON): {jsonData}
            
            Debes responder ÚNICAMENTE con un objeto JSON válido (SIN bloques de código markdown, SIN ```json, SIN texto adicional) con la siguiente estructura:
            {{
                ""DatoCurioso"": ""string con un dato interesante o curiosidad histórica específica de este lugar"",
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
            
            REGLAS ESTRICTAS: 
            - Proporciona de 2 a 3 hoteles y 2 a 3 restaurantes cercanos específicamente a este lugar.
            - Si no encuentras información exacta, proporciona opciones realistas basadas en la ubicación específica proporcionada.
            - Todos los valores deben ser strings válidos.
            - Tu respuesta debe ser SOLO el objeto JSON, sin markdown, sin bloques de código, sin explicaciones.
            - NO uses ```json ni ``` en tu respuesta.
            - Empieza directamente con {{ y termina con }}.
        ";
    }
}