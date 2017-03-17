namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;
    using MidiMinuit.Lib.Core.Notes;
    using MidiMinuit.Lib.Instruments.GuitarTunings.Enum;

    public class GuitarTuningOpenB
        : GuitarTuning
    {
        public override List<Note> Notes { get; }
            = Note.GetNotes("B", "F♯", "B", "F♯", "B", "D♯");

        public override string Name { get; }
            = "Open B";

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.OpenMajor;
    }
}