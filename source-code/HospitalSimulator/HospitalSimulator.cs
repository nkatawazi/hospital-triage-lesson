using Newtonsoft.Json;

namespace HospitalSimulator
{
    public class HospitalSimulator
    {
        public List<Doctor> Doctors = new();

        public List<Patient> Patients = new();

        public void StartSimulation()
        {
            var doctors = JsonConvert.DeserializeObject<List<Doctor>>(File.ReadAllText(@"./Doctors.json"));
            var patients = JsonConvert.DeserializeObject<List<Patient>>(File.ReadAllText(@"./Patients.json"));

            if (doctors == null)
            {
                throw new Exception("No doctors for the simulator");
            }

            if (patients == null)
            {
                throw new Exception("No patients for the simulator");
            }

            this.Doctors = doctors;
            var timeOffset = 0;

            while (Patients.ToList().Any(x => !x.HasBeenSeen) || Patients.Count != patients.Count)
            {
                GeneratePatients(timeOffset, patients);

                var currentDateTime = new DateTimeOffset(2022, 12, 2, 9, 0, 0, TimeSpan.Zero).AddMinutes(timeOffset * 5);

                var availableDoctors = Doctors
                    .Where(x => x.CanSeePatient(currentDateTime))
                    .ToList();

                foreach (var doctor in availableDoctors)
                {
                    var nextPatientToSee = Patients
                        .Where(x => !x.HasBeenSeen)
                        .OrderBy(x => x.Severity)
                        .ThenBy(x => x.CheckinTime)
                        .FirstOrDefault();

                    if (nextPatientToSee != null)
                    {
                        doctor.HealPatient(nextPatientToSee, currentDateTime);
                    }
                }

                timeOffset++;
            }

            Console.ReadLine();
        }

        public void GeneratePatients(int timeOffset, List<Patient> patients)
        {
            var startDate = new DateTimeOffset(2022, 12, 2, 9, 0, 0, TimeSpan.Zero);
            var currentDate = startDate.AddMinutes(timeOffset * 5);

            var patientsToCheckin = patients
                .Where(x => x.CheckinTime <= currentDate && !this.Patients.Any(y => y.Id == x.Id))
                .ToList();
            
            this.Patients.AddRange(patientsToCheckin);

        }
    }
}
