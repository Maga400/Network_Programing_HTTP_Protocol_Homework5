using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

Console.WriteLine("Hello, World!");


HttpClient client = new HttpClient();


HttpResponseMessage? response = await client.GetAsync("http://localhost:27003/?name=Hesen&age=25");

var text = await response.Content.ReadAsStringAsync();
Console.WriteLine(text);
