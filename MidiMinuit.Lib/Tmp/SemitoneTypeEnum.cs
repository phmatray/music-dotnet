namespace MidiMinuit.Lib.Tmp
{
    /*
     * Lorsqu'une quarte augmentée est constituée de 3 tons on emploie le terme triton pour la désigner.
     *
     * Intervalles simple et composés (Les intervalles composés ne peuvent être renversés, seuls les intervalles simples peuvent être renversés.)
     */

    public enum SemitoneTypeEnum
    {
        Diatonic = 1,
        Chromatic = 1
    }

    public enum IntervalType
    {
        /// <summary>
        ///     L'intervalle mélodique fait entendre les deux sons successivement.
        /// </summary>
        Melodic,

        /// <summary>
        ///     L'intervalle harmonique fait entendre les deux sons simultanément. Il se lit toujours de façon ascendante,
        ///     c'est-à-dire de bas en haut.
        /// </summary>
        Harmonic
    }

    public enum MelodicIntervalType
    {
        /// <summary>
        ///     L'intervalle mélodique ascendant est celui dont la note inférieure est écrite la première.
        /// </summary>
        Ascending,

        /// <summary>
        ///     L'intervalle mélodique descendant est celui dont la note supérieure est écrite la première.
        /// </summary>
        Descending
    }
}