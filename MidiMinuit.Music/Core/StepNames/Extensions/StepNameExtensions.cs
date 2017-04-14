using System;
using System.Collections.Generic;

namespace MidiMinuit.Music.Core.Extensions
{
    public static class StepNameExtensions
    {
        private static readonly Dictionary<StepName, int> Pitches
            = new Dictionary<StepName, int>
            {
                { StepName.C, 0 },
                { StepName.D, 2 },
                { StepName.E, 4 },
                { StepName.F, 5 },
                { StepName.G, 7 },
                { StepName.A, 9 },
                { StepName.B, 11 }
            };

        public static int GetMidiPitch(this StepName stepName, int octave = 4)
        {
            if (stepName == null)
            {
                throw new ArgumentNullException(nameof(stepName));
            }

            if (octave <= -2 || octave >= 10 ||
                octave == 9 && stepName.StepNumber >= 6)
            {
                throw new ArgumentOutOfRangeException(nameof(octave));
            }

            return Pitches[stepName] + ((1 + octave) * 12);
        }
    }
}