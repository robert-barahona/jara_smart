using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ADCN.Models
{
    internal class Result
    {
        [PrimaryKey, AutoIncrement]
        public int idResult { get; set; }
        [MaxLength(100)]
        public string name { get; set; }
        public int idJuego { get; set; }
        public int points { get; set; }
    }
}
