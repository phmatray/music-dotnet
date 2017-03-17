namespace MidiMinuit.Lib.Instruments.GuitarTunings.Base
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
                case GuitarTuningType.TuneDownHalfStep:
                    return new GuitarTuningTuneDownHalfStep();
                case GuitarTuningType.TuneDownOneStep:
                    return new GuitarTuningTuneDownOneStep();
                case GuitarTuningType.TuneDownTwoStep:
                    return new GuitarTuningTuneDownTwoStep();
                case GuitarTuningType.DroppedD:
                    return new GuitarTuningDroppedD();
                case GuitarTuningType.DroppedDVariant:
                    return new GuitarTuningDroppedDVariant();
                case GuitarTuningType.DoubleDroppedD:
                    return new GuitarTuningDoubleDroppedD();
                case GuitarTuningType.DroppedC:
                    return new GuitarTuningDroppedC();
                case GuitarTuningType.DroppedE:
                    return new GuitarTuningDroppedE();
                case GuitarTuningType.DroppedB:
                    return new GuitarTuningDroppedB();
                case GuitarTuningType.Baritone:
                    return new GuitarTuningBaritone();
                case GuitarTuningType.OpenC:
                    return new GuitarTuningOpenC();
                case GuitarTuningType.OpenCm:
                    return new GuitarTuningOpenCm();
                case GuitarTuningType.OpenC6:
                    return new GuitarTuningOpenC6();
                case GuitarTuningType.OpenCM7:
                    return new GuitarTuningOpenCM7();
                case GuitarTuningType.OpenD:
                    return new GuitarTuningOpenD();
                case GuitarTuningType.OpenDm:
                    return new GuitarTuningOpenDm();
                case GuitarTuningType.OpenD5:
                    return new GuitarTuningOpenD5();
                case GuitarTuningType.OpenD6:
                    return new GuitarTuningOpenD6();
                case GuitarTuningType.OpenDsus4:
                    return new GuitarTuningOpenDsus4();
                case GuitarTuningType.OpenE:
                    return new GuitarTuningOpenE();
                case GuitarTuningType.OpenEm:
                    return new GuitarTuningOpenEm();
                case GuitarTuningType.OpenEsus11:
                    return new GuitarTuningOpenEsus11();
                case GuitarTuningType.OpenF:
                    return new GuitarTuningOpenF();
                case GuitarTuningType.OpenG:
                    return new GuitarTuningOpenG();
                case GuitarTuningType.OpenGm:
                    return new GuitarTuningOpenGm();
                case GuitarTuningType.OpenGsus4:
                    return new GuitarTuningOpenGsus4();
                case GuitarTuningType.OpenG6:
                    return new GuitarTuningOpenG6();
                case GuitarTuningType.OpenA:
                    return new GuitarTuningOpenA();
                case GuitarTuningType.OpenAm:
                    return new GuitarTuningOpenAm();
                case GuitarTuningType.DobroOpenG:
                    return new GuitarTuningDobroOpenG();
                case GuitarTuningType.Nashville:
                    return new GuitarTuningNashville();
                case GuitarTuningType.LuteOrVihuela:
                    return new GuitarTuningLuteOrVihuela();
                default:
                    throw new ArgumentOutOfRangeException(nameof(guitarTuningType), guitarTuningType, null);
            }
        }
    }
}
