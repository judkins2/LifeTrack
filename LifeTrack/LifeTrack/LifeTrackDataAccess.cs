using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeTrack
{
    class LifeTrackDataAccess
    {
        public List<Account> GetAccounts()
        {
            List<Account> _list = new List<Account>();

            using (HomeTrackEntities context = new HomeTrackEntities())
            {
                _list = context.Accounts.ToList();
                _list.Insert(0, new Account { NickName = "Please Select", Id = -1 });
                return _list;
            }
        }
        public List<Category> GetCategories()
        {
            List<Category> _list = new List<Category>();

            using (HomeTrackEntities context = new HomeTrackEntities())
            {
                _list = context.Categories.ToList();
                _list.Insert(0, new Category { Name = "Please Select", Id = -1 });
                return _list;
            }
        }
    }
}
