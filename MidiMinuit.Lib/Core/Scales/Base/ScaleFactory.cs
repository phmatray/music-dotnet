namespace MidiMinuit.Lib.Core.Scales.Base
{
    using System;
    using MidiMinuit.Lib.Core.Notes;

    public class ScaleFactory
    {
        public virtual Scale CreateScale(ScaleType scaleType, Note key)
        {
            switch (scaleType)
            {
                case ScaleType.Major:
                    return new ScaleMajor(key);
                case ScaleType.MinorMelodic:
                    return new ScaleMinorMelodic(key);
                case ScaleType.MinorHarmonic:
                    return new ScaleMinorHarmonic(key);
                case ScaleType.MinorNaturalEolian:
                    return new ScaleMinorNaturalEolian(key);
                case ScaleType.ModeDorian:
                    return new ScaleModeDorian(key);
                case ScaleType.ModeMixolydian:
                    return new ScaleModeMixolydian(key);
                case ScaleType.ModeLydian:
                    return new ScaleModeLydian(key);
                case ScaleType.ModeLydianB7:
                    return new ScaleModeLydianB7(key);
                case ScaleType.PentatonicMajor:
                    return new ScalePentatonicMajor(key);
                case ScaleType.PentatonicMinor:
                    return new ScalePentatonicMinor(key);
                case ScaleType.Blues:
                    return new ScaleBlues(key);
                case ScaleType.ModePhrygian:
                    return new ScaleModePhrygian(key);
                case ScaleType.ModeLocrian:
                    return new ScaleModeLocrian(key);
                case ScaleType.ModeLocrianBec2:
                    return new ScaleModeLocrianBec2(key);
                case ScaleType.ModeMixolydianB2B6:
                    return new ScaleModeMixolydianB2B6(key);
                case ScaleType.ModeAltered:
                    return new ScaleModeAltered(key);
                case ScaleType.ModeLydianAdded:
                    return new ScaleModeLydianAdded(key);
                case ScaleType.ModeDiminishedReverse:
                    return new ScaleModeDiminishedReverse(key);
                case ScaleType.ModeDiminished:
                    return new ScaleModeDiminished(key);
                default:
                    throw new ArgumentOutOfRangeException(nameof(scaleType), scaleType, null);
            }
        }
    }
}
