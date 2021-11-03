using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Persistance
{
    public class FileContext : IAdultData
        
    {
        private readonly string adultsFile = "adults.json";
        private readonly string familiesFile = "families.json";
        public IList<Adult> Adults { get; private set; }
        public IList<Family> Families { get; private set; }

        public FileContext()
        {

            Adults = File.Exists(adultsFile) ? ReadData<Adult>(adultsFile) : new List<Adult>();
            Families = File.Exists(familiesFile) ? ReadData<Family>(familiesFile) : new List<Family>();
        }



        private IList<T> ReadData<T>(string s)
        {
            using (var jsonReader = File.OpenText(s))
            {
                return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
            }
        }

        public void SaveChanges()
        {

            var jsonAdults = JsonSerializer.Serialize(Adults, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            using (var outputFile = new StreamWriter(adultsFile, false))
            {
                outputFile.Write(jsonAdults);
            }
            
        }

        public Task<Adult> AddAdult(Adult adult)
        {
            int max = Adults.Max(adult => adult.Id);
            adult.Id = (++max);
            Adults.Add(adult);
            SaveChanges();
            return null;    
        }

        public IList<Adult> getAdults()
        {
            IList<Adult> tmp = new List<Adult>(Adults);
            return tmp;
        }
        

        public Adult Get(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
