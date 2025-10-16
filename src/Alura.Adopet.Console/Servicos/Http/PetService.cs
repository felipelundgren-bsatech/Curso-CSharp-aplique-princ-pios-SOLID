using System.Net.Http.Json;
using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos.Abstracoes;

namespace Alura.Adopet.Console.Servicos.Http;

public class PetService: IApiService<Modelos.Pet>
{
    private HttpClient client;

    public PetService(HttpClient client)
    {
        this.client = client;
    }

    public virtual Task CreateAsync(Modelos.Pet pet)
    {
        return client.PostAsJsonAsync("pet/add", pet);
    }

    public virtual async Task<IEnumerable<Modelos.Pet>?> ListAsync()
    {
        HttpResponseMessage response = await client.GetAsync("pet/list");
        return await response.Content.ReadFromJsonAsync<IEnumerable<Modelos.Pet>>();
    }
}
