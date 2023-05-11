using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repository.Entities
{
    public class CoronaDetails
    {
        public int Id { get; set; }
        public DateTime? FirstVaccination { get; set; }
        public DateTime? SecondVaccination { get; set; }
        public DateTime? ThreeVaccination { get; set; }
        public DateTime? FourthVaccination { get; set; }
        public string FirstProducer { get; set; }
        public string SecondProducer { get; set; }
        public string ThreeProducer { get; set; }
        public string FourthProducer { get; set; }
        public DateTime? DateOfPositiveResult { get; set; }
        public DateTime? DateOfRecovery { get; set; }

        public CoronaDetails(int id, DateTime? firstVaccination, DateTime? secondVaccination, DateTime? threeVaccination,
            DateTime? fourthVaccination, string firstProducer, string secondProducer, string threeProducer,
            string fourthProducer, DateTime? dateOfPositiveResult, DateTime? dateOfRecovery)
        {
            Id = id;
            FirstVaccination = firstVaccination;
            SecondVaccination = secondVaccination;
            ThreeVaccination = threeVaccination;
            FourthVaccination = fourthVaccination;
            FirstProducer = firstProducer;
            SecondProducer = secondProducer;
            ThreeProducer = threeProducer;
            FourthProducer = fourthProducer;
            DateOfPositiveResult = dateOfPositiveResult;
            DateOfRecovery = dateOfRecovery;
        }
    }
}
