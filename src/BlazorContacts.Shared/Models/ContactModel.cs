using System;

namespace BlazorContacts.Shared.Models
{
    public class ContactModel
    {
        public ContactModel()
        { }

        public ContactModel(ContactModel toCopy)
        {
            Id = toCopy.Id;
            Name = toCopy.Name;
            PhoneNumber = toCopy.PhoneNumber;
            City = toCopy.City;
            IsFavorite = toCopy.IsFavorite;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public bool IsFavorite { get; set; }

        public void Update(ContactModel model)
        {
            Id = model.Id;
            Name = model.Name;
            PhoneNumber = model.PhoneNumber;
            City = model.City;
            IsFavorite = model.IsFavorite;
        }
    }
}
