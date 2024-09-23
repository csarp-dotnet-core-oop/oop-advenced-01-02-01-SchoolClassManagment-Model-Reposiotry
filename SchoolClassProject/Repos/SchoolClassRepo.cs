using SchoolClassProject.Models;

namespace SchoolClassProject.Repos
{
    public class SchoolClassRepo : ISchoolClassRepo
    {
        private List<SchoolClass> _schoolClasses;
        public SchoolClassRepo()
        {
            _schoolClasses = new List<SchoolClass>();
        }

        public int NumberOfSchoolClass => _schoolClasses.Count;

        public List<SchoolClass> SchoolClasses => _schoolClasses;

        public void Add(SchoolClass schoolClass)
        {
            _schoolClasses.Add(schoolClass);
        }

        public SchoolClassWithPublicData GetSchoolClass(int schoolClassYear, char schoolClassId)
        {
            return new SchoolClassWithPublicData();
        }

        public List<SchoolClassWithPublicData> GetSchoolClassPerYear(int schoolClassYear)
        {
            return new List<SchoolClassWithPublicData>();
        }

        public void Remove(SchoolClass schoolClass)
        {
            _schoolClasses.Remove(schoolClass);
        }

        public void Remove(int schoolYear, char schoolClassId)
        {
            // keresés
            SchoolClass? schoolClassToRemove = _schoolClasses.Find(schoolClass => schoolClass.SchoolYear == schoolYear && schoolClass.SchoolClassId == schoolClassId);
            if (schoolClassToRemove is not null) 
            {
                _schoolClasses.Remove(schoolClassToRemove);
            }
        }

        public void Update(int schoolYear, char schoolClassId, int newClassMoney)
        {
            SchoolClass? schoolClassToUpdate= _schoolClasses.Find(schoolClass => schoolClass.SchoolYear == schoolYear && schoolClass.SchoolClassId == schoolClassId);
            if (schoolClassToUpdate is not null)
            {
                schoolClassToUpdate.ClassMoney = newClassMoney;
            }
        }
    }
}
