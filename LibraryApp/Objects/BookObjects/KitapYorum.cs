using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Objects
{
    internal class KitapYorum
    {
        int kitapyorumid {  get; set; }

        int uyeid { get; set; }

        int kitapid { get; set; }

        string yorum { get; set; }

        DateTime yorumtarihi { get; set; }

        short puan {  get; set; } 
    }
}
