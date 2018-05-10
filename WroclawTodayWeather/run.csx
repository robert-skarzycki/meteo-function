#r "Newtonsoft.Json"
//#load "meteo-downloader.csx"

using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using System.Net.Http;

public static IActionResult Run(HttpRequest req, TraceWriter log)
{
    var downloader = new MeteoDownloader();
    var x = downloader.GetMeteoImage().Result;

    return (ActionResult)new OkObjectResult($"Helloasdasd_2{x?.Length}");
}

public static async Task<byte[]> GetMeteoImage()
{
    using (var client = new HttpClient())
    {
        return await client.GetByteArrayAsync($"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&fdate=2018051012&row=436&col=181&lang=pl");
    }
}
