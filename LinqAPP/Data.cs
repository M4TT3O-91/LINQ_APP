
using System.Linq;
using LinqLibrary;

namespace LinqAPP
{
    public class Data
    {
        private readonly List<Person> BaseData;

        public Data()
        {
            BaseData = new List<Person>();
        }

        public void Add(Person p)
        {
            BaseData.Add(p);
        }

        public List<Person> Search(string surname, string name)
        {
            var listOutput = new List<Person>();
            foreach (var p in BaseData) 
            {
                if (p.Name.Equals(name) && p.SurnaName.Equals(surname))
                {
                    listOutput.Add(p);
                }
            }

            return listOutput;
        }

        public List<Person> SearchByLinq(string surname, string name)
        {
           return BaseData.
                Where(p => 
                p.Name.Equals(name) && 
                p.SurnaName.Equals(surname)).ToList();
        }  
        
        public Person? SearchFirstByLinq(string surname, string name)
        {
           return BaseData.
                FirstOrDefault(p => 
                p.Name.Equals(name) && 
                p.SurnaName.Equals(surname)); 
        }

        public List<Person> OrderByDate()
        {
            return BaseData.OrderBy(p => p.BirthDate).ToList();
        }

        public List<string> GetAllSurname()
        {
            return BaseData.Select(p => p.SurnaName).ToList();
        }

        public string GetAllCompleteNameFirst(string surname)
        {
            var res = BaseData.FirstOrDefault(p => p.SurnaName.Equals(surname));
            return res == null ? string.Empty : res.CompletaName();
        }
        public List<string> GetAllCompleteName()
        {
            return BaseData.Select(p => p.CompletaName()).ToList();
        }
    }
}
