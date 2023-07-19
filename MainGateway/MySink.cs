using Serilog.Core;
using Serilog.Events;

namespace MainGateway
{
    public class MySink : ILogEventSink
    {
        private readonly IFormatProvider _formatProvider;

        public MySink(IFormatProvider formatProvider)
        {
            _formatProvider = formatProvider;
        }

        public void Emit(LogEvent logEvent)
        {
            var message = logEvent.RenderMessage(_formatProvider);
            Console.WriteLine(DateTimeOffset.Now.ToString() + " " + message);
            Console.WriteLine("dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd");
        }
    }
}
