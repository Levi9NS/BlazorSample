using BlazorContacts.Shared.Models;
using Microsoft.AspNetCore.Blazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorContacts.Client.Services
{
    public class ContactsClientService
    {
        private const string ApiPath = "/api/contacts/";
        private readonly HttpClient _httpClient;

        public ContactsClientService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<List<ContactModel>> GetAllAsync()
        {
            string json = await _httpClient.GetStringAsync(ApiPath);
            return JsonUtil.Deserialize<ContactModel[]>(json).ToList();
        }

        public Task<ContactModel> GetByIdAsync(Guid id) => _httpClient.GetJsonAsync<ContactModel>(ApiPath + id);

        public async Task<ContactModel> Save(ContactModel model)
        {
            if (model != null)
            {
                if (model.Id == default) model.Id = Guid.NewGuid();

                await _httpClient.PostJsonAsync(ApiPath, model);
                return await GetByIdAsync(model.Id);
            }
            return null;
        }

        public Task SetIsFavorite(Guid id, bool isFavorite)
            => _httpClient.PostJsonAsync(ApiPath + id + $"?isFavorite={isFavorite}", new { });

        public Task Delete(Guid id)
            => _httpClient.DeleteAsync(ApiPath + id);
    }
}
