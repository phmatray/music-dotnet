using System;
using System.Collections.Generic;
using System.Linq;
using MidiMinuit.Music.Core.Notes;

namespace MidiMinuit.Music.Core.Scales
{
    public class ScaleFactory
    {
        public List<Scale> CreateAllScales(Pitch key)
        {
            return Enum.GetValues(typeof(ScaleAlias))
                .Cast<ScaleAlias>()
                .Select(x => CreateScale(x, key))
                .ToList();
        }

        public Scale CreateScale(ScaleAlias scaleType, Pitch key)
        {
            switch (scaleType)
            {
                case ScaleAlias.Major:
                    return new ScaleMajor(key);
                case ScaleAlias.MinorMelodic:
                    return new ScaleMinorMelodic(key);
                case ScaleAlias.MinorHarmonic:
                    return new ScaleMinorHarmonic(key);
                case ScaleAlias.MinorNaturalEolian:
                    return new ScaleMinorNaturalEolian(key);
                case ScaleAlias.ModeDorian:
                    return new ScaleModeDorian(key);
                case ScaleAlias.ModeMixolydian:
                    return new ScaleModeMixolydian(key);
                case ScaleAlias.ModeLydian:
                    return new ScaleModeLydian(key);
                case ScaleAlias.ModeLydianB7:
                    return new ScaleModeLydianB7(key);
                case ScaleAlias.PentatonicMajor:
                    return new ScalePentatonicMajor(key);
                case ScaleAlias.PentatonicMinor:
                    return new ScalePentatonicMinor(key);
                case ScaleAlias.Blues:
                    return new ScaleBlues(key);
                case ScaleAlias.ModePhrygian:
                    return new ScaleModePhrygian(key);
                case ScaleAlias.ModeLocrian:
                    return new ScaleModeLocrian(key);
                case ScaleAlias.ModeLocrianBec2:
                    return new ScaleModeLocrianBec2(key);
                case ScaleAlias.ModeMixolydianB2B6:
                    return new ScaleModeMixolydianB2B6(key);
                case ScaleAlias.ModeAltered:
                    return new ScaleModeAltered(key);
                case ScaleAlias.ModeLydianAdded:
                    return new ScaleModeLydianAdded(key);
                case ScaleAlias.ModeDiminishedReverse:
                    return new ScaleModeDiminishedReverse(key);
                case ScaleAlias.ModeDiminished:
                    return new ScaleModeDiminished(key);
                default:
                    throw new ArgumentOutOfRangeException(nameof(scaleType), scaleType, null);
            }
        }
    }
}