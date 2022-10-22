using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Final_project_webapi.Models
{
    //Showing the string instead of the number
    [JsonConverter(typeof(JsonStringEnumConverter))]


   
    public enum UserType
    {
        Employee = 1,
        Supplier = 2,
        Owner = 3
    }

    

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Flavor
    {
        Blueberry = 1,
        Orange = 2,
        Oreo = 3,
        cherry = 4
    }

}
