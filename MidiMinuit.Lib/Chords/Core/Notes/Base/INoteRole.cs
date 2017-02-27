using GuitarChords.Lib.Enum;

namespace GuitarChords.Lib.Notes
{
    internal interface INoteRole
    {
        Role Role { get; }
        string RoleName { get; }
        string RoleAbbreviation { get; }
    }
}