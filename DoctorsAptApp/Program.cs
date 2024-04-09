namespace DoctorsAptApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arrays for generating random first and last names
            string[] firstNames = { "John", "Jane", "Mike", "Mary", "Steve", "Nancy", "Robert", "Lisa", "David", "Linda" };
            string[] lastNames = { "Smith", "Johnson", "Williams", "Brown", "Jones", "Miller", "Davis", "Garcia", "Rodriguez", "Wilson" };

            // Create a Random instance
            Random random = new Random();

            // Create and initialize 20 random patients
            Patient[] patients = new Patient[20];

            for (int i = 0; i < patients.Length; i++)
            {
                string fullName = firstNames[random.Next(firstNames.Length)] + " " + lastNames[random.Next(lastNames.Length)];
                int age = random.Next(18, 100); // Ages between 18 and 99
                int priority = random.Next(1, 11); // Priority levels between 1 and 10
                bool insurance = random.Next(2) == 1; // Randomly true or false

                patients[i] = new Patient(fullName, age, priority, insurance);
            }

            // Now you can use the 'patients' array as needed, for example, to add them to an appointment queue.
            CreateApptPriorityQueue apptQueue = new CreateApptPriorityQueue();
            foreach (var patient in patients)
            {
                apptQueue.AddPatient(patient);
            }

            ScheduleLinkedList schedule = new ScheduleLinkedList();
            schedule.SchedulePatients(apptQueue);

            Console.WriteLine(schedule.ToString());
            Patient[] morePatients = new Patient[5]; // Adding 5 more patients
            for (int i = 0; i < morePatients.Length; i++)
            {
                string fullName = firstNames[random.Next(firstNames.Length)] + " " + lastNames[random.Next(lastNames.Length)];
                int age = random.Next(18, 100); // Ages between 18 and 99
                int priority = random.Next(1, 11); // Priority levels between 1 and 10
                bool insurance = random.Next(2) == 1; // Randomly true or false

                morePatients[i] = new Patient(fullName, age, priority, insurance);
                apptQueue.AddPatient(morePatients[i]);
            }

            // Reschedule with the new patients added to the queue
            schedule.SchedulePatients(apptQueue);


            Console.WriteLine("Updated Schedule:");
            Console.WriteLine(schedule.ToString());

            // Optionally, print all patients, including the ones just added
            foreach (var patient in patients)
            {
                Console.WriteLine(patient.ToString());
            }
            foreach (var patient in morePatients)
            {
                Console.WriteLine(patient.ToString());
            }

        }
    }
}
