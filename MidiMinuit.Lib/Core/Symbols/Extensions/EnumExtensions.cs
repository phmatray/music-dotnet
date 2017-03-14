namespace MidiMinuit.Lib.Core.Symbols
{
    using System;

    public static class EnumExtensions
    {
        public static char ToUnicodeChar(this UnicodeMusicSymbolEnum symbol)
        {
            // ♩ 2669  quarter note
            // ♪ 266A  eighth note
            // ♫ 266B  beamed eighth notes
            // ♬ 266C  beamed sixteenth notes
            // ♭ 266D  music flat sign
            // ♮ 266E  music natural sign
            // ♯ 266F  music sharp sign
            switch (symbol)
            {
                case UnicodeMusicSymbolEnum.QuarterNote:
                    return '\u2669';
                case UnicodeMusicSymbolEnum.EighthNote:
                    return '\u266A';
                case UnicodeMusicSymbolEnum.BeamedEighthNotes:
                    return '\u266B';
                case UnicodeMusicSymbolEnum.BeamedSixteenthNotes:
                    return '\u266C';
                case UnicodeMusicSymbolEnum.MusicFlatSign:
                    return '\u266D';
                case UnicodeMusicSymbolEnum.MusicNaturalSign:
                    return '\u266E';
                case UnicodeMusicSymbolEnum.MusicSharpSign:
                    return '\u266F';
                case UnicodeMusicSymbolEnum.MajorSeventhMajor:
                    return '\u0394';
                default:
                    throw new ArgumentOutOfRangeException(nameof(symbol));
            }
        }
    }
}