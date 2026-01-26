namespace DevExpressDemo
{
    public class DataPoint
    {
        public DateTime Argument { get; set; }
        public double Value { get; set; }
        
        public DataPoint(DateTime argument, double value)
        {
            Argument = argument;
            Value = value;
        }
    }
}
