namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;
    using MidiMinuit.Lib.Core.Notes;
    using MidiMinuit.Lib.Instruments.GuitarTunings.Enum;

    public class GuitarTuningOpenA
        : GuitarTuning
    {
        public override List<Note> Notes { get; }
            = Note.GetNotes("E", "A", "E", "A", "D♭", "E");

        public override string Name { get; }
            = "Open A";

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.OpenMajor;

        public List<string> Songs { get; }
            = new List<string>
            {
                "Jimmy Page on In My Time of Dying",
                "Jack White on Seven Nation Army"
            };
    }
}