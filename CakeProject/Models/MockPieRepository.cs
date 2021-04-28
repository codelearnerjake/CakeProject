using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeProject.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Pie> AllPies => 
            new List<Pie>
            {
                new Pie {PieId =1, Name="Pumpkin Pie", Price=12.95M }
            };

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(predicate => predicate.PieId == pieId);
        }
    }
}
