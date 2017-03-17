namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;
    using MidiMinuit.Lib.Core.Notes;

    public class GuitarTuningOpenD5
        : GuitarTuning
    {
        public override List<Note> Notes { get; }
            = Note.GetNotes("D", "A", "D", "D", "A", "D");

        public override string Name { get; }
            = "Open D5";
    }
}