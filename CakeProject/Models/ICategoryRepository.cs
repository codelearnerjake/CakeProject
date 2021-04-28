using System.Collections.Generic;

namespace CakeProject.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
