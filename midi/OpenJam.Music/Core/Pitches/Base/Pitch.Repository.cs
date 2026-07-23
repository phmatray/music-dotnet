using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenJam.Music.Core
{
    public partial class Pitch
    {
        public static List<Pitch> CreateAll()
        {
            return Enum.GetValues(typeof(PitchAlias))
                .Cast<PitchAlias>()
                .Select(Create)
                .ToList();
        }

        public static Pitch Create(PitchAlias alias)
        {
            switch (alias)
            {
                case PitchAlias.A1:
                    return FromStep(A, 1);
                case PitchAlias.A2:
                    return FromStep(A, 2);
                case PitchAlias.A3:
                    return FromStep(A, 3);
                case PitchAlias.A4:
                    return FromStep(A, 4);
                case PitchAlias.A5:
                    return FromStep(A, 5);
                case PitchAlias.A6:
                    return FromStep(A, 6);
                case PitchAlias.Ab1:
                    return FromStep(Ab, 1);
                case PitchAlias.Ab2:
                    return FromStep(Ab, 2);
                case PitchAlias.Ab3:
                    return FromStep(Ab, 3);
                case PitchAlias.Ab4:
                    return FromStep(Ab, 4);
                case PitchAlias.Ab5:
                    return FromStep(Ab, 5);
                case PitchAlias.Ab6:
                    return FromStep(Ab, 6);
                case PitchAlias.ASharp1:
                    return FromStep(ASharp, 1);
                case PitchAlias.ASharp2:
                    return FromStep(ASharp, 2);
                case PitchAlias.ASharp3:
                    return FromStep(ASharp, 3);
                case PitchAlias.ASharp4:
                    return FromStep(ASharp, 4);
                case PitchAlias.ASharp5:
                    return FromStep(ASharp, 5);
                case PitchAlias.ASharp6:
                    return FromStep(ASharp, 6);
                case PitchAlias.B1:
                    return FromStep(B, 1);
                case PitchAlias.B2:
                    return FromStep(B, 2);
                case PitchAlias.B3:
                    return FromStep(B, 3);
                case PitchAlias.B4:
                    return FromStep(B, 4);
                case PitchAlias.B5:
                    return FromStep(B, 5);
                case PitchAlias.B6:
                    return FromStep(B, 6);
                case PitchAlias.Bb1:
                    return FromStep(Bb, 1);
                case PitchAlias.Bb2:
                    return FromStep(Bb, 2);
                case PitchAlias.Bb3:
                    return FromStep(Bb, 3);
                case PitchAlias.Bb4:
                    return FromStep(Bb, 4);
                case PitchAlias.Bb5:
                    return FromStep(Bb, 5);
                case PitchAlias.Bb6:
                    return FromStep(Bb, 6);
                case PitchAlias.BSharp1:
                    return FromStep(BSharp, 1);
                case PitchAlias.BSharp2:
                    return FromStep(BSharp, 2);
                case PitchAlias.BSharp3:
                    return FromStep(BSharp, 3);
                case PitchAlias.BSharp4:
                    return FromStep(BSharp, 4);
                case PitchAlias.BSharp5:
                    return FromStep(BSharp, 5);
                case PitchAlias.BSharp6:
                    return FromStep(BSharp, 6);
                case PitchAlias.C1:
                    return FromStep(C, 1);
                case PitchAlias.C2:
                    return FromStep(C, 2);
                case PitchAlias.C3:
                    return FromStep(C, 3);
                case PitchAlias.C4:
                    return FromStep(C, 4);
                case PitchAlias.C5:
                    return FromStep(C, 5);
                case PitchAlias.C6:
                    return FromStep(C, 6);
                case PitchAlias.C7:
                    return FromStep(C, 7);
                case PitchAlias.Cb1:
                    return FromStep(Cb, 1);
                case PitchAlias.Cb2:
                    return FromStep(Cb, 2);
                case PitchAlias.Cb3:
                    return FromStep(Cb, 3);
                case PitchAlias.Cb4:
                    return FromStep(Cb, 4);
                case PitchAlias.Cb5:
                    return FromStep(Cb, 5);
                case PitchAlias.Cb6:
                    return FromStep(Cb, 6);
                case PitchAlias.Cb7:
                    return FromStep(Cb, 7);
                case PitchAlias.CSharp1:
                    return FromStep(CSharp, 1);
                case PitchAlias.CSharp2:
                    return FromStep(CSharp, 2);
                case PitchAlias.CSharp3:
                    return FromStep(CSharp, 3);
                case PitchAlias.CSharp4:
                    return FromStep(CSharp, 4);
                case PitchAlias.CSharp5:
                    return FromStep(CSharp, 5);
                case PitchAlias.CSharp6:
                    return FromStep(CSharp, 6);
                case PitchAlias.CSharp7:
                    return FromStep(CSharp, 7);
                case PitchAlias.D1:
                    return FromStep(D, 1);
                case PitchAlias.D2:
                    return FromStep(D, 2);
                case PitchAlias.D3:
                    return FromStep(D, 3);
                case PitchAlias.D4:
                    return FromStep(D, 4);
                case PitchAlias.D5:
                    return FromStep(D, 5);
                case PitchAlias.D6:
                    return FromStep(D, 6);
                case PitchAlias.Db1:
                    return FromStep(Db, 1);
                case PitchAlias.Db2:
                    return FromStep(Db, 2);
                case PitchAlias.Db3:
                    return FromStep(Db, 3);
                case PitchAlias.Db4:
                    return FromStep(Db, 4);
                case PitchAlias.Db5:
                    return FromStep(Db, 5);
                case PitchAlias.Db6:
                    return FromStep(Db, 6);
                case PitchAlias.DSharp1:
                    return FromStep(DSharp, 1);
                case PitchAlias.DSharp2:
                    return FromStep(DSharp, 2);
                case PitchAlias.DSharp3:
                    return FromStep(DSharp, 3);
                case PitchAlias.DSharp4:
                    return FromStep(DSharp, 4);
                case PitchAlias.DSharp5:
                    return FromStep(DSharp, 5);
                case PitchAlias.DSharp6:
                    return FromStep(DSharp, 6);
                case PitchAlias.E1:
                    return FromStep(E, 1);
                case PitchAlias.E2:
                    return FromStep(E, 2);
                case PitchAlias.E3:
                    return FromStep(E, 3);
                case PitchAlias.E4:
                    return FromStep(E, 4);
                case PitchAlias.E5:
                    return FromStep(E, 5);
                case PitchAlias.E6:
                    return FromStep(E, 6);
                case PitchAlias.Eb1:
                    return FromStep(Eb, 1);
                case PitchAlias.Eb2:
                    return FromStep(Eb, 2);
                case PitchAlias.Eb3:
                    return FromStep(Eb, 3);
                case PitchAlias.Eb4:
                    return FromStep(Eb, 4);
                case PitchAlias.Eb5:
                    return FromStep(Eb, 5);
                case PitchAlias.Eb6:
                    return FromStep(Eb, 6);
                case PitchAlias.ESharp1:
                    return FromStep(ESharp, 1);
                case PitchAlias.ESharp2:
                    return FromStep(ESharp, 2);
                case PitchAlias.ESharp3:
                    return FromStep(ESharp, 3);
                case PitchAlias.ESharp4:
                    return FromStep(ESharp, 4);
                case PitchAlias.ESharp5:
                    return FromStep(ESharp, 5);
                case PitchAlias.ESharp6:
                    return FromStep(ESharp, 6);
                case PitchAlias.F1:
                    return FromStep(F, 1);
                case PitchAlias.F2:
                    return FromStep(F, 2);
                case PitchAlias.F3:
                    return FromStep(F, 3);
                case PitchAlias.F4:
                    return FromStep(F, 4);
                case PitchAlias.F5:
                    return FromStep(F, 5);
                case PitchAlias.F6:
                    return FromStep(F, 6);
                case PitchAlias.Fb1:
                    return FromStep(Fb, 1);
                case PitchAlias.Fb2:
                    return FromStep(Fb, 2);
                case PitchAlias.Fb3:
                    return FromStep(Fb, 3);
                case PitchAlias.Fb4:
                    return FromStep(Fb, 4);
                case PitchAlias.Fb5:
                    return FromStep(Fb, 5);
                case PitchAlias.Fb6:
                    return FromStep(Fb, 6);
                case PitchAlias.FSharp1:
                    return FromStep(FSharp, 1);
                case PitchAlias.FSharp2:
                    return FromStep(FSharp, 2);
                case PitchAlias.FSharp3:
                    return FromStep(FSharp, 3);
                case PitchAlias.FSharp4:
                    return FromStep(FSharp, 4);
                case PitchAlias.FSharp5:
                    return FromStep(FSharp, 5);
                case PitchAlias.FSharp6:
                    return FromStep(FSharp, 6);
                case PitchAlias.G1:
                    return FromStep(G, 1);
                case PitchAlias.G2:
                    return FromStep(G, 2);
                case PitchAlias.G3:
                    return FromStep(G, 3);
                case PitchAlias.G4:
                    return FromStep(G, 4);
                case PitchAlias.G5:
                    return FromStep(G, 5);
                case PitchAlias.G6:
                    return FromStep(G, 6);
                case PitchAlias.Gb1:
                    return FromStep(Gb, 1);
                case PitchAlias.Gb2:
                    return FromStep(Gb, 2);
                case PitchAlias.Gb3:
                    return FromStep(Gb, 3);
                case PitchAlias.Gb4:
                    return FromStep(Gb, 4);
                case PitchAlias.Gb5:
                    return FromStep(Gb, 5);
                case PitchAlias.Gb6:
                    return FromStep(Gb, 6);
                case PitchAlias.GSharp1:
                    return FromStep(GSharp, 1);
                case PitchAlias.GSharp2:
                    return FromStep(GSharp, 2);
                case PitchAlias.GSharp3:
                    return FromStep(GSharp, 3);
                case PitchAlias.GSharp4:
                    return FromStep(GSharp, 4);
                case PitchAlias.GSharp5:
                    return FromStep(GSharp, 5);
                case PitchAlias.GSharp6:
                    return FromStep(GSharp, 6);
                default:
                    throw new ArgumentOutOfRangeException(nameof(alias), alias, null);
            }
        }
    }
}