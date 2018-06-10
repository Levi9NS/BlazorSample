using System;
using System.Collections.Generic;
using BlazorContacts.Shared.Models;

namespace BlazorContacts.Server
{
    public interface IContactsStore
    {
        IEnumerable<ContactModel> GetAll();
        ContactModel GetById(Guid id);
        bool Remove(Guid id);
        ContactModel Save(ContactModel model);
        bool SetIsFavorite(Guid id, bool isFavorite);
    }
}