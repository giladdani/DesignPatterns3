namespace FacebookDeskAppLogic
{
    public class MeasurePostsCounter
    {
        // Constructors
        public MeasurePostsCounter()
        {
            TotalMeasure = 0;
            NumOfPosts = 0;
        }

        // Public Methods
        public double CalcAvgMeasurePerPost()
        {
            return (double)TotalMeasure / NumOfPosts;
        }

        public void AddMeasureAndIncPosts(int i_TotalMeasure)
        {
            TotalMeasure += i_TotalMeasure;
            NumOfPosts++;
        }

        // Properties
        public int TotalMeasure { get; set; }

        public int NumOfPosts { get; set; }
    }
}
