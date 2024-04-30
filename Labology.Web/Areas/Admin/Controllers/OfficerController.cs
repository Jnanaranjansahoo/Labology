using Labology.DataAcess.Repository.IRepository;
using Labology.Models;
using Microsoft.AspNetCore.Mvc;

namespace Labology.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OfficerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public OfficerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Officer> objOfficerList = _unitOfWork.Officer.GetAll().ToList();
            return View(objOfficerList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Officer obj)
        {
            if (obj.Name == obj.Cost.ToString())
            {
                ModelState.AddModelError("name", "The DisplayOrder cannot exactly match the Name.");
            }
            if (ModelState.IsValid)
            {
                _unitOfWork.Officer.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Officer Created Successfully";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Officer? officerFromDb = _unitOfWork.Officer.Get(u => u.Id == id);
            //Officer? categoryFromDb1 = _db.Categories.FirstOrDefault(u => u.Id == id);
            //Officer? categoryFromDb2 = _db.Categories.Where(u=>u.Id==id).FirstOrDefault();
            if (officerFromDb == null)
            {
                return NotFound();
            }

            return View(officerFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Officer obj)
        {

            if (ModelState.IsValid)
            {
                _unitOfWork.Officer.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Officer Update Successfully";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Officer? officerFromDb = _unitOfWork.Officer.Get(u => u.Id == id);
            if (officerFromDb == null)
            {
                return NotFound();
            }

            return View(officerFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Officer? obj = _unitOfWork.Officer.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _unitOfWork.Officer.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Officer Deleted Successfully";
            return RedirectToAction("Index");
        }
    }
}
