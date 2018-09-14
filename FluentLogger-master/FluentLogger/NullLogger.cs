using System;

namespace FluentLogger
{
    public class NullLogger: BaseLogger
    {

        /// Initializes a new instance of the FluentLogger.NullLogger class.
        /// Parameter: LogLevel minLevel = LogLevel.Trace) : base(minLevel
        public NullLogger(LogLevel minLevel = LogLevel.Trace) : base(minLevel)
        {
        }


        /// For testing purposes only 
        /// Record the specified level, message, ex and objectsToSerialize.>
        public override void Record(LogLevel level, string message, Exception ex = null, params object[] objectsToSerialize)
        {
            //Do nothing.  For Testing only
        }
        
    }
}
