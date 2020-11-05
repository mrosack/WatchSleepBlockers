using CliWrap;
using CliWrap.Buffered;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WatchSleepBlockers
{
    public static class PowercfgRequestParser
    {
        public static async Task<string[]> GetActiveRequests()
        {
            var result = await Cli.Wrap("powercfg")
                .WithArguments("/requests")
                .ExecuteBufferedAsync();

            if (result.ExitCode != 0)
            {
                throw new InvalidOperationException("Call to powercfg failed: " + result.StandardError);
            }

            var lines = result.StandardOutput.Split(Environment.NewLine);
            var results = new List<string>();

            foreach (var line in lines)
            {
                if (line.StartsWith("["))
                {
                    results.Add(line);
                }
            }

            return results.ToArray();
        }
    }
}
