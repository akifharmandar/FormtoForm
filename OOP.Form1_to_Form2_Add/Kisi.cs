using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Form1_to_Form2_Add
{
    class Kisi
    {
        public Kisi(string ad,string soyad,string tel)
        {
            this.AD = ad;
            this.SOYAD = soyad;
            this.TEL = tel;
        }
        public Kisi(string ad,string soyad, string tel,string mail):this(ad,soyad,tel)
        {
            this.MAIL = mail;
        }



        public string AD{ get; set; }
        public string SOYAD { get; set; }
        public string TEL { get; set; }
        public String MAIL { get; set; }


        public override string ToString()
        {
            return this.AD +" "+this.SOYAD+" "+this.TEL+" ";
        }
    }
}
