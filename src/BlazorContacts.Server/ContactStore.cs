using BlazorContacts.Shared.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace BlazorContacts.Server
{
    public class ContactsStore : IContactsStore
    {
        private static readonly IDictionary<Guid, ContactModel> _data
            = new ConcurrentDictionary<Guid, ContactModel>();

        static ContactsStore()
        {
            Guid id1 = Guid.NewGuid();
            _data[id1] = new ContactModel
            {
                City = "Novi Sad",
                IsFavorite = false,
                Id = id1,
                Name = "Stefa Stefanović",
                PhoneNumber = "065 010 012"
            };

            Guid id2 = Guid.NewGuid();
            _data[id2] = new ContactModel
            {
                City = "Novi Sad",
                IsFavorite = true,
                Id = id2,
                Name = "Perko Perković",
                PhoneNumber = "065 1111 222"
            };

            Guid id3 = Guid.NewGuid();
            _data[id3] = new ContactModel
            {
                City = "Zrenjanin",
                IsFavorite = false,
                Id = id3,
                Name = "Laki Lakić",
                PhoneNumber = "065 333 456"
            };

            Guid id4 = Guid.NewGuid();
            _data[id4] = new ContactModel
            {
                City = "Beograd",
                IsFavorite = true,
                Id = id4,
                Name = "Marko Marković",
                PhoneNumber = "065 444 000"
            };
        }

        public IEnumerable<ContactModel> GetAll() => _data.Select(x => x.Value);

        public ContactModel GetById(Guid id)
        {
            if (_data.TryGetValue(id, out var model))
            {
                return model;
            }
            return null;
        }

        public bool Remove(Guid id)
        {
            if (_data.Keys.Contains(id))
            {
                _data.Remove(id);
                return true;
            }
            return false;
        }

        public ContactModel Save(ContactModel model)
        {
            if (model.Id == default(Guid))
            {
                model.Id = Guid.NewGuid();
            }

            _data[model.Id] = model;
            return model;
        }

        public bool SetIsFavorite(Guid id, bool isFavorite)
        {
            if (_data.TryGetValue(id, out ContactModel model))
            {
                model.IsFavorite = isFavorite;
                return true;
            }
            return false;
        }

    }
}
