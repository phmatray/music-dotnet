namespace OpenJam.Music.Core
{
    public abstract class IntervalSimple
        : Interval
    {
        protected IntervalSimple()
        {
        }

        protected IntervalSimple(Pitch startingPitch)
            : base(startingPitch)
        {
            StartingPitch = startingPitch;
        }

        public override Interval InverseOctaveUp()
        {
            var startingPitch = new Pitch(EndingPitch);

            var endingPitch = new Pitch(StartingPitch);
            endingPitch.Octave++;

            return Create(startingPitch, endingPitch);
        }

        public override Interval InverseOctaveDown()
        {
            var startingPitch = new Pitch(EndingPitch);

            var endingPitch = new Pitch(StartingPitch);
            startingPitch.Octave--;

            return Create(startingPitch, endingPitch);
        }

        public Interval ToCompound()
        {
            var startingPitch = new Pitch(StartingPitch);

            var endingPitch = new Pitch(EndingPitch);
            endingPitch.Octave++;

            return Create(startingPitch, endingPitch);
        }
    }
}