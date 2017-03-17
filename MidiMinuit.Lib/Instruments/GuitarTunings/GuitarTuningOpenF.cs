namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;
    using MidiMinuit.Lib.Core.Notes;

    public class GuitarTuningOpenF
        : GuitarTuning
    {
        public override List<Note> Notes { get; }
            = Note.GetNotes("F", "A", "C", "F", "C", "F");

        public override string Name { get; }
            = "Open F";
    }
}