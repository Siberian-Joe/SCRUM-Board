using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumBoardNewDesign
{
    public class User
    {
        public string username { get; set; }
        public string fullName { get; set; }
        public bool canEdit { get; set; }
        public bool flag { get; set; }

        public User (string username, string fullName, bool canEdit)
        {
            this.username = username;
            this.fullName = fullName;
            this.canEdit = canEdit;
        }
    }
}
