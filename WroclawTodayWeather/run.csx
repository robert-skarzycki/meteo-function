#r "Newtonsoft.Json"

using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;

public static IActionResult Run(HttpRequest req, TraceWriter log)
{
    var downloader = new MeteoDownloader();
    var x = downloader.GetMeteoImage().Result;

    return (ActionResult)new OkObjectResult($"Helloasdasd_2");
}
