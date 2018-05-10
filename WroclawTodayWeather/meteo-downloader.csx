using System.Net.Http;
public class MeteoDownloader
{
    static MeteoDownloader()
    {
        HttpClient = new HttpClient();
    }

    public async Task<byte[]> GetMeteoImage()
    {
        var dateString = GetTodayDateStringified();

        return await HttpClient.GetByteArrayAsync($"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&fdate={dateString}&row=436&col=181&lang=pl");
    }

    private string GetTodayDateStringified()
    {
        var date = DateTime.Now;
        var hourSuffix = GetHourSuffix(date);
        return $"{date.ToString("yyyyMMdd")}{hourSuffix}";
    }

    private string GetHourSuffix(DateTime date)
    {
        if (date.TimeOfDay.Hours >= 12)
        {
            return "12";
        }
        else
        {
            return "00";
        }
    }
}