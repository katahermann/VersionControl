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
        public Patient()
        {

        }


        public int ID { get; set; }
        public int Kor { get; set; }
        public int Nem { get; set; }
        public int Kulfold { get; set;  }
        public int Erintkez { get; set;  }
        public int Tunet { get; set;  }
        public int Korlatoz { get; set; }
        public int Teszt { get; set; }
    }
}
