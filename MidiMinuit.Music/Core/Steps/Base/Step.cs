using System;
using MidiMinuit.Music.Core.Pitches;
using MidiMinuit.Music.Core.StepAccidentals;
using MidiMinuit.Music.Core.StepNames;

namespace MidiMinuit.Music.Core.Steps
{
    public partial class Step
    {
        public StepName Name { get; set; }

        public StepAccidental Accidental { get; set; }

        protected Step()
        {
        }

        public static Step FromPitch(Pitch pitch)
        {
            return new Step { Name = pitch.Name, Accidental = pitch.Accidental };
        }

        public Pitch ToPitch(int octaveNumber = 4)
        {
            return Pitch.FromStep(this, octaveNumber);
        }

        public override string ToString()
        {
            return $"{Name}{Accidental.SignAscii}";
        }
    }
}