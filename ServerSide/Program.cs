using System.ComponentModel.DataAnnotations;
using System.Net;

Console.WriteLine("Hello, World!");

using HttpListener listener = new HttpListener();

listener.Prefixes.Add("http://127.0.0.1:27001/");
listener.Prefixes.Add("http://127.0.0.1:27002/");
listener.Prefixes.Add("http://localhost:27003/");

listener.Start();

while (true)
{
    var context = listener.GetContext();

    _ = Task.Run(() =>
    {
        HttpListenerRequest? request = context.Request;

        HttpListenerResponse? response = context.Response;
        response.ContentType = "text/html";
        response.Headers.Add("Content-Type", "text/html");
        response.Headers.Add("Server", "Step");
        response.Headers.Add("Date", DateTime.Now.ToString());

        var url = request.RawUrl;


        var urls = url?.Split('/').ToList();


        if (urls[1] == "Wikipedia")
        {
            Console.WriteLine(urls[2]);
            if (urls[2] == "car" || urls[2] == "car.html")
            {
                response.StatusCode = 200;
                using var writer = new StreamWriter(response.OutputStream);

                var index = File.ReadAllText("Wikipedia/car.html");
                writer.Write(index);
            }
            else if (urls[2] == "animal" || urls[2] == "animal.html")
            {
                response.StatusCode = 200;
                using var writer = new StreamWriter(response.OutputStream);

                var index = File.ReadAllText("Wikipedia/animal.html");
                writer.Write(index);
            }
            else if (urls[2] == "mobilphone" || urls[2] == "mobilphone.html")
            {
                response.StatusCode = 200;
                using var writer = new StreamWriter(response.OutputStream);

                var index = File.ReadAllText("Wikipedia/mobilphone.html");
                writer.Write(index);
            }
            else if (urls[2] == "bridge" || urls[2] == "bridge.html")
            {
                response.StatusCode = 200;
                using var writer = new StreamWriter(response.OutputStream);

                var index = File.ReadAllText("Wikipedia/bridge.html");
                writer.Write(index);
            }
            else if (urls[2] == "home" || urls[2] == "home.html")
            {
                response.StatusCode = 200;
                using var writer = new StreamWriter(response.OutputStream);

                var index = File.ReadAllText("Wikipedia/home.html");
                writer.Write(index);
            }
            else if (urls[2] == "instagram" || urls[2] == "instagram.html")
            {
                response.StatusCode = 200;
                using var writer = new StreamWriter(response.OutputStream);

                var index = File.ReadAllText("Wikipedia/instagram.html");
                writer.Write(index);
            }
            else if (urls[2] == "notebook" || urls[2] == "notebook.html")
            {
                response.StatusCode = 200;
                using var writer = new StreamWriter(response.OutputStream);

                var index = File.ReadAllText("Wikipedia/notebook.html");
                writer.Write(index);
            }
            else if (urls[2] == "pubg" || urls[2] == "pubg.html")
            {
                response.StatusCode = 200;
                using var writer = new StreamWriter(response.OutputStream);

                var index = File.ReadAllText("Wikipedia/pubg.html");
                writer.Write(index);
            }
            else if (urls[2] == "road" || urls[2] == "road.html")
            {
                response.StatusCode = 200;
                using var writer = new StreamWriter(response.OutputStream);

                var index = File.ReadAllText("Wikipedia/road.html");
                writer.Write(index);
            }
            else if (urls[2] == "youtube" || urls[2] == "youtube.html")
            {
                response.StatusCode = 200;
                using var writer = new StreamWriter(response.OutputStream);

                var index = File.ReadAllText("Wikipedia/youtube.html");
                writer.Write(index);
            }

            else
            {
                response.StatusCode = 404;
                
                using var writer = new StreamWriter(response.OutputStream);

                var index = File.ReadAllText("Wikipedia/404.html");
                writer.Write(index);
            }
        }
        else
        {
            response.StatusCode = 404;
            // Data Content
            using var writer = new StreamWriter(response.OutputStream);

            var index = File.ReadAllText("Wikipedia/404.html");
            writer.Write(index);
        }

    });

}

