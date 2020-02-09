using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgrenci
    {
        private string ad;
        private string soyad;
        private int id;
        private string numara;
        private string foto;
        private double bakiye;
        private string sifre;
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public int Id { get => id; set => id = value; }
        public string Numara { get => numara; set => numara = value; }
        public string FOTO { get => foto; set => foto = value; }
        public double Bakiye { get => bakiye; set => bakiye = value; }
        public string SIFRE { get => sifre; set => sifre = value; }
    }
}
