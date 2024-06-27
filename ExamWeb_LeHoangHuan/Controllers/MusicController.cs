using ExamWeb_LeHoangHuan.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWeb_LeHoangHuan.Controllers
{
    public class MusicController : Controller
    {
        private readonly ApplicationDbContext _db;
        public MusicController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var dsDiaNhac = _db.DiaNhacs.ToList();
            decimal tongsoluong = _db.DiaNhacs.Sum(x => x.SoLuong);
            ViewBag.SUM = tongsoluong;
            return View(dsDiaNhac);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(DiaNhac dianhac)
        {
            if (ModelState.IsValid)
            {
                _db.DiaNhacs.Add(dianhac);
                _db.SaveChanges();
                TempData["success"] = "Đã thêm 1 Đĩa nhạc";
                return RedirectToAction("Index");
            }
            return View(dianhac);
        }
        public IActionResult Update(int id)
        {
            var book = _db.DiaNhacs.SingleOrDefault(x => x.Id == id);
            if (book != null)
                return View(book);

            return NotFound();
        }

        [HttpPost]
        public IActionResult Update(DiaNhac dianhac)
        {
            if (ModelState.IsValid)
            {
                _db.DiaNhacs.Update(dianhac);
                _db.SaveChanges();
                TempData["success"] = "Đã cập nhật 1 Đĩa nhạc";
                return RedirectToAction("Index");
            }
            return View(dianhac);
        }
        public IActionResult Delete(int id)
        {
            var product = _db.DiaNhacs.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var product = _db.DiaNhacs.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            _db.DiaNhacs.Remove(product);
            _db.SaveChanges();
            TempData["success"] = "Đã xoá Đĩa Nhạc thành công";
            return RedirectToAction("Index");
        }

    }
}
