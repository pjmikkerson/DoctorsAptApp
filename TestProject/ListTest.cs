using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DoctorsAptApp;

namespace TestProject
{
    public class ListTest
    {

        [Fact]
        public void SchedulePatients_EmptyQueue_ScheduleIsEmpty()
        {
            // Arrange
            var schedule = new ScheduleLinkedList();
            var priorityQueue = new CreateApptPriorityQueue();

            // Act
            schedule.SchedulePatients(priorityQueue);

            // Assert
            Assert.Equal(0, schedule.Count);
        }

        [Fact]
        public void SchedulePatients_WithPatients_ScheduleIsNotEmpty()
        {
            // Arrange
            var schedule = new ScheduleLinkedList();
            var priorityQueue = new CreateApptPriorityQueue();
            var patient1 = new Patient("John Doe", 30, 3);
            var patient2 = new Patient("Jane Smith", 25, 2);
            priorityQueue.AddPatient(patient1);
            priorityQueue.AddPatient(patient2);

            // Act
            schedule.SchedulePatients(priorityQueue);

            // Assert
            Assert.False(schedule.Count == 0);
        }

       
    }
}
