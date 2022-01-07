using StackInternship.Data.Entities;
using StackInternship.Data.Entities.Models;
using StackInternship.Domain.Enums;
using System.Collections.Generic;
using System.Linq;

namespace StackInternship.Domain.Repositories
{
    public class ResourceRepository : RepositoryBase
    {
        public ResourceRepository(StackInternshipDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(Resource resource)
        {
            DbContext.Resources.Add(resource);

            return SaveChanges();
        }

        public ResponseResultType Edit(Resource resource, int resourceId)
        {
            var edittingResource = DbContext.Resources.Find(resourceId);
            if (edittingResource is null)
            {
                return ResponseResultType.NotFound;
            }

            edittingResource.Content = resource.Content;
            edittingResource.UpVote = resource.UpVote;
            edittingResource.DownVote = resource.DownVote;

            return SaveChanges();
        }

        public ResponseResultType Delete(int resourceId)
        {
            var deletingResource = DbContext.Resources.Find(resourceId);
            if (deletingResource is null)
            {
                return ResponseResultType.NotFound;
            }

            DbContext.Resources.Remove(deletingResource);

            return SaveChanges();
        }

        public ICollection<Resource> GetAll() => DbContext.Resources.ToList();
    }
}
