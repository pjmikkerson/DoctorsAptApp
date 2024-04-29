using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoctorsAptApp
{
    public class ScheduleLinkedList : IEnumerable<Appointment>
    {
        private LinkedList<Appointment> schedule = new LinkedList<Appointment>();
        public int Count => schedule.Count;




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
            
            System.DateTime nextAppointmentTime = lastAppointmentTime.AddMinutes(30 - lastAppointmentTime.Minute % 30);


            if (nextAppointmentTime.Hour < 8 || nextAppointmentTime.Hour >= 16)
            {
                nextAppointmentTime = GetNextWeekdayAt8AM(nextAppointmentTime);
            }
            
            else if (nextAppointmentTime.Hour == 12)
            {
                
                if (nextAppointmentTime.Minute >= 30)
                {
                    nextAppointmentTime = new DateTime(nextAppointmentTime.Year, nextAppointmentTime.Month, nextAppointmentTime.Day, 13, 0, 0);
                }
                
                else
                {
                    nextAppointmentTime = nextAppointmentTime.AddHours(1);
                }
            }
            

            return nextAppointmentTime;
        }

        private DateTime GetNextWeekdayAt8AM(DateTime date)
        {
            
            do
            {
                date = date.AddDays(1);
            } while (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday);

           
            return new DateTime(date.Year, date.Month, date.Day, 8, 0, 0);
        }


        public override string ToString()
        {
            
            StringBuilder sb = new StringBuilder();

            foreach (Appointment appointment in schedule)
            {
                sb.AppendLine(appointment.ToString());
            }

            return sb.ToString();
        }

        IEnumerator<Appointment> GetEnumerator()
        {
            foreach (var item in schedule)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator<Appointment> IEnumerable<Appointment>.GetEnumerator()
        {
            return ((IEnumerable<Appointment>)schedule).GetEnumerator();
        }
    }
}
