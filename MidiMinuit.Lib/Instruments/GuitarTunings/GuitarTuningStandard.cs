namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;
    using MidiMinuit.Lib.Core.Notes;

    public class GuitarTuningStandard
        : GuitarTuning
    {
        public override List<Note> Notes { get; }
            = Note.GetNotes("E", "A", "D", "G", "B", "E");

        public override string Name { get; }
            = "Standard";
    }
}