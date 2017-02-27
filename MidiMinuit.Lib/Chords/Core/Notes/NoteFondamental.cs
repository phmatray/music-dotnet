using GuitarChords.Lib.Enum;
using GuitarChords.Lib.Notes.Enum;

namespace GuitarChords.Lib.Notes
{
    public class NoteFondamental : NoteRole
    {
        public NoteFondamental(NoteName name = NoteName.C, NoteAccidental accidental = NoteAccidental.Natural)
            : base(name, accidental)
        {
        }

        public NoteFondamental(string note)
            : base(note)
        {
        }

        public NoteFondamental(Note note)
            : base(note)
        {
        }

        public override Role Role => Role.NoteFondamental;
        public override string RoleName => "Fondamental";
        public override string RoleAbbreviation => "Fond";
    }
}