using System.Text;

namespace DoctorsAptApp
{
    internal class ScheduleLinkedList
    {
        private LinkedList<Appointment> schedule = new();




        public void SchedulePatients(CreateApptPriorityQueue priorityQueue)
        {
            DateTime currentTime = DateTime.Now;
            

            // Round up to the next half hour if needed.
            if (currentTime.Minute > 0 && currentTime.Minute < 30)
                currentTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, currentTime.Hour, 30, 0);
            else if (currentTime.Minute > 30)
                currentTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, currentTime.Hour, 0, 0).AddHours(1);

            while (!priorityQueue.IsEmpty())
            {
                Patient patient = priorityQueue.Dequeue();
                DateTime lastAppointmentTime = schedule.Any() ? schedule.Last.Value.Time : currentTime;
                Appointment appointment = new Appointment(patient, GetNextAvailableAppointmentTime(lastAppointmentTime));
                schedule.AddLast(appointment);
            }
        }

        private DateTime GetNextAvailableAppointmentTime(DateTime lastAppointmentTime)
        {
            // Adjust the current time to the next available appointment time
            DateTime nextAppointmentTime = lastAppointmentTime.AddMinutes(30 - lastAppointmentTime.Minute % 30);


            if (nextAppointmentTime.Hour < 8 || nextAppointmentTime.Hour >= 16)
            {
                nextAppointmentTime = GetNextWeekdayAt8AM(nextAppointmentTime);
            }
            // If the next appointment time falls during the lunch break, adjust to after the lunch break
            else if (nextAppointmentTime.Hour == 12)
            {
                // If it's after 12:30 PM, add enough minutes to move to 1:00 PM or after
                if (nextAppointmentTime.Minute >= 30)
                {
                    nextAppointmentTime = new DateTime(nextAppointmentTime.Year, nextAppointmentTime.Month, nextAppointmentTime.Day, 13, 0, 0);
                }
                // If it's exactly 12:00 PM, just add one hour to move to 1:00 PM
                else
                {
                    nextAppointmentTime = nextAppointmentTime.AddHours(1);
                }
            }
            // No additional rounding is necessary here because we've already added 30 minutes to the last appointment time

            return nextAppointmentTime;
        }

        private DateTime GetNextWeekdayAt8AM(DateTime date)
        {
            // Get the next weekday (excluding Saturday and Sunday)
            do
            {
                date = date.AddDays(1);
            } while (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday);

            // Set the time to 8:00 AM
            return new DateTime(date.Year, date.Month, date.Day, 8, 0, 0);
        }

        public override string ToString()
        {
            // Generate a string representation of the schedule
            StringBuilder sb = new StringBuilder();

            foreach (Appointment appointment in schedule)
            {
                sb.AppendLine(appointment.ToString());
            }

            return sb.ToString();
        }
    }
}
