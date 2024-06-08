namespace HospitalSimulator
{
    public class Doctor
    {
        public Doctor(int id)
        {
            this.Id = id;
        }

        public int Id { get; set; }

        public DateTimeOffset NextAvailability { get; set; }

        public void HealPatient(Patient patient, DateTimeOffset currentTime)
        {
            var timeToHeal = 0;

            switch (patient.Severity)
            {
                case "A":
                    timeToHeal = 30;
                    break;
                case "B":
                    timeToHeal = 15;
                    break;
                case "C":
                    timeToHeal = 10;
                    break;
            }

            this.NextAvailability = currentTime.AddMinutes(timeToHeal);
            patient.HasBeenSeen = true;

            Console.WriteLine($"Doctor {this.Id} begins treating Patient {patient.Id} at {currentTime:t} until {NextAvailability:t}");
        }

        public bool CanSeePatient(DateTimeOffset currentTime)
        {
            return this.NextAvailability <= currentTime;
        }
    }
}
