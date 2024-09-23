using SchoolClassProject.Models;

namespace SchoolClassProject.Repos
{
    public interface ISchoolClassRepo
    {
        int NumberOfSchoolClass { get; }
        List<SchoolClass> SchoolClasses { get; }
        void Add(SchoolClass schoolClass);
        void Remove(SchoolClass schoolClass);
        void Remove(int schoolYear, char schoolClassId);
        void Update(int schoolYear, char schoolClassId, int newClassMoney);        
        List<SchoolClassWithPublicData> GetSchoolClassPerYear(int schoolClassYear);
        SchoolClassWithPublicData GetSchoolClass(int schoolClassYear, char schoolClassId);

    }
}
