namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System;

    public class GuitarTuningFactory
    {
        public virtual GuitarTuning CreateGuitarTuning(GuitarTuningType guitarTuningType)
        {
            switch (guitarTuningType)
            {
                case GuitarTuningType.Standard:
                    return new GuitarTuningStandard();
                case GuitarTuningType.OpenC:
                    return new GuitarTuningOpenC();
                case GuitarTuningType.OpenD:
                    return new GuitarTuningOpenD();
                case GuitarTuningType.ModalD:
                    return new GuitarTuningModalD();
                case GuitarTuningType.OpenDMinor:
                    return new GuitarTuningOpenDMinor();
                case GuitarTuningType.OpenG:
                    return new GuitarTuningOpenG();
                case GuitarTuningType.ModalG:
                    return new GuitarTuningModalG();
                case GuitarTuningType.OpenGMinor:
                    return new GuitarTuningOpenGMinor();
                case GuitarTuningType.OpenA:
                    return new GuitarTuningOpenA();
                case GuitarTuningType.Balalaika:
                    return new GuitarTuningBalalaika();
                case GuitarTuningType.Charango:
                    return new GuitarTuningCharango();
                case GuitarTuningType.Cittern1:
                    return new GuitarTuningCittern1();
                case GuitarTuningType.Cittern2:
                    return new GuitarTuningCittern2();
                case GuitarTuningType.Dobro:
                    return new GuitarTuningDobro();
                case GuitarTuningType.Lefty:
                    return new GuitarTuningLefty();
                case GuitarTuningType.Overtone:
                    return new GuitarTuningOvertone();
                case GuitarTuningType.Pentatonic:
                    return new GuitarTuningPentatonic();
                case GuitarTuningType.MinorThird:
                    return new GuitarTuningMinorThird();
                case GuitarTuningType.MajorThird:
                    return new GuitarTuningMajorThird();
                case GuitarTuningType.AllFourths:
                    return new GuitarTuningAllFourths();
                case GuitarTuningType.AugFourths:
                    return new GuitarTuningAugFourths();
                case GuitarTuningType.Mandoguitar:
                    return new GuitarTuningMandoguitar();
                case GuitarTuningType.MinorSixth:
                    return new GuitarTuningMinorSixth();
                case GuitarTuningType.MajorSixth:
                    return new GuitarTuningMajorSixth();
                case GuitarTuningType.Admiral:
                    return new GuitarTuningAdmiral();
                case GuitarTuningType.Buzzard:
                    return new GuitarTuningBuzzard();
                case GuitarTuningType.DropD:
                    return new GuitarTuningDropD();
                case GuitarTuningType.Face:
                    return new GuitarTuningFace();
                case GuitarTuningType.FourAndTwenty:
                    return new GuitarTuningFourAndTwenty();
                case GuitarTuningType.HotType:
                    return new GuitarTuningHotType();
                case GuitarTuningType.Layover:
                    return new GuitarTuningLayover();
                case GuitarTuningType.MagicFarmer:
                    return new GuitarTuningMagicFarmer();
                case GuitarTuningType.Pelican:
                    return new GuitarTuningPelican();
                case GuitarTuningType.Processional:
                    return new GuitarTuningProcessional();
                case GuitarTuningType.SlowMotion:
                    return new GuitarTuningSlowMotion();
                case GuitarTuningType.Spirit:
                    return new GuitarTuningSpirit();
                case GuitarTuningType.Tarboulton:
                    return new GuitarTuningTarboulton();
                case GuitarTuningType.Toulouse:
                    return new GuitarTuningToulouse();
                case GuitarTuningType.Triqueen:
                    return new GuitarTuningTriqueen();
                default:
                    throw new ArgumentOutOfRangeException(nameof(guitarTuningType), guitarTuningType, null);
            }
        }
    }
}