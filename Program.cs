using System;
using System.IO;
using System.Threading.Tasks;
using CronJob.Logging;
using CronJob.Services;
using Microsoft.Extensions.Configuration;

namespace CronJob
{
    class Program
    {
        private async static Task Main(string[] args)
        {
            LogProvider.SetCurrentLogProvider(new ConsoleLogProvider());
            
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var configuration = builder.Build();

            string cron = configuration.GetSection("Crons").GetSection("CincoSegundos").Value;

            await QuartzCrons.Execute(cron);

        }
    }

    class ConsoleLogProvider : ILogProvider
    {
        public Logger GetLogger(string name)
        {
            return (level, func, exception, parameters) =>
            {
                if (level >= LogLevel.Info && func != null)
                {
                    Console.WriteLine("[" + DateTime.Now.ToLongTimeString() + "] [" + level + "] " + func(), parameters);
                }
                return true;
            };
        }

        public IDisposable OpenMappedContext(string key, object value, bool destructure = false)
        {
            throw new NotImplementedException();
        }

        public IDisposable OpenNestedContext(string message)
        {
            throw new NotImplementedException();
        }
    }

}
