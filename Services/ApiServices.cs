using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace website.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<List<Item>> GetAllItems()
        {
            var response = await _httpClient.GetAsync("api/items");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<Item>>();
        }

        public async Task<Item> GetItemById(int id)
        {
            var response = await _httpClient.GetAsync($"api/items/{id}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Item>();
        }

        public async Task<Item> CreateItem(Item item)
        {
            var response = await _httpClient.PostAsJsonAsync("api/items", item);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Item>();
        }

        public async Task<Item> UpdateItem(int id, Item item)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/items/{id}", item);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Item>();
        }

        public async Task DeleteItem(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/items/{id}");
            response.EnsureSuccessStatusCode();
        }
    }

    public class Item
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
