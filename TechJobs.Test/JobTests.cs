
namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        //Testing Objects
        //initalize your testing objects here
        //Testing objects
        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        [TestMethod]
        public void TestSettingJobId() 
        {
            Assert.AreNotEqual(job1.Id, job2.Id);
            Assert.IsTrue(job1.Id - job2.Id == -1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual(job3.Name, "Product tester");
            Assert.AreEqual(job3.EmployerName.Value, "ACME");
            Assert.AreEqual(job3.EmployerLocation.Value, "Desert");
            Assert.AreEqual(job3.JobType.Value, "Quality control");
            Assert.AreEqual(job3.JobCoreCompetency.Value, "Persistence");
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job3.Equals(job4));
        }

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            string jobString = job3.ToString();

            Assert.IsTrue(jobString.Substring(0,4).Contains(Environment.NewLine));
            Assert.IsTrue(jobString.Substring(jobString.Length - 4, 4).Contains(Environment.NewLine));
            
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            string jobString = job3.ToString();

            Assert.IsTrue(jobString.Contains("ID: "));
            Assert.IsTrue(jobString.Contains("Name: "));
            Assert.IsTrue(jobString.Contains("Employer: "));
            Assert.IsTrue(jobString.Contains("Location: "));
            Assert.IsTrue(jobString.Contains("Position Type: "));
            Assert.IsTrue(jobString.Contains("Core Competency: "));
        }

        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {   
            string jobString2 = job1.ToString();
            
            Assert.IsTrue(jobString2.Contains("Name: Data not available"));
            Assert.IsTrue(jobString2.Contains("Employer: Data not available"));
            Assert.IsTrue(jobString2.Contains("Location: Data not available"));
            Assert.IsTrue(jobString2.Contains("Position Type: Data not available"));
            Assert.IsTrue(jobString2.Contains("Core Competency: Data not available"));
        }
    }
}

