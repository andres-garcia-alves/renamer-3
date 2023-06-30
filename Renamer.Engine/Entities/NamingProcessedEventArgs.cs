using System;

namespace Renamer.Engine.Entities
{
    public class NamingProcessedEventArgs : EventArgs
    {
        public Operation Operation { get; set; }
        public NamingResult NamingResult { get; set; }
        public int Progress { get; set; }

        public NamingProcessedEventArgs(Operation operation, NamingResult namingResult, int progress)
        {
            this.Operation = operation;
            this.NamingResult = namingResult;
            this.Progress = progress;
        }
    }
}
