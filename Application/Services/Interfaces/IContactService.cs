using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IContactService
    {
        Task<IEnumerable<Contact>> GetAllContactAsync();
        Task<Contact> GetContactByIdAsync(int id);
        Task AddContactAsync(Contact contact);
        Task DeleteContactAsync(int id);
        Task UpdateContactAsync(Contact contact);
    }
}
