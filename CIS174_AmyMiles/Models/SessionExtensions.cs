using System.Text.Json;
namespace CIS174_AmyMiles.Models
{
    public static class SessionExtensions
    {
        //page 345
        public static void SetObject<T>(this ISession session, string key, T value)//needs to be T
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T? GetObject<T>(this ISession session, string key)
        {
            var json = session.GetString(key);
            return (string.IsNullOrEmpty(json)) ? default(T) : JsonSerializer.Deserialize<T>(json);
        }


    }
}
