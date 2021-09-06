using Post.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Post.IDAL
{
    public interface INoticeDal
    {
        List<Notice> GetNoticeList();

        Notice GetNotice(int noticeNumber);

        bool PostNotice(Notice notice);

        bool UpdateNotice(Notice notice);

        bool DeleteNotice(int noticeNumber);
    }
}
