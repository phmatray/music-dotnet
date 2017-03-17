namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;
    using MidiMinuit.Lib.Core.Notes;

    public class GuitarTuningOpenAm
        : GuitarTuning
    {
        public override List<Note> Notes { get; }
            = Note.GetNotes("E", "A", "E", "A", "C", "E");

        public override string Name { get; }
            = "Open Am";
    }
}