using System.Collections.Generic;
using MidiMinuit.Lib.Core.Notes;
using MidiMinuit.Lib.Instruments.GuitarTunings.Enum;

namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    // add intervals
    public class GuitarString
    {
        public GuitarString(int stringIndex, int noteMidi, int retune, int? fret = null)
        {
            StringIndex = stringIndex;
            Note = new Note(noteMidi);
            Retune = retune;
            Fret = fret;
        }

        public int StringIndex { get; }

        public Note Note { get; }

        public int Retune { get; }

        public int? Fret { get; }
    }

    public class GuitarTuningStandard
        : GuitarTuning
    {
        public override GuitarTuningType TuningType { get; }
            = GuitarTuningType.Standard;

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.Standard;

        public override string Tuning { get; }
            = "E A D G B E";

        public override string Name { get; }
            = "Standard";

        public override string Description { get; }
            = "";

        public override List<GuitarString> Strings { get; }
            = new List<GuitarString>
            {
                new GuitarString(6, 52, 0, 5),
                new GuitarString(5, 57, 0, 5),
                new GuitarString(4, 62, 0, 5),
                new GuitarString(3, 67, 0, 4),
                new GuitarString(2, 71, 0, 5),
                new GuitarString(1, 76, 0),
            };

        public override GuitarTuning Clone()
            => MemberwiseClone() as GuitarTuning;
    }




















    public enum GuitarTuningType2
    {
Standard                     ,
OpenC                      ,
OpenD                      ,
ModalD                     ,
OpenDMinor                ,
OpenG                      ,
ModalG                     ,
OpenGMinor                ,
OpenA                      ,
Balalaika                   ,
Charango                    ,
Cittern1                 ,
Cittern2                 ,
Dobro                       ,
Lefty                       ,
Overtone                    ,
Pentatonic                  ,
MinorThird                 ,
MajorThird                 ,
AllFourths                 ,
AugFourths                 ,
Mandoguitar                 ,
MinorSixth                 ,
MajorSixth                 ,
Admiral                     ,
Buzzard                     ,
DropD                      ,
Face                        ,
FourAndTwenty               ,
HotType                    ,
Layover                     ,
MagicFarmer                ,
Pelican                     ,
Processional                ,
SlowMotion                 ,
Spirit                      ,
Tarboulton                  ,
Toulouse                    ,
Triqueen
    }


    public enum GuitarTuningType
    {
        Standard,
        TuneDownHalfStep,
        TuneDownOneStep,
        TuneDownTwoStep,
        DroppedD,
        DroppedDVariant,
        DoubleDroppedD,
        DroppedC,
        DroppedE,
        DroppedB,
        Baritone,
        OpenC,
        OpenCm,
        OpenC6,
        OpenCM7,
        OpenD,
        OpenDm,
        OpenD5,
        OpenD6,
        OpenDsus4,
        OpenE,
        OpenEm,
        OpenEsus11,
        OpenF,
        OpenG,
        OpenGm,
        OpenGsus4,
        OpenG6,
        OpenA,
        OpenAm,
        DobroOpenG,
        Nashville,
        LuteOrVihuela
    }
}