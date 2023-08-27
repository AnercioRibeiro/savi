using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.IRepository
{
    public interface IPublicationRepository
    {
        Task<Publication> GetPublicationByIdAsync(int id);
        Task<IReadOnlyList<Publication>> GetPublicationsAsync();
    }
}
