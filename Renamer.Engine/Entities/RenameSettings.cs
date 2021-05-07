using System;
using System.Collections.Generic;

namespace Renamer.Engine.Entities
{
    public class RenameSettings
    {
        public RenameType RenameType { get; }
        public List<string> Parameters { get; }
        public bool IncludeExtension { get; }

        public RenameSettings(RenameType renameType, List<string> parameters, bool includeExtension = false)
        {
            // if (parameters == null) { throw new ArgumentNullException(nameof(parameters)); }

            this.RenameType = renameType;
            this.Parameters = parameters;
            this.IncludeExtension = includeExtension;
        }
    }
}
