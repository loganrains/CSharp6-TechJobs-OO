using System;
namespace TechJobsOOAutoGraded6
{
	public class Job
	{
            public int Id { get; }
            private static int nextId = 1;
            public string Name { get; set; }
            public Employer EmployerName { get; set; }
            public Location EmployerLocation { get; set; }
            public PositionType JobType { get; set; }
            public CoreCompetency JobCoreCompetency { get; set; }

            // TODONE: Task 3: Add the two necessary constructors.
            public Job()
            {
                Id = nextId;
                nextId++;
            }
            public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
            {
                Name = name;
                EmployerName = employerName;
                EmployerLocation = employerLocation;
                JobType = jobType;
                JobCoreCompetency = jobCoreCompetency;
            }


            // TODONE: Task 3: Generate Equals() and GetHashCode() methods.  
            public override bool Equals(object obj)
            {
                return obj is Job job &&
                Id == job.Id;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Id);
            }

        // TODO: Task 5: Generate custom ToString() method.
        public override string ToString()
        {
            string returnString = Environment.NewLine + "ID: " + Id;
            
            if (Name == null)
            {
                returnString = $"{returnString}{Environment.NewLine}Name: Data not available";
            }
            else
            {
                returnString = $"{returnString}{Environment.NewLine}Name: " + Name;
            }

            if (EmployerName == null || EmployerName.Value == "")
            {
                returnString = $"{returnString}{Environment.NewLine}Employer: Data not available";
            }
            else
            {
                returnString = $"{returnString}{Environment.NewLine}Employer: " + EmployerName;
            }

            if (EmployerLocation == null || EmployerLocation.Value == "")
            {
                returnString = $"{returnString}{Environment.NewLine}Location: Data not available";
            }
            else
            {
                returnString = $"{returnString}{Environment.NewLine}Location: " + EmployerLocation;
            }

            if (JobType == null || JobType.Value == "")
            {
                returnString = $"{returnString}{Environment.NewLine}Position Type: Data not available";
            }
            else
            {
                returnString = $"{returnString}{Environment.NewLine}Position Type: " + JobType;
            }

            if (JobCoreCompetency == null || JobCoreCompetency.Value == "")
            {
                returnString = $"{returnString}{Environment.NewLine}Core Competency: Data not available";
            }
            else
            {
                returnString = $"{returnString}{Environment.NewLine}Core Competency: " + JobCoreCompetency;
            }
            
            return returnString + Environment.NewLine;

        }
    }
}

