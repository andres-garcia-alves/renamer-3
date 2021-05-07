namespace Renamer.Engine
{
    public enum Operation
    {
        Unknown = 0,
        Rename = 1,
        Undo = 2
    }

    public enum RenameType
    {
        Unknown = 0,
        SentenceCase = 1,
        TitleCase = 2,
        UpperCase = 3,
        LowerCase = 4,
        InvertedCase = 5,
        BySimpleMatch = 6,
        ByPattern = 7,
        PositionalReplace = 8,
        PositionalAppend = 9,
        RemoveTildes = 10
    }

    public enum ObjectType
    {
        Unknown = 0,
        Directory = 1,
        File = 2
    }
}
