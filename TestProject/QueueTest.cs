using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DoctorsAptApp;


namespace TestProject
{
    public class QueueTest
    {
        [Fact]
        public void AddPatient_PatientAdded_Success()
        {
            // Arrange
            var queue = new CreateApptPriorityQueue();
            var patient = new Patient("Johnny Quest", 40, 10);

            // Act
            queue.AddPatient(patient);

            // Assert
            Assert.False(queue.IsEmpty());
        }



        [Fact]
        public void Dequeue_EmptyQueue_ReturnsNull()
        {
            // Arrange
            var queue = new CreateApptPriorityQueue();

            // Act
            var dequeuedPatient = queue.Dequeue();

            // Assert
            Assert.Null(dequeuedPatient);
        }

        [Fact]
        public void Dequeue_NonEmptyQueue_ReturnsPatient()
        {
            // Arrange
            var queue = new CreateApptPriorityQueue();
            var patient = new Patient("Johhny Quest", 40, 10);
            queue.AddPatient(patient);

            // Act
            var dequeuedPatient = queue.Dequeue();

            // Assert
            Assert.NotNull(dequeuedPatient);
            Assert.Equal(patient, dequeuedPatient);
        }
    }
}