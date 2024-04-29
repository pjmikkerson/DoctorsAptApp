using System.Text;

namespace DoctorsAptApp
{
    public class CreateApptPriorityQueue
    {
        private PriorityQueue<Patient, int> patients;
        private int count = 0;
        private static CreateApptPriorityQueue instance;

        public CreateApptPriorityQueue()
        {
            patients = new PriorityQueue<Patient, int>();
        }

        public void AddPatient(Patient patient)
        {
            patients.Enqueue(patient, (patient.Priority * -1));
            count++;
        }

        public static CreateApptPriorityQueue Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CreateApptPriorityQueue();
                }
                return instance;
            }
        }

        public Patient Dequeue()
        {
            if (patients.Count == 0)
            {
                return null;
            }
            count--;
            return patients.Dequeue();
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public IEnumerator<Patient> GetEnumerator()
        {
            foreach (var item in patients.UnorderedItems)
            {
                yield return item.Element;
            }
        }




        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Patient patient in this)
            {
                sb.AppendLine(patient.ToString());
            }
            return sb.ToString();
        }
    }
}
