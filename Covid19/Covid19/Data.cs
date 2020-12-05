using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Covid19
{
    class Data
    {
        public Data()
        {
            LoadData();
        }
        public LinkedList<Patient> Patients;
        private void LoadData()
        {
            Patients.Clear();
            using (StreamReader sr = new StreamReader("Patients.csv", Encoding.Default))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(';');
                    Patients.AddLast(new Patient(int.Parse(line[0]), int.Parse(line[1]), bool.Parse(line[2]), bool.Parse(line[3]), bool.Parse(line[4]), bool.Parse(line[5]), bool.Parse(line[6]), bool.Parse(line[7])));
                }
            }
        }
    }
}