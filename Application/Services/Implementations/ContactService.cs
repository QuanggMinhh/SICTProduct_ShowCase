using Application.Services.Interfaces;
using Azure;
using Domain.Entities;
using Infrastructure.Repositories.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations
{
    public class ContactService : IContactService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ContactService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task AddContactAsync(Contact contact)
        {
            await _unitOfWork.Contacts.AddAsync(contact);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task DeleteContactAsync(int id)
        {
            var contact = await _unitOfWork.Contacts.GetByIdAsync(id);
            if (contact != null)
            {
                await _unitOfWork.Contacts.Delete(contact);
                await _unitOfWork.SaveChangeAsync();

            }
        }

        public async Task<IEnumerable<Contact>> GetAllContactAsync()
        {
            return await _unitOfWork.Contacts.GetAllAsync();    
        }

        public async Task<Contact> GetContactByIdAsync(int id)
        {
            return await _unitOfWork.Contacts.GetByIdAsync(id);
        }

        public async Task UpdateContactAsync(Contact contact)
        {
            contact.UpdatedAt = DateTime.Now;
            await _unitOfWork.Contacts.Update(contact);
            await _unitOfWork.SaveChangeAsync();
        }
    }
}
