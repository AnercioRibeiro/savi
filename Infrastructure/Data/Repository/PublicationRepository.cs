using Core.Entities;
using Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repository
{
    public class PublicationRepository : IPublicationRepository
    {
        public Task<Publication> GetPublicationByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Publication>> GetPublicationsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
