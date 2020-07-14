namespace Algorithm.Composition
{
    public class AveragingAggregator
    {
        private Measurement[] _measurements;
        private AveragingStrategy _averagingStrategy;
        
        public AveragingAggregator(Measurement[] measurements)
        {
            _averagingStrategy = new AveragingStrategy();
            _measurements = measurements;
        }

        public Measurement Aggregate()
        {
            return _averagingStrategy.Aggregate(_measurements);
        }
    }
}