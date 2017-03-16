namespace MidiMinuit.Lib.Core.Scales.Base
{
    using System;
    using MidiMinuit.Lib.Core.Notes;

    public class ScaleFactory
    {
        public virtual Scale CreateScale(ScaleTypeEnum scaleType, Note key)
        {
            switch (scaleType)
            {
                case ScaleTypeEnum.Major:
                    return new ScaleMajor(key);
                case ScaleTypeEnum.MinorMelodic:
                    return new ScaleMinorMelodic(key);
                case ScaleTypeEnum.MinorHarmonic:
                    return new ScaleMinorHarmonic(key);
                case ScaleTypeEnum.MinorNaturalEolian:
                    return new ScaleMinorNaturalEolian(key);
                case ScaleTypeEnum.ModeDorian:
                    return new ScaleModeDorian(key);
                case ScaleTypeEnum.ModeMixolydian:
                    return new ScaleModeMixolydian(key);
                case ScaleTypeEnum.ModeLydian:
                    return new ScaleModeLydian(key);
                case ScaleTypeEnum.ModeLydianB7:
                    return new ScaleModeLydianB7(key);
                case ScaleTypeEnum.PentatonicMajor:
                    return new ScalePentatonicMajor(key);
                case ScaleTypeEnum.PentatonicMinor:
                    return new ScalePentatonicMinor(key);
                case ScaleTypeEnum.Blues:
                    return new ScaleBlues(key);
                case ScaleTypeEnum.ModePhrygian:
                    return new ScaleModePhrygian(key);
                case ScaleTypeEnum.ModeLocrian:
                    return new ScaleModeLocrian(key);
                case ScaleTypeEnum.ModeLocrianBec2:
                    return new ScaleModeLocrianBec2(key);
                case ScaleTypeEnum.ModeMixolydianB2B6:
                    return new ScaleModeMixolydianB2B6(key);
                case ScaleTypeEnum.ModeAltered:
                    return new ScaleModeAltered(key);
                case ScaleTypeEnum.ModeLydianAdded:
                    return new ScaleModeLydianAdded(key);
                case ScaleTypeEnum.ModeDiminishedReverse:
                    return new ScaleModeDiminishedReverse(key);
                case ScaleTypeEnum.ModeDiminished:
                    return new ScaleModeDiminished(key);
                default:
                    throw new ArgumentOutOfRangeException(nameof(scaleType), scaleType, null);
            }
        }
    }
}
