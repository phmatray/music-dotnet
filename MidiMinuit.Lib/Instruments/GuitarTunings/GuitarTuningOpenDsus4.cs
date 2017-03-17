namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;
    using MidiMinuit.Lib.Core.Notes;

    public class GuitarTuningOpenDsus4
        : GuitarTuning
    {
        public override List<Note> Notes { get; }
            = Note.GetNotes("D", "A", "D", "G", "A", "D");

        public override string Name { get; }
            = "Open Dsus4";
    }
}