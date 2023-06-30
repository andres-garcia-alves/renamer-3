using Renamer.Engine.Helpers;

namespace Renamer.Engine.Entities
{
    internal sealed class RenameEngineValidator
    {
        readonly RenameType renameType;
        readonly List<string> parameters;
        readonly List<NamingRequest> namingRequests;

        public RenameEngineValidator(RenameType renameType, List<string> parameters, List<NamingRequest> namingRequests)
        {
            this.renameType = renameType;
            this.parameters = parameters;
            this.namingRequests = namingRequests;
        }

        /// <summary>
        /// Validates that a rename request is well-formed.
        /// </summary>
        /// <param name="renameType">Request renaming type.</param>
        /// <param name="parameters">Request parameters.</param>
        public void Validate()
        {
            try
            {
                if (namingRequests.Count == 0)
                    throw new ArgumentException("No files or directories selected.");

                switch (renameType)
                {
                    case RenameType.BySimpleMatch:      this.ValidateBySimpleMatch(); break;
                    case RenameType.ByPattern:          this.ValidateByPattern(); break;
                    case RenameType.PositionalReplace:  this.ValidatePositionalReplace(); break;
                    case RenameType.PositionalAppend:   this.ValidatePositionalAppend(); break;
                    case RenameType.Unknown:            throw new ArgumentException("No rename method selected.");
                }
            }
            catch (Exception) { throw; }
        }

        private void ValidateBySimpleMatch()
        {
            if (!this.parameters[0].IsValidFileName())
                throw new ArgumentException("The text match can't have any of following chars: \\ / : * ? \" < > |.");
            if (!this.parameters[1].IsValidFileName())
                throw new ArgumentException("The text replacement can't have any of following chars: \\ / : * ? \" < > |.");
        }

        private void ValidateByPattern()
        {
            if (!this.parameters[0].IsValidFileName())
                throw new ArgumentException("The text pattern can't have any of following chars: \\ / : * ? \" < > |.");
            if (!this.parameters[1].IsNumeric(true))
                throw new ArgumentException("Start index must be numeric.");
            if (!this.parameters[2].IsNumeric(false))
                throw new ArgumentException("Increment must be numeric greater than 0.");
            if (!this.parameters[3].IsNumeric(false))
                throw new ArgumentException("Numeric pad must be numeric greater than 0.");
        }

        private void ValidatePositionalReplace()
        {
            if (!this.parameters[0].IsNumeric(false))
                throw new ArgumentException("Position must be numeric greater than 0.");
            if (!this.parameters[1].IsValidFileName())
                throw new ArgumentException("The text replacement can't have any of following chars: \\ / : * ? \" < > |.");
        }

        private void ValidatePositionalAppend()
        {
            if (!this.parameters[0].IsNumeric(false))
                throw new ArgumentException("Position must be numeric greater than 0.");
            if (!this.parameters[1].IsValidFileName())
                throw new ArgumentException("The text to append can't have any of following chars: \\ / : * ? \" < > |.");
        }
    }
}
