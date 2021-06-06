using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookDeskAppLogic
{
    public class GetBestTimeForStatusByLikes : GetBestTimeForStatusBase
    {
        public override int calcTotalMeasureOfPost(Post i_Post)
        {
            return i_Post.LikedBy.Count();
        }
    }
}
