using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Models
{
    public class Client
    {
        [Key]
        public long Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string? SocialSecurityNumber { get; set; }

        [JsonIgnore]
        public float Age { 
            get 
            {

                return (float)(new DateTimeOffset(DateTime.Now.ToUniversalTime(), TimeSpan.Zero).ToUnixTimeMilliseconds() - new DateTimeOffset(Birthdate.ToUniversalTime(), TimeSpan.Zero).ToUnixTimeMilliseconds() / (365.25 * 24 * 60 * 60 * 1000));
            } 
            private set 
            {

            } 
        }

        public override string ToString()
        {
            return $"Client [{Id}, {FirstName}, {LastName}, {Birthdate}, {SocialSecurityNumber}]";
        }

    }
}