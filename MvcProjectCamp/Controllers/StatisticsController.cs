using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectCamp.Controllers
{
    public class StatisticsController : Controller
    {
        // GET: Statistics
        CategoryManagerBL cm = new CategoryManagerBL(new EfCategoryDAL());
        Context db = new Context();
        Statistics stats = new Statistics();
        public ActionResult Index()
        {
            //1. Soru: Toplam Kategori Sayısı
            stats.TotalCategoryCount = cm.GetList().Count();

            //2. Soru: Başlık tablosunda "yazılım" kategorisine ait başlık sayısı
            stats.TotalSoftwareCategoryCount = db.Headings.Count(x => x.Category.CategoryName == "Yazılım");

            //3. Soru: Yazar adında 'a' harfi geçen yazar sayısı
            stats.TotalWriterLetterACount = db.Writers.Count(x => x.WriterName.ToLower().Contains("a"));

            //4. Soru: En fazla başlığa sahip kategori adı
            stats.MaxHeadingCategoryName = cm.GetList().Where(x => x.CategoryID == db.Headings.ToList()
            .GroupBy(y => y.CategoryID).ToList().OrderBy(z => z.Count()).Last().Key).FirstOrDefault().CategoryName;

            //5. Soru: Kategori tablosunda durumu true olan kategoriler ile false olan kategoriler arasındaki
            //sayısal fark
            stats.DifferenceCategoryStatus = cm.GetList().Where(x => x.CategoryStatus == true).Count() -
                cm.GetList().Where(x => x.CategoryStatus == false).Count();

            return View(stats);
        }
    }
}