using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SinimaDB.Domain.Entities
{
    public class Movie
    {
        public Movie()
        {
            Actors = new HashSet<Actor>();
        }

        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public string Plot { get; set; }
        public Producer Producer { get; set; }

        [MaxLength(-1)]
        [Column(TypeName="image")]
        public byte[] Poster { get; set; }

        public ICollection<Actor> Actors { get; private set; }
    }
}
