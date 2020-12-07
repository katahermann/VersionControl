using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19
{
    public class Patient
    {
        public Patient(int kor, int nem, int kulfold, int erintkez, int tunet, int korlatoz, int teszt)
        {
            this.Kor = kor;
            this.Nem = nem;
            this.Kulfold = kulfold;
            this.Erintkez = erintkez;
            this.Tunet = tunet;
            this.Korlatoz = korlatoz;
            this.Teszt = teszt;
        }

        public Patient(int id, int kor, int nem, int kulfold, int erintkez, int tunet, int korlatoz, int teszt)
        {
            this.ID = id;
            this.Kor = kor;
            this.Nem = nem;
            this.Kulfold = kulfold;
            this.Erintkez = erintkez;
            this.Tunet = tunet;
            this.Korlatoz = korlatoz;
            this.Teszt = teszt;
        }


        public int ID { get; set; }
        public int Kor { get; }
        public int Nem { get;}
        public int Kulfold { get; }
        public int Erintkez { get; }
        public int Tunet { get; }
        public int Korlatoz { get; }
        public int Teszt { get; }
    }
}
