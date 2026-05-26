using Microsoft.Extensions.Configuration;

namespace AutomationTestStoreFramework.Utilities;

public class ConfigReader
{
    private static IConfigurationRoot configuration;

    static ConfigReader()
    {
        configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
    }

    public static string GetSetting(string key)
    {
        return configuration[key];
    }
}