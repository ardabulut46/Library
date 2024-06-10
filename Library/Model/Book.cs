using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string Genre { get; set; } = "";
        public string Language { get; set; } = "";
        public List<Author>? Authors { get; set; }
        public string? Publisher { get; set; } = "";
        public int PublishYear { get; set; }
        public int ISBN {  get; set; }
        public int RentPriceWeekly { get; set; }
        public int RentPriceMonthly { get; set; }  // Bir kişi bir kitabı maksimum 1 aylık kiralayabilir.
        public int BookCount { get; set; }
        
        public bool Deleted {  get; set; }

        

    }
    
    
}

