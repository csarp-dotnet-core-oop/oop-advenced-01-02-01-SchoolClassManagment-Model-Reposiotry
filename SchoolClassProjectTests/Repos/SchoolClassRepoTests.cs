using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolClassProject.Repos;
using SchoolClassProject.Models;

namespace SchoolClassProject.Repos.Tests
{
    [TestClass()]
    public class SchoolClassRepoTests
    {
        [TestMethod()]
        public void AddTest()
        {
            // arrange: setup the class
            SchoolClassRepo repo = new SchoolClassRepo();
            // act: perform the action
            SchoolClass schoolClass = new SchoolClass(9, 'a', 1000);
            repo.Add(schoolClass);
            // assert
            Assert.AreEqual(1, repo.NumberOfSchoolClass, "Iskolai osztály hozzáadás sikertelen!");

            bool contain = (repo.SchoolClasses.Exists(schoolClass => schoolClass.SchoolYear == 9))
                           &&
                           (repo.SchoolClasses.Exists(schoolClass => schoolClass.SchoolClassId == 'a'));
            Assert.IsTrue(contain, "Iskolai osztály hozzáadása után nem található a hozzáadott osztály!");
        }
    }
}