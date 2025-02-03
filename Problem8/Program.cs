using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

public class Country
{
    public object Name { get; set; } 
    public string Region { get; set; }
    public string Subregion { get; set; }
    public double[] Latlng { get; set; }
    public double? Area { get; set; }
    public int? Population { get; set; }
}

class Program
{
    static async Task Main(string[] args)
    {
       await GenerateCountryDataFiles();
    }
    public async static ValueTask GenerateCountryDataFiles()
    {

        var url = "https://restcountries.com/v3.1/all";

        using (var client = new HttpClient())
        {

            var response = await client.GetStringAsync(url);

            //ubralod mainshi mewera yvelaferi gadavitne failshi mititebul funciashi
            //Console.WriteLine("Raw response:\n" + response);

            var countries = JsonConvert.DeserializeObject<Country[]>(response);

            foreach (var country in countries)
            {

                string countryName = GetCountryName(country.Name);

                var fileName = $"{countryName.Replace(" ", "_")}.txt";


                var filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);

                var content = $"Region: {country.Region}\n" +
                             $"Subregion: {country.Subregion}\n" +
                             $"Latitude and Longitude: {string.Join(", ", country.Latlng ?? new double[] { })}\n" +
                             $"Area: {(country.Area.HasValue ? country.Area.Value + " km²" : "N/A")}\n" +
                             $"Population: {(country.Population.HasValue ? country.Population.Value.ToString() : "N/A")}\n";


                await File.WriteAllTextAsync(filePath, content);

                Console.WriteLine($"Created file: {fileName}");
            }
        }


    }
    static string GetCountryName(object name)
    {
        if (name is string)
        {
            return (string)name;
        }
        else if (name is JObject nameDict)
        { 
            var commonName = nameDict["common"];
            return commonName?.ToString() ?? "Unknown";
        }
        return "Unknown";
    }
}

