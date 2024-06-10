using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Surname { get; set; } = "";
        public DateOnly BirthDate { get; set; }
        public bool Gender { get; set; }
        public long? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public List<Book> RentedBooks { get; set; }
        public int RentedBooksCount { get; set; }
        public List<Countries> Nationality { get; set; }



       
    }
}
