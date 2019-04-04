using System;
using System.Collections.Generic;

namespace SinimaDB.Domain.Entities
{
    public class Producer
    {
        public Producer()
        {
            Movies = new HashSet<Movie>();
        }
        public string Name { get; set; }
        public string Sex { get; set; }
        public DateTime DOB { get; set; }
        public string Bio { get; set; }

        public ICollection<Movie> Movies { get; private set; }
    }
}
