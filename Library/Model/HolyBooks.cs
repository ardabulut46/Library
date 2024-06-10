using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class HolyBooks
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Religion { get; set; } = "";
        public List<Author>? Authors { get; set; } 
        public int EstimatedYear {  get; set; } 
        public int ISBN {  get; set; }
        public string Language { get; set; } = "";

        public string? Publisher { get; set; } = "";

    }
}
