namespace FacebookDeskAppLogic
{
    public class MeasurePostsCounter
    {
        // Private Members
        private int m_TotalMeasure;
        private int m_NumOfPosts;

        // Constructors
        public MeasurePostsCounter()
        {
            m_TotalMeasure = 0;
            m_NumOfPosts = 0;
        }

        // Public Methods
        public double CalcAvgMeasurePerPost()
        {
            return (double)m_TotalMeasure / m_NumOfPosts;
        }

        public void AddMeasureAndIncPosts(int i_TotalMeasure)
        {
            m_TotalMeasure += i_TotalMeasure;
            m_NumOfPosts++;
        }

        // Properties
        public int TotalMeasure
        {
            get
            {
                return m_TotalMeasure;
            }

            set
            {
                m_TotalMeasure = value;
            }
        }

        public int NumOfPosts
        {
            get
            {
                return m_NumOfPosts;
            }

            set
            {
                m_NumOfPosts = value;
            }
        }
    }
}
