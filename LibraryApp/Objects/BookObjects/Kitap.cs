using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Objects
{
    internal class Kitap
    {
        int kitapid { set; get; }

        string ISBN { set; get; }   

        string kitapadi {  set; get; }

        string yazaradi { set; get; }   

        string yayinevi { set; get; }

        int sayfasayisi { set; get; } 

        DateTime basimtarihi { set; get; }

        string dil { set; get; }

    }
}
