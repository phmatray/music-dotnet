namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;
    using MidiMinuit.Lib.Core.Notes;

    public class GuitarTuningOpenDm
        : GuitarTuning
    {
        public override List<Note> Notes { get; }
            = Note.GetNotes("D", "A", "D", "F", "A", "D");

        public override string Name { get; }
            = "Open Dm";
    }
}