using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Objects
{
    internal class Duyuru
    {
        int duyuruid { set; get; }

        string baslik { set; get; }

        string icerik { set; get; }
        
        DateTime yayintarihi { set; get; }
    }
}
