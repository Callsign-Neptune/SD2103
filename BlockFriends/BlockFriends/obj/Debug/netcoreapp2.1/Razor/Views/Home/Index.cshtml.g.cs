#pragma checksum "C:\Users\ACT-Student\Documents\SD2103\BlockFriends\BlockFriends\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c7067dd20c02cce7bb3c8e659f2e33a65cfe192"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\ACT-Student\Documents\SD2103\BlockFriends\BlockFriends\Views\_ViewImports.cshtml"
using BlockFriends;

#line default
#line hidden
#line 2 "C:\Users\ACT-Student\Documents\SD2103\BlockFriends\BlockFriends\Views\_ViewImports.cshtml"
using BlockFriends.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c7067dd20c02cce7bb3c8e659f2e33a65cfe192", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b62f1e202b77520d03aa08d5a477309aa3544db", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\ACT-Student\Documents\SD2103\BlockFriends\BlockFriends\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 40, true);
            WriteLiteral("\r\n﻿<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(85, 483, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f86142d955a43a2bd925717bf5ed5e3", async() => {
                BeginContext(91, 470, true);
                WriteLiteral(@"

  <meta charset=""utf-8"">
  <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
  <meta name=""description"" content="""">
  <meta name=""author"" content="""">

  <title>Modern Business - Start Bootstrap Template</title>

  <!-- Bootstrap core CSS -->
  <link href=""vendor/bootstrap/css/bootstrap.min.css"" rel=""stylesheet"">

  <!-- Custom styles for this template -->
  <link href=""css/modern-business.css"" rel=""stylesheet"">

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(568, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(572, 13088, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e33740fad8414280b76844125179d7a5", async() => {
                BeginContext(578, 13075, true);
                WriteLiteral(@"

  <!-- Navigation -->
  <nav class=""navbar fixed-top navbar-expand-lg navbar-dark bg-dark fixed-top"">
    <div class=""container"">
      <a class=""navbar-brand"" href=""Home.html""  style=""font-size:40px"" >Friends on the Block</a>
      <button class=""navbar-toggler navbar-toggler-right"" type=""button"" data-toggle=""collapse"" data-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
        <span class=""navbar-toggler-icon""></span>
      </button>
      <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
        <ul class=""navbar-nav ml-auto"">
          
          <li class=""nav-item"">
            <a class=""nav-link"" href=""services.html"">Discords</a>
          </li>
          <li class=""nav-item"">
            <a class=""nav-link"" href=""contact.html"">Contact</a>
          </li>
          <li class=""nav-item dropdown"">
            <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdownPortfolio"" data-toggle=""dropdown"" ar");
                WriteLiteral(@"ia-haspopup=""true"" aria-expanded=""false"">
              Portfolio
            </a>
            <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""navbarDropdownPortfolio"">
              <a class=""dropdown-item"" href=""portfolio-1-col.html"">1 Column Portfolio</a>
              <a class=""dropdown-item"" href=""portfolio-2-col.html"">2 Column Portfolio</a>
              <a class=""dropdown-item"" href=""portfolio-3-col.html"">3 Column Portfolio</a>
              <a class=""dropdown-item"" href=""portfolio-4-col.html"">4 Column Portfolio</a>
              <a class=""dropdown-item"" href=""portfolio-item.html"">Single Portfolio Item</a>
            </div>
          </li>
          <li class=""nav-item dropdown"">
            <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdownBlog"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
              Blog
            </a>
            <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""navbarDropdownBlog"">
              ");
                WriteLiteral(@"<a class=""dropdown-item"" href=""blog-home-1.html"">Blog Home 1</a>
              <a class=""dropdown-item"" href=""blog-home-2.html"">Blog Home 2</a>
              <a class=""dropdown-item"" href=""blog-post.html"">Blog Post</a>
            </div>
          </li>
          <li class=""nav-item"">
              <a class=""nav-link"" href=""about.html"">About</a>
          </li>
            <li class=""nav-item"">
              <a class=""nav-link"" href=""about_me_profile.html"">My Profile</a>
          </li>
        </ul>
      </div>
    </div>
  </nav>

  <header>
    <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
      <ol class=""carousel-indicators"">
        <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
        <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
        <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
      </ol>
      <div class=""carousel-inner"" role=""listbox"">
        <!-- Slid");
                WriteLiteral(@"e One - Set the background image for this slide in the line below -->
        <div class=""carousel-item active"" style=""background-image: url('https://1gew6o3qn6vx9kp3s42ge0y1-wpengine.netdna-ssl.com/wp-content/uploads/2014/09/Xbox_MinecraftDay_1310x6551.jpg') "">
          <div class=""carousel-caption d-none d-md-block"">
          </div>
        </div>
        <!-- Slide Two - Set the background image for this slide in the line below -->
        <div class=""carousel-item"" style=""background-image: url('https://art.ngfiles.com/images/348000/348402_victycoon_minecraft-3-friends.png?f1426717517') "">
          <div class=""carousel-caption d-none d-md-block"">
            <h3 style=""font-size:40px"" >Fight with your Friends!</h3>
            <p  style=""font-size:35px"" >Many of us love to get out there and fight some monsters, find a friend and cream those creeps.</p>
          </div>
        </div>
        <!-- Slide Three - Set the background image for this slide in the line below -->
        <div class=");
                WriteLiteral(@"""carousel-item"" style=""background-image: url('https://i.redd.it/0gb82u995w431.png') "">
          <div class=""carousel-caption d-none d-md-block"">
            <h3 style=""font-size:40px"" ><span>Build with your Friends!</span></h3>
            <p style=""font-size:35px"" >If fighting monsters isn't your thing, build beautiful structures and satisfy that creative itch.</p>
          </div>
        </div>
      </div>
      <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
      </a>
      <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
      </a>
    </div>
  </header>

  <!-- Page Content -->
  <div class=""container"">

    <h1 class=""my-4"">Welcome to Friends");
                WriteLiteral(@" on the Block!</h1>

    <!-- Marketing Icons Section -->
    <div class=""row"">
      <div class=""col-lg-4 mb-4"">
        <div class=""card h-100"">
          <h4 class=""card-header"">Helping Out</h4>
          <div class=""card-body"">
            <p class=""card-text"">If you ever need help with something in game, make a post and someone will definitely try to help! If a quicker answer is needed, use the Wiki. We all love it and reference it frequently. Click below to check it out!</p>
          </div>
          <div class=""card-footer"">
            <a href=""https://minecraft.gamepedia.com/Minecraft_Wiki"" class=""btn btn-primary"">Learn More</a>
          </div>
        </div>
      </div>
      <div class=""col-lg-4 mb-4"">
        <div class=""card h-100"">
          <h4 class=""card-header"">Java Update</h4>
          <div class=""card-body"">
            <p class=""card-text"">Check out the latest patch notes for Java! Lots of new tweaks and additions.</p>
          </div>
          <div class=""card-f");
                WriteLiteral(@"ooter"">
            <a href=""https://www.minecraft.net/en-us/article/minecraft-java-edition-1-16-2"" class=""btn btn-primary"">Learn More</a>
          </div>
        </div>
      </div>
      <div class=""col-lg-4 mb-4"">
        <div class=""card h-100"">
          <h4 class=""card-header"">Customize your Skin</h4>
          <div class=""card-body"">
            <p class=""card-text"">Ever get tired of staring at the same character skin? We did, so we went looking for the best skins we could find. Here is a great site to find one that suits you. Haha, suits, get it?</p>
          </div>
          <div class=""card-footer"">
            <a href=""https://www.minecraftskins.com/"" class=""btn btn-primary"">Learn More</a>
          </div>
        </div>
      </div>
    </div>
    <!-- /.row -->

    <!-- Portfolio Section -->
    <h2>Projects in the Community</h2>

    <div class=""row"">
      <div class=""col-lg-4 col-sm-6 portfolio-item"">
        <div class=""card h-100"">
          <a href=""#""><img class");
                WriteLiteral(@"=""card-img-top"" src=""https://www.cyclone.co.nz/wp-content/uploads/2019/12/Minecraft-Hour-Of-Code.png"" alt=""""></a>
          <div class=""card-body"">
            <h4 class=""card-title"">
              <a href=""contact.html"">Educating Crafters</a>
            </h4>
            <p class=""card-text"">We would love to set up a group of people willing to walk new players throught the basics of Minecraft! If interested, please click above to contact one of us and be added to this group.</p>
          </div>
        </div>
      </div>
      <div class=""col-lg-4 col-sm-6 portfolio-item"">
        <div class=""card h-100"">
          <a href=""#""><img class=""card-img-top"" src=""https://mcpedl.com/wp-content/uploads/2018/12/medieval-town-4.jpg"" alt=""""></a>
          <div class=""card-body"">
            <h4 class=""card-title"">
              <a href=""#"">Castle-mania</a>
            </h4>
            <p class=""card-text"">Welcome to one of our themed projects, Castle-mania. If you appreciate the Medieval Ages and wa");
                WriteLiteral(@"nt to recreate or invent your own castles and villages, then join these fellows. Their work with stone will amaze you!</p>
          </div>
        </div>
      </div>
      <div class=""col-lg-4 col-sm-6 portfolio-item"">
        <div class=""card h-100"">
          <a href=""#""><img class=""card-img-top"" src=""https://blog.connectedcamps.com/wp-content/uploads/2016/12/roman-town-minecraft-4-1024x640-700x400.jpeg"" alt=""""></a>
          <div class=""card-body"">
            <h4 class=""card-title"">
              <a href=""#"">The Pantheon Project</a>
            </h4>
            <p class=""card-text"">Welcome to one of our themed projects, The Pantheon Project. If you appreciate Greek architecture and want to recreate or invent your own, then join this group. They are doing great work and are continuing to amaze us all every day!</p>
          </div>
        </div>
      </div>
      <div class=""col-lg-4 col-sm-6 portfolio-item"">
        <div class=""card h-100"">
          <a href=""#""><img class=""card-img-");
                WriteLiteral(@"top"" src=""https://www.planetminecraft.com/files/image/minecraft/project/2020/354/12679373_l.jpg"" alt=""""></a>
          <div class=""card-body"">
            <h4 class=""card-title"">
              <a href=""#"">Project Osaka</a>
            </h4>
            <p class=""card-text"">Welcome to one of our themed projects, Project Osaka. If you adore Japanese culture and architecture as much as most of our members, this is the group for you! The lanterns are my favorite so use lots of them! </p>
          </div>
        </div>
      </div>
      <div class=""col-lg-4 col-sm-6 portfolio-item"">
        <div class=""card h-100"">
          <a href=""#""><img class=""card-img-top"" src=""https://quantuvis.files.wordpress.com/2013/04/showcase-2-800.png"" alt=""""></a>
          <div class=""card-body"">
            <h4 class=""card-title"">
              <a href=""#"">Project Big Apple</a>
            </h4>
            <p class=""card-text"">Welcome to one of our themed projects, Project Big Apple. You'll not get any sleep in th");
                WriteLiteral(@"is city world but the views are worth it! P.S. Theres an open manhole on 32nd with one block of water in it... Happy skydiving... muyahahaha!</p>
          </div>
        </div>
      </div>
      <div class=""col-lg-4 col-sm-6 portfolio-item"">
        <div class=""card h-100"">
          <a href=""#""><img class=""card-img-top"" src=""https://minecraftbuildinginc.com/wp-content/uploads/2015/08/Futuristic-Palace-V2-minecraft-building-ideas-download-sea-water-tower-amazing-4.jpg"" alt=""""></a>
          <div class=""card-body"">
            <h4 class=""card-title"">
              <a href=""#"">Project Atlantis</a>
            </h4>
            <p class=""card-text"">Welcome to one of our themed projects, Project Atlantis. Whatever iteration of the lost city you enjoy, youll enjoy the scenic view from the Citadels Spire. Sit back, relax and repel those Drowned!</p>
          </div>
        </div>
      </div>
    </div>
    <!-- /.row -->

    <!-- Features Section -->
    <div class=""row"">
      <div class=""");
                WriteLiteral(@"col-lg-6"">
        <h2>Our Discord's Features</h2>
        <p>The Discord our homies use includes:</p>
        <ul>
          <li>
            <strong>Discord v4</strong>
          </li>
          <li>Chill and Relaxing Environment</li>
          <li>Knowledgeable players with lots of experience</li>
          <li>Music bots to set the mood</li>
          <li>Forums to ask questions and get bedrock solid answers</li>
        </ul>
        <p>We have been using Discord for over 5 years to bring people together. It has been tremendously helpful in our endeavors and we appreciate that everyone has donated to upgrade it to a Nitro Server! Have fun in the chats. Enjoy the plentiful memes. As always, keep building.</p>
      </div>
      <div class=""col-lg-6"">
        <img class=""img-fluid rounded"" src=""https://en.mogaznews.com/temp/resized/medium_2020-01-13-aec997d599.jpg"" alt="""">
      </div>
    </div>
    <!-- /.row -->

    <hr>

    <!-- Call to Action Section -->
    <div class=""row mb");
                WriteLiteral(@"-4"">
      <div class=""col-md-8"">
        <p>Our server is a chill place to relax with your friends and play some tunes. Get in loser, we're going mining!</p>
      </div>
      <div class=""col-md-4"">
        <a class=""btn btn-lg btn-secondary btn-block"" href=""https://top.gg/servers/712894457560956968"">Join the Discord</a>
      </div>
    </div>

  </div>
  <!-- /.container -->

  <!-- Footer -->
  <footer class=""py-5 bg-dark"">
    <div class=""container"">
      <p class=""m-0 text-center text-white"">Copyright &copy; Friends on the Block 2020</p>
    </div>
    <!-- /.container -->
  </footer>

  <!-- Bootstrap core JavaScript -->
  <script src=""vendor/jquery/jquery.min.js""></script>
  <script src=""vendor/bootstrap/js/bootstrap.bundle.min.js""></script>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(13660, 13, true);
            WriteLiteral("\r\n\r\n</html>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591