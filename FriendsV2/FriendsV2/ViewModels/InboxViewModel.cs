using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FriendsV2.Models;

namespace FriendsV2.ViewModels
{
    public class InboxViewModel
    {
        public IEnumerable<MailMessages> mailMessages;
        public IEnumerable<BuildUser> fromProfile;
    }
}
