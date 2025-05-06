using Infrastructure.Context;
using Infrastructure.Repositories.Implementation;
using Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Infrastructure.Repositories.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly SICT_ShowCaseContext _context;
        public UnitOfWork(SICT_ShowCaseContext _ShowCaseContext)
        {
            _context = _ShowCaseContext;
            Users = new UserRepository(_context);
            Roles = new RoleRepository(_context);
            Categories = new CategoryRepository(_context);
            Products = new ProductRepository(_context);
            Tags = new TagRepository(_context);
            UploadFiles = new UploadFileRepository(_context);
            ProductTags = new ProductTagRepository(_context);
            ProductAuthors = new ProductAuthorRepository(_context);
            Authors = new AuthorRepository(_context);

        }
        public IUserRepository Users { get; }

        public IRoleRepository Roles { get; }

        public ICategoryRepository Categories { get; }

        public IProductRepository Products { get; }

        public ITagRepository Tags { get; }

        public IProductTagRepository ProductTags { get; }

        public IUploadFileRepository UploadFiles { get; }

        public IProductAuthorRepository ProductAuthors { get; }
        public IAuthorRepository Authors { get; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
