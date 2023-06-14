using System.ComponentModel.DataAnnotations;

namespace GlobalGames.Data.Entities
{
    public class Newsletter : IEntity
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public User user { get; set; }

      
    }
}
