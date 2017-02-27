using System;
using MidiMinuit.Lib.Chords.Tools.Enum;

namespace MidiMinuit.Lib.Chords.Tools.Helpers
{
    public static class EnumTextParser
    {
        public static char ToUnicodeChar(this UnicodeMusicSymbol symbol)
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
                case UnicodeMusicSymbol.QuarterNote:
                    return '\u2669';
                case UnicodeMusicSymbol.EighthNote:
                    return '\u266A';
                case UnicodeMusicSymbol.BeamedEighthNotes:
                    return '\u266B';
                case UnicodeMusicSymbol.BeamedSixteenthNotes:
                    return '\u266C';
                case UnicodeMusicSymbol.MusicFlatSign:
                    return '\u266D';
                case UnicodeMusicSymbol.MusicNaturalSign:
                    return '\u266E';
                case UnicodeMusicSymbol.MusicSharpSign:
                    return '\u266F';
                case UnicodeMusicSymbol.MajorSeventhMajor:
                    return '\u0394';
                default:
                    throw new ArgumentOutOfRangeException(nameof(symbol));
            }
        }
    }
}