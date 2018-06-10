using BlazorContacts.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorContacts.Server.Controllers
{
    [Route("/api/[controller]")]
    public class ContactsController
    {
        private readonly IContactsStore _store;

        public ContactsController(IContactsStore store)
        {
            _store = store ?? throw new ArgumentNullException(nameof(store));
        }

        [HttpGet]
        public IEnumerable<ContactModel> GetAll() => _store.GetAll();

        [HttpGet("/api/[controller]/{id}")]
        public ContactModel GetById(Guid id) => _store.GetById(id);

        [HttpDelete("/api/[controller]/{id}")]
        public bool Remove(Guid id) => _store.Remove(id);

        [HttpPost("/api/[controller]")]
        public ContactModel Save([FromBody]ContactModel model) => _store.Save(model);

        [HttpPost("/api/[controller]/{id}")]
        public bool SetIsFavorite(Guid id, [FromQuery]bool isFavorite) => _store.SetIsFavorite(id, isFavorite);
    }
}
