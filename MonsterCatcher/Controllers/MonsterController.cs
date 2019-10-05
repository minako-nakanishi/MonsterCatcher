using MonsterCatcher.Models;
using System.Web.Mvc;

namespace MonsterCatcher.Controllers
{
    public class MonsterController : Controller
    {
        private MvcBasicContext db = new MvcBasicContext();

        /// <summary>
        /// 一覧画面表示
        /// </summary>
        public ActionResult Index()
        {
            return View(db.Monsters);
        }


    }
}