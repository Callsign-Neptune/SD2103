using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using FriendsV2.Models;
using FriendsV2.ViewModels;

namespace FriendsV2.Controllers
{
    public class MessagesController : Controller
    {
        private MinecraftV2Context _context;
        private UserManager<IdentityUser> _userManager;
        public MessagesController(MinecraftV2Context context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Inbox()
        {
            BuildUser profile = _context.BuildUser.FirstOrDefault(id =>
            id.UserAccountId == _userManager.GetUserId(User));

            InboxViewModel inbox = new InboxViewModel();
            inbox.mailMessages = _context.MailMessages.Where(to => to.ToProfileId == profile.Id).ToList();

            List<BuildUser> fromList = new List<BuildUser>();
            foreach (var msg in inbox.mailMessages)
            {
                fromList.Add(_context.BuildUser.FirstOrDefault(from => from.Id == msg.FromProfileId));
            }
            inbox.fromProfile = fromList;
            return View(inbox);
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewMessage(int id)
        {
            ViewBag.ToProfileId = id;
            return View();
        }

        public IActionResult Read(int id)
        {
            MailMessages mail = _context.MailMessages.FirstOrDefault(m => m.Id == id);
            mail.IsRead = true;
            _context.Update(mail);
            _context.SaveChanges();
            return View(mail);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Send([Bind("MessageTitle, MessageText")] MailMessages mail, int toProfileId)
        {
            BuildUser fromUser = _context.BuildUser.FirstOrDefault(p => p.UserAccountId == _userManager.GetUserId(User));
            mail.FromProfileId = fromUser.Id;
            mail.IsRead = false;
            mail.FromProfile = fromUser;
            mail.ToProfileId = toProfileId;

            _context.Add(mail);
            _context.SaveChanges();

            return RedirectToAction("Browse", "BuildUsers");
        }
    }
}
