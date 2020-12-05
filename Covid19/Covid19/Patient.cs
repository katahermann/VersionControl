using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19
{
    class Patient
    {
        public Patient(int id, bool nem, bool kulfold, bool erintkez, bool tunet, bool korlatoz, bool teszt)
        {
            this.ID = id;
            this.Nem = nem;
            this.Kulfold = kulfold;
            this.Erintkez = erintkez;
            this.Tunet = tunet;
            this.Korlatoz = korlatoz;
            this.Teszt = teszt;
        }
        public int ID { get; }
        public bool Nem { get;}
        public bool Kulfold { get; }
        public bool Erintkez { get; }
        public bool Tunet { get; }
        public bool Korlatoz { get; }
        public bool Teszt { get; }
    }
}
