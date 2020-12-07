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
            Patients = new LinkedList<Patient>();
            LoadData();
        }


        public LinkedList<Patient> Patients;
        public int lastID { get; set; }


        private void LoadData()
        {
            Patients.Clear();
            using (StreamReader sr = new StreamReader("Patients.csv", Encoding.Default))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(';');
                    Patients.AddLast(new Patient(int.Parse(line[0]), int.Parse(line[1]), int.Parse(line[2]), int.Parse(line[3]), int.Parse(line[4]), int.Parse(line[5]), int.Parse(line[6]), int.Parse(line[7])));
                }
            }
            lastID = Patients.Last.Value.ID;
        }
        public void AddData(Patient pat)
        {
            pat.ID = ++lastID;
            Patients.AddLast(pat);
            string newFileName = "Patients.csv";
            string patientDetails = $"{pat.ID};{pat.Kor};{pat.Nem};{pat.Kulfold};{pat.Erintkez};{pat.Tunet};{pat.Korlatoz};{pat.Teszt};{Environment.NewLine}";
            File.AppendAllText(newFileName, patientDetails);
        }

    }
}