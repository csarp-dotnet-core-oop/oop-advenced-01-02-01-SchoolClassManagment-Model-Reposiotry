namespace SchoolClassProject.Models
{
    public class SchoolClass
    {
        private int _schoolYear;
        private char _schoolClassId;
        private int _classMoney;

        public SchoolClass()
        {
            _schoolYear = 0;
            _schoolClassId = 'x';
            _classMoney = -1;
        }

        public SchoolClass(int schoolYear, char schoolClassId, int classMoney)
        {
            _schoolYear = schoolYear;
            _schoolClassId = schoolClassId;
            _classMoney = classMoney;
        }

        public int SchoolYear { get => _schoolYear; set => _schoolYear = value; }
        public char SchoolClassId { get => _schoolClassId; set => _schoolClassId = value; }
        public int ClassMoney { get => _classMoney; set => _classMoney = value; }
        public string ClassName => $"{_schoolYear}.{_schoolClassId}"; // csak gettelhető

        public override string ToString()
        {
            return $"{_schoolYear}. {_schoolClassId} ({_classMoney} Ft)";
        }
    }
}
