using Serilog.Configuration;
using Serilog;

namespace MainGateway
{
    public static class Extensions
    {
        public static LoggerConfiguration MySink(
              this LoggerSinkConfiguration loggerConfiguration,
              IFormatProvider formatProvider = null)
        {
            return loggerConfiguration.Sink(new MySink(formatProvider));
        }
    }
}
