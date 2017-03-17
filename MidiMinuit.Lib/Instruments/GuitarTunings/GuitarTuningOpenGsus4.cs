namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;
    using MidiMinuit.Lib.Core.Notes;

    public class GuitarTuningOpenGsus4
        : GuitarTuning
    {
        public override List<Note> Notes { get; }
            = Note.GetNotes("D", "G", "D", "G", "C", "D");

        public override string Name { get; }
            = "Open Gsus4";
    }
}