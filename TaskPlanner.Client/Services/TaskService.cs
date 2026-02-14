using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using TaskPlanner.Client.Models;

namespace TaskPlanner.Client.Services
{
    public class TaskService
    {
        private readonly HttpClient _http;

        public TaskService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Categoria>> GetCategorias()
        {
            return await _http.GetFromJsonAsync<List<Categoria>>("api/categorias");
        }

        public async Task SaveCategorias(Categoria categoria)
        {
            await _http.PostAsJsonAsync("api/categorias", categoria);
        }

        public async Task<List<Tarea>> GetTareas()
        {
            return await _http.GetFromJsonAsync<List<Tarea>>("api/tareas");
        }

        public async Task SaveTarea(Tarea tarea)
        {
            await _http.PostAsJsonAsync("api/tareas", tarea);
        }

    }
}
