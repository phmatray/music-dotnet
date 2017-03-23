namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GuitarTuningFactory
    {
        public List<GuitarTuning> CreateAllGuitarTunings()
        {
            return Enum.GetValues(typeof(GuitarTuningAlias))
                .Cast<GuitarTuningAlias>()
                .Select(CreateGuitarTuning)
                .ToList();
        }

        public GuitarTuning CreateGuitarTuning(GuitarTuningAlias guitarTuningType)
        {
            switch (guitarTuningType)
            {
                case GuitarTuningAlias.Standard:
                    return new GuitarTuningStandard();
                case GuitarTuningAlias.OpenC:
                    return new GuitarTuningOpenC();
                case GuitarTuningAlias.OpenD:
                    return new GuitarTuningOpenD();
                case GuitarTuningAlias.ModalD:
                    return new GuitarTuningModalD();
                case GuitarTuningAlias.OpenDMinor:
                    return new GuitarTuningOpenDMinor();
                case GuitarTuningAlias.OpenG:
                    return new GuitarTuningOpenG();
                case GuitarTuningAlias.ModalG:
                    return new GuitarTuningModalG();
                case GuitarTuningAlias.OpenGMinor:
                    return new GuitarTuningOpenGMinor();
                case GuitarTuningAlias.OpenA:
                    return new GuitarTuningOpenA();
                case GuitarTuningAlias.Balalaika:
                    return new GuitarTuningBalalaika();
                case GuitarTuningAlias.Charango:
                    return new GuitarTuningCharango();
                case GuitarTuningAlias.Cittern1:
                    return new GuitarTuningCittern1();
                case GuitarTuningAlias.Cittern2:
                    return new GuitarTuningCittern2();
                case GuitarTuningAlias.Dobro:
                    return new GuitarTuningDobro();
                case GuitarTuningAlias.Lefty:
                    return new GuitarTuningLefty();
                case GuitarTuningAlias.Overtone:
                    return new GuitarTuningOvertone();
                case GuitarTuningAlias.Pentatonic:
                    return new GuitarTuningPentatonic();
                case GuitarTuningAlias.MinorThird:
                    return new GuitarTuningMinorThird();
                case GuitarTuningAlias.MajorThird:
                    return new GuitarTuningMajorThird();
                case GuitarTuningAlias.AllFourths:
                    return new GuitarTuningAllFourths();
                case GuitarTuningAlias.AugFourths:
                    return new GuitarTuningAugFourths();
                case GuitarTuningAlias.Mandoguitar:
                    return new GuitarTuningMandoguitar();
                case GuitarTuningAlias.MinorSixth:
                    return new GuitarTuningMinorSixth();
                case GuitarTuningAlias.MajorSixth:
                    return new GuitarTuningMajorSixth();
                case GuitarTuningAlias.Admiral:
                    return new GuitarTuningAdmiral();
                case GuitarTuningAlias.Buzzard:
                    return new GuitarTuningBuzzard();
                case GuitarTuningAlias.DropD:
                    return new GuitarTuningDropD();
                case GuitarTuningAlias.Face:
                    return new GuitarTuningFace();
                case GuitarTuningAlias.FourAndTwenty:
                    return new GuitarTuningFourAndTwenty();
                case GuitarTuningAlias.HotType:
                    return new GuitarTuningHotType();
                case GuitarTuningAlias.Layover:
                    return new GuitarTuningLayover();
                case GuitarTuningAlias.MagicFarmer:
                    return new GuitarTuningMagicFarmer();
                case GuitarTuningAlias.Pelican:
                    return new GuitarTuningPelican();
                case GuitarTuningAlias.Processional:
                    return new GuitarTuningProcessional();
                case GuitarTuningAlias.SlowMotion:
                    return new GuitarTuningSlowMotion();
                case GuitarTuningAlias.Spirit:
                    return new GuitarTuningSpirit();
                case GuitarTuningAlias.Tarboulton:
                    return new GuitarTuningTarboulton();
                case GuitarTuningAlias.Toulouse:
                    return new GuitarTuningToulouse();
                case GuitarTuningAlias.Triqueen:
                    return new GuitarTuningTriqueen();
                default:
                    throw new ArgumentOutOfRangeException(nameof(guitarTuningType), guitarTuningType, null);
            }
        }
    }
}