using System;
using FacebookWrapper.ObjectModel;

namespace FacebookDeskAppLogic
{
    abstract class GetBestTimeForStatusBase
    {

        public int GetBestTimeForStatus(User i_User)
        {
            MeasurePostsCounter[] measurePostsCounterArray = new MeasurePostsCounter[24];
            calcTotalMeasureOfPostTime(i_User, measurePostsCounterArray);
            int hourWithMaxMeasurePerPost = generateBestHourByTotalMeasure(measurePostsCounterArray);
            return hourWithMaxMeasurePerPost;
        }

        private void calcTotalMeasureOfPostTime(User i_User, MeasurePostsCounter[] i_MeasurePostsCounterArray)
        {
            foreach (Post post in i_User.Posts)
            {
                // get post time
                try
                {
                    DateTime time = post.CreatedTime.GetValueOrDefault();
                    int hour = time.Hour;
                    int totalMeasure = calcTotalMeasureOfPost(post);
                    i_MeasurePostsCounterArray[hour].AddMeasureAndIncPosts(totalMeasure);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private int generateBestHourByTotalMeasure(MeasurePostsCounter[] i_MeasurePostsCounterArray)
        {
            int hourWithMaxMeasurePerPost = -1;
            double max = -1;
            for (int i = 0; i < 24; i++)
            {
                MeasurePostsCounter counter = i_MeasurePostsCounterArray[i];
                if (counter.CalcAvgMeasurePerPost() > max)
                {
                    hourWithMaxMeasurePerPost = i;
                    max = counter.CalcAvgMeasurePerPost();
                }
            }

            return hourWithMaxMeasurePerPost;
        }

        public abstract int calcTotalMeasureOfPost(Post i_Post);
    }
}
