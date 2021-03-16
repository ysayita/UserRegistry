using System.Collections.Generic;
using UserModels;

namespace UserDataContext.ViewModels
{
    public class UsersQueryResultVM
    {
        public int Code { get; set; }
        public MetaVM Meta { get; set; }
        public IEnumerable<User> Data { get; set; }
    }
}
