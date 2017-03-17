namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;
    using MidiMinuit.Lib.Core.Notes;

    public class GuitarTuningTuneDownOneStep
        : GuitarTuning
    {
        public override List<Note> Notes { get; }
            = Note.GetNotes("D", "G", "C", "F", "A", "D");

        public override string Name { get; }
            = "Tune down 1 step";
    }
}