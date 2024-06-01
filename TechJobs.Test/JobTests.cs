
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
    }
}

