using Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        IRoleRepository Roles { get; }
        ICategoryRepository Categories { get; }
        IProductRepository Products { get; }
        ITagRepository Tags { get; }
        IProductTagRepository ProductTags { get; }
        IUploadFileRepository UploadFiles { get; }
        IAuthorRepository Authors { get; }
        IProductAuthorRepository ProductAuthors { get; }

        IContactRepository Contacts { get; }
        Task<int> SaveChangeAsync();
    }
}
