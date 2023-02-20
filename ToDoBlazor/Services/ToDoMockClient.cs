using ToDoBlazor.Shared.Entities;

namespace ToDoBlazor.Services
{
    public class ToDoMockClient //: IToDoClient
    {
        private readonly HttpClient httpClient;

        public ToDoMockClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public override bool Equals(object? obj)
        {
            return obj is ToDoMockClient client &&
                   EqualityComparer<HttpClient>.Default.Equals(httpClient, client.httpClient);
        }

        public async Task<IEnumerable<Item>> GetAsync()
        {
            return new List<Item>()
            {
                new Item()
                {
                    Text = "Banan"
                },
                new Item()
                {
                    Text = "Apelsin"
                },
                new Item()
                {
                    Text = "Mjölk",
                    Completed = true
                },
                new Item()
                {
                    Text = "Bröd"
                }
            };
        }
    }
}
