using System.Net.Http.Headers;
namespace Urlscan;

class Program {

    private static HttpClient? http;

    void Main() {

    }

    private static void InitiateHttpClient() {
        http = new HttpClient() {
            Timeout = TimeSpan.FromSeconds(20)
        };

        http.DefaultRequestHeaders.Accept.Clear();
        http.DefaultRequestHeaders.Accept.Add(item: new MediaTypeWithQualityHeaderValue("application/json"));
        http.DefaultRequestHeaders.Add(name: "User-Agent", value: "UrlScan-Cli/1.0.0");
    }

}