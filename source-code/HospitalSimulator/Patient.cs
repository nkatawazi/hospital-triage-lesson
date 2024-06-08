namespace HospitalSimulator
{
    public class Patient
    {
        public Patient(int id, string severity, DateTimeOffset checkinTime)
        {
            this.Id = id;
            this.Severity = severity;
            this.CheckinTime = checkinTime;
        }

        public int Id { get; set; }

        public string Severity { get; set; }

        public DateTimeOffset CheckinTime { get; set; }

        public bool HasBeenSeen { get; set; }
    }
}
