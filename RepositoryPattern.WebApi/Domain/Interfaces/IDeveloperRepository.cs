using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IDeveloperRepository :IGenericRepository<Developer> 
    {
        IEnumerable<Developer> GetPopularDevelopers(int count);
    }
}
