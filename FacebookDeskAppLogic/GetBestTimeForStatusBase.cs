using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookDeskAppLogic
{
    public abstract class GetBestTimeForStatusBase
    {
        public int GetBestTimeForStatus(PostsCollection i_Posts)
        {
            MeasurePostsCounter[] measurePostsCounterArray = new MeasurePostsCounter[24];
            calcTotalMeasureOfPostTime(i_Posts, measurePostsCounterArray);
            int hourWithMaxMeasurePerPost = generateBestHourByTotalMeasure(measurePostsCounterArray);
            return hourWithMaxMeasurePerPost;
        }

        private void calcTotalMeasureOfPostTime(PostsCollection i_Posts, MeasurePostsCounter[] i_MeasurePostsCounterArray)
        {
            IEnumerator<Post> postsIterator = i_Posts.GetEnumerator();
            while(postsIterator.MoveNext())
            {
                // get post time
                try
                {
                    DateTime time = postsIterator.Current.CreatedTime.GetValueOrDefault();
                    int hour = time.Hour;
                    int totalMeasure = CalcTotalMeasureOfPost(postsIterator.Current);
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

        protected abstract int CalcTotalMeasureOfPost(Post i_Post);
    }
}
