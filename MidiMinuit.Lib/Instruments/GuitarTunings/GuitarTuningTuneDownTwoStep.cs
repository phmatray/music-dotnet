namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;
    using MidiMinuit.Lib.Core.Notes;

    public class GuitarTuningTuneDownTwoStep
        : GuitarTuning
    {
        public override List<Note> Notes { get; }
            = Note.GetNotes("C", "F", "B♭", "E♭", "G", "C");

        public override string Name { get; }
            = "Tune down 2 step";
    }
}