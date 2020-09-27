using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlockFriends.Models;

namespace BlockFriends.ViewModels
{
    public class InboxViewModel
    {
        public IEnumerable<MailMessages> mailMessages;
        public IEnumerable<BuildUser> fromProfiles;
    }
}
