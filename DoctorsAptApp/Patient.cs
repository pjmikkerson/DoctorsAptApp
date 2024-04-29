using System;

namespace DoctorsAptApp
{
    public class Patient
    {
        private string name;
        private int age;
        private bool insurance;
        private int severity = 1;
        private int priority;


        public string Name
        {
            get => name;
            set => name = (value != null) ? value : throw new ArgumentNullException(nameof(value), "Name cannot be null.");
        }
        public int Age
        {
            get => age;
            set => age = (value > 0) ? value : throw new ArgumentOutOfRangeException(nameof(value), "Age must be greater than 0.");
        }
        public bool Insurance
        {
            get => insurance;
            set
            {
                insurance = value;
                CalculatePriority();
            }
        }
        public int Severity
        {
            get => severity;
            set
            {
                severity = (value >= 1 && value <= 10) ? value : throw new ArgumentOutOfRangeException(nameof(value), "Severity must be between 1 and 10.");
                CalculatePriority();
            }
        }


        public int Priority
        {
            get => priority;
            set => priority = value;
        }

        

        public Patient()
        {
            name = "";
            age = 0;
            insurance = false;
        }



        public Patient(string name, int age, int severity, bool insurance = false)
        {

            Name = name;
            Age = age;
            Severity = severity;
            Insurance = insurance;
            CalculatePriority();
        }

        private void CalculatePriority()
        {
            priority = this.severity + (this.insurance ? 1 : 0);
        }
        
        

        public override string ToString()
        {
            return $"Name: {name}, Age: {age}, Severity: {severity}, Insurance: {insurance}, Priority: {priority}";
        }


    }
}
