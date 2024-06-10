using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class Author
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string Name { get; set; } = "";
        public string? Surname { get; set; }
        public bool Gender { get; set; }
        public DateOnly BirthDate { get; set; }
        public List<Countries> Nationality { get; set; }
        public List<Book> WrittenBooks { get; set; }

        

    }
}

