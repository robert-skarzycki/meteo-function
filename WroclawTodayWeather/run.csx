#r "Newtonsoft.Json"
#load "meteo-downloader.csx"

using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;

public static IActionResult Run(HttpRequest req, TraceWriter log)
{
    var downloader = new MeteoDownloader();
    downloader.GetMeteoImage().Wait();

    return (ActionResult)new OkObjectResult($"Helloasdasd_2");
}
