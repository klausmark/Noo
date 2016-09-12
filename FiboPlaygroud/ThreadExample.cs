using System.Threading;
using System.Threading.Tasks;

namespace FiboPlaygroud
{
    public class ThreadExample
    {
        private readonly ILogger _logger;

        public ThreadExample(ILogger logger)
        {
            _logger = logger;
        }

        public void Go(int workerNumber)
        {
            _logger.WriteLine($"Worker - Start: {workerNumber}");
            Thread.Sleep(5000);
            _logger.WriteLine($"Worker - End: {workerNumber}");
        }

        public static void RunThreadExample(int withThisNumberOfThreads, ILogger logger)
        {
            for (var i = 0; i < withThisNumberOfThreads; i++)
            {
                var workerNumber = i;
                Task.Run(() => new ThreadExample(logger).Go(workerNumber));
            }
        }

    }
}