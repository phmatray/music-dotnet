using System;
using System.Collections.Generic;
using System.Linq;
using MidiMinuit.Music.Core.Pitches;

namespace MidiMinuit.Music.Core.Scales
{
    public partial class Scale
    {
        internal static List<Scale> CreateAll()
        {
            return Enum.GetValues(typeof(ScaleAlias))
                .Cast<ScaleAlias>()
                .Select(Create)
                .ToList();
        }

        internal static Scale Create(ScaleAlias scaleType)
        {
            switch (scaleType)
            {
                case ScaleAlias.Major:
                    return new ScaleMajor();
                case ScaleAlias.MinorMelodic:
                    return new ScaleMinorMelodic();
                case ScaleAlias.MinorHarmonic:
                    return new ScaleMinorHarmonic();
                case ScaleAlias.MinorNaturalEolian:
                    return new ScaleMinorNaturalEolian();
                case ScaleAlias.ModeDorian:
                    return new ScaleModeDorian();
                case ScaleAlias.ModeMixolydian:
                    return new ScaleModeMixolydian();
                case ScaleAlias.ModeLydian:
                    return new ScaleModeLydian();
                case ScaleAlias.ModeLydianB7:
                    return new ScaleModeLydianB7();
                case ScaleAlias.PentatonicMajor:
                    return new ScalePentatonicMajor();
                case ScaleAlias.PentatonicMinor:
                    return new ScalePentatonicMinor();
                case ScaleAlias.Blues:
                    return new ScaleBlues();
                case ScaleAlias.ModePhrygian:
                    return new ScaleModePhrygian();
                case ScaleAlias.ModeLocrian:
                    return new ScaleModeLocrian();
                case ScaleAlias.ModeLocrianBec2:
                    return new ScaleModeLocrianBec2();
                case ScaleAlias.ModeMixolydianB2B6:
                    return new ScaleModeMixolydianB2B6();
                case ScaleAlias.ModeAltered:
                    return new ScaleModeAltered();
                case ScaleAlias.ModeLydianAdded:
                    return new ScaleModeLydianAdded();
                case ScaleAlias.ModeDiminishedReverse:
                    return new ScaleModeDiminishedReverse();
                case ScaleAlias.ModeDiminished:
                    return new ScaleModeDiminished();
                default:
                    throw new ArgumentOutOfRangeException(nameof(scaleType), scaleType, null);
            }
        }
    }
}