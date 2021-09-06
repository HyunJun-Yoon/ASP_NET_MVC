using Microsoft.Extensions.Configuration;
using Post.DAL.DataContext;
using Post.IDAL;
using Post.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Post.DAL
{
    public class NoticeDal : INoticeDal
    {
        private readonly IConfiguration _config;

        public NoticeDal(IConfiguration config)
        {
            _config = config;
        }
        public List<Notice> GetNoticeList()
        {
            using (var db = new PostDbContext(_config))
            {
                return db.Notices
                    .OrderByDescending(n=>n.NoticeNumber)
                    .ToList();
            }
        }

        public Notice GetNotice(int noticeNumber)
        {
            throw new NotImplementedException();
        }

        public bool PostNotice(Notice notice)
        {
            throw new NotImplementedException();
        }

        public bool UpdateNotice(Notice notice)
        {
            throw new NotImplementedException();
        }
        public bool DeleteNotice(int noticeNumber)
        {
            throw new NotImplementedException();
        }

    }
}
