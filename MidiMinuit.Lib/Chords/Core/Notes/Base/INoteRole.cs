using MidiMinuit.Lib.Chords.Tools.Enum;

namespace MidiMinuit.Lib.Chords.Core.Notes.Base
{
    internal interface INoteRole
    {
        Role Role { get; }

        string RoleName { get; }

        string RoleAbbreviation { get; }
    }
}