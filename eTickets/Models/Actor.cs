using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Bio { get; set; }

        //Realtionship
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
