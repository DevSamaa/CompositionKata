namespace Algorithm.Composition
{
    public class HighPassSummingAggregator
    {
        private Measurement[] _measurements;
        private HighPassFilter _highPassFilter;
        private SummingStrategy _summingStrategy;
        public HighPassSummingAggregator(Measurement[] measurements)
        {
            _highPassFilter = new HighPassFilter();
            _summingStrategy = new SummingStrategy();
            _measurements = measurements;
        }

        public Measurement Aggregate()
        {
            var filteredMeasurements =_highPassFilter.Filter(_measurements);
            return _summingStrategy.Aggregate(filteredMeasurements);
        }
    }
}