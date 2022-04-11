using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace task_26
{
    class Program
    {
        public static void Main()
        {
            IList<Doctor> DocData = new List<Doctor>()
            {
               new Doctor(){DocId=1 , DoctorName="ANAND",Age =25, SpecID = 2},
                new Doctor(){DocId= 2, DoctorName="SIDDHARTH",Age =27, SpecID = 1},
                new Doctor(){DocId= 3, DoctorName="JOHN ",Age =23, SpecID = 3},
                new Doctor(){DocId= 4, DoctorName="HARIS",Age =22, SpecID = 3},
                new Doctor(){DocId= 5, DoctorName="GIRI",Age =26, SpecID = 1},
                new Doctor(){DocId= 6, DoctorName="KOUSHIK ",Age =24, SpecID = 2},
                new Doctor(){DocId= 7, DoctorName="BALAJI",Age =35, SpecID = 4},
                new Doctor(){DocId= 8, DoctorName="SURYA",Age =21, SpecID = 4}
            };
            IList<Specialisation> SpecData = new List<Specialisation>()
            {
                new Specialisation() {SpecID= 1, SpecialisatinName="GeneralSurgeon"},
                new Specialisation() {SpecID= 2, SpecialisatinName="Nuero Surgeon"},
                new Specialisation() {SpecID= 3, SpecialisatinName="Multispecialist"},
                new Specialisation() {SpecID= 4, SpecialisatinName="Physiotherapist"},
                
            };
            var JoinData = DocData.Join(
              SpecData,
              stud => stud.SpecID,
              doc => doc.SpecID,
              (stud, doc) => new
              {
                  DocName = stud.DoctorName,
                  specName = doc.SpecialisatinName
              }
                  );
            foreach (var item in JoinData)
            {
                Console.WriteLine( item.DocName +  item.specName );
            }




        }
    }
    public class Specialisation
    {
        public int SpecID { get; set; }
        public string SpecialisatinName { get; set; }

    }
    class Doctor
    {
        public int DocId { get; set; }
        public string DoctorName { get; set; }
        public int Age { get; set; }
        public int SpecID { get; set; }
    }
}