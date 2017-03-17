namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;
    using MidiMinuit.Lib.Core.Notes;

    public class GuitarTuningOpenEm
        : GuitarTuning
    {
        public override List<Note> Notes { get; }
            = Note.GetNotes("E", "B", "E", "G", "B", "E");

        public override string Name { get; }
            = "Open Em";
    }
}