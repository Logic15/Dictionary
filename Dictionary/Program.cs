Dictionary<string, string> countries = new Dictionary<string, string>();

countries.Add("UK", "London");
countries.Add("US", "Washington");
countries.Add("ČR", "Prague");

foreach (KeyValuePair<string, string> country in countries)
    Console.WriteLine($"{country.Key} : {country.Value}");
Console.ReadLine();