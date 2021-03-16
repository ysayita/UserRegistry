using System;

namespace UserDataContext.ViewModels
{
    public class UserQueryVM
    {
        public int? id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string status { get; set; }
        public bool HasParameterFilled =>
            id.HasValue ||
            !string.IsNullOrEmpty(name) ||
            !string.IsNullOrEmpty(email) ||
            !string.IsNullOrEmpty(gender) ||
            !string.IsNullOrEmpty(status);
    }
}