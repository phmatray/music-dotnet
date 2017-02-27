using System;
using System.Collections.Generic;
using GuitarChords.Lib.Chords.Enum;
using GuitarChords.Lib.Notes;

namespace GuitarChords.Lib.Chords
{
    public class ChordMajorAugmented : Chord
    {
        public NoteFondamental    Fondamental    { get; }
        public NoteThirdMajor     ThirdMajor     { get; }
        public NoteFifthAugmented FifthAugmented { get; }

        protected internal ChordMajorAugmented(Note fondamental, Note thirdMajor, Note fifthAugmented)
            : base(ChordQuality.MajorAugmented)
        {
            Fondamental    = new NoteFondamental   (fondamental   );
            ThirdMajor     = new NoteThirdMajor    (thirdMajor    );
            FifthAugmented = new NoteFifthAugmented(fifthAugmented);
        }

        public override List<NoteRole> GetNotes()
        {
            return new List<NoteRole> {Fondamental, ThirdMajor, FifthAugmented};
        }

        public override string GetDescription()
        {
            return "Descrition not added yet.";
        }

        public override string Format()
        {
            return $"Fond: {Fondamental}, 3rd maj: {ThirdMajor}, 5th #: {FifthAugmented}";
        }

        public override string ToString()
        {
            return $"{Fondamental}aug";
        }
    }
}