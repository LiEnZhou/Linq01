using Linq01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Linq01.Controllers
{
    public class HomeController : Controller
    {
        private static List<Context> _context = new List<Context>()
        {
            new Context(){Medal="金牌", Name="郭婞淳",Sport="舉重",PrizeMoney=20000000},
            new Context(){Medal="金牌", Name="李洋、王齊麟",Sport="羽球",PrizeMoney=20000000},
            new Context(){Medal="銀牌", Name="楊勇緯",Sport="柔道",PrizeMoney=7000000},
            new Context(){Medal="銀牌", Name="鄧宇成、湯智鈞、魏均珩",Sport="射箭",PrizeMoney=7000000},
            new Context(){Medal="銀牌", Name="李智凱",Sport="體操",PrizeMoney=7000000},
            new Context(){Medal="銀牌", Name="戴資穎",Sport="羽球",PrizeMoney=7000000},
            new Context(){Medal="銅牌", Name="羅嘉翎",Sport="跆拳道",PrizeMoney=5000000},
            new Context(){Medal="銅牌", Name="林昀儒、鄭怡靜",Sport="桌球",PrizeMoney=5000000},
            new Context(){Medal="銅牌", Name="陳玟卉",Sport="舉重",PrizeMoney=5000000},
            new Context(){Medal="銅牌", Name="潘政琮",Sport="高爾夫",PrizeMoney=5000000},
            new Context(){Medal="銅牌", Name="黃筱雯",Sport="拳擊",PrizeMoney=5000000},
            new Context(){Medal="銅牌", Name="文姿云",Sport="空手道",PrizeMoney=5000000},
        };
        public ActionResult LinqHomework()
        {
            var AllMedal = _context.Where(x => x.Medal == "金牌").ToList();
            var badminton = _context.Where(x => x.Sport == "羽球").ToList();
            var prize = _context.OrderBy(x => x.PrizeMoney).ToList();
            var highprize = _context.Where(x => x.PrizeMoney > 10000000).ToList();
            var sumprize = _context.Sum(x => x.PrizeMoney);

            var badmintonPrize=_context.Where(x => x.Sport =="羽球").Sum(x => x.PrizeMoney);
            var MedalPrize = _context.Where(x => x.Medal == "銀牌").Sum(x => x.PrizeMoney);
                return RedirectToAction();
        }
        public IActionResult Index()
        {
            return View(_context);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}