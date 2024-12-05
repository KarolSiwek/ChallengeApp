namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void EmployeeCollectScore()
        {
            //arrange 
            Employee employee1 = new Employee("Zbyszek", "Kieliszek", 30, 0);
            employee1.AddScore(5);
            employee1.AddScore(6);
            employee1.AddScore(7);
            employee1.AddScore(2);

            //act
            var result = employee1.Result;

            //assert
            Assert.AreEqual(20, result);

        }

        [Test]
        public void EmployeeCollectNegativeScore()
        {
            //arrange
            Employee employee2 = new Employee("Anka", "Szklanka", 31, 0);
            employee2.AddScore(-4);
            employee2.AddScore(-2);
            employee2.AddScore(-8);
            employee2.AddScore(-5);

            //act
            var result = employee2.Result;

            //assert
            Assert.AreEqual(-19, result);
        }

        [Test]

        public void EmployeeCollectMixedScore()
        {
            //arrange
            Employee employee3 = new Employee("Mietek", "Podnietek", 29, 0);
            employee3.AddScore(-4);
            employee3.AddScore(2);
            employee3.AddScore(-2);
            employee3.AddScore(8);

            //act
            var result = employee3.Result;

            //assert
            Assert.AreEqual(4, result);

        }
    }
}