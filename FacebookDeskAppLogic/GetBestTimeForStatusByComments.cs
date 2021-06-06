using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookDeskAppLogic
{
    public class GetBestTimeForStatusByComments : GetBestTimeForStatusBase
    {
        protected override int CalcTotalMeasureOfPost(Post i_Post)
        {
            return i_Post.Comments.Count;
        }
    }
}
