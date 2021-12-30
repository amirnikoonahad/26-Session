using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _26_Session.Models;
using sessions;

namespace _26_Session.Controllers
{
    public class HomeController : Controller
    {
        public readonly conect _conect;

        public HomeController(conect conect)
        {
            _conect = conect;
        }

        public IActionResult Index()
        {
            var list= _conect.studants.ToList();
            return View(list);
        }

        public IActionResult Add(Vm_studant f)
        {
          
            Studant s = new Studant();
            s.name = f.name;
            s.family =f.family;
            _conect.studants.Add (s);
            _conect.SaveChanges();
            return RedirectToAction("index");
        }




         
         public IActionResult r()
        {
            
        
            return View();
            
        }
     public IActionResult Delete(int id)
     {
         var select=_conect.studants.Where(a=>a.id==id).SingleOrDefault();
         _conect.studants.Remove(select);
         _conect.SaveChanges();
         return RedirectToAction("Index");
     }
     

        public IActionResult Update(int id)
        {
            var select=_conect.studants.Where(a=>a.id==id).SingleOrDefault();
            return View(select);
        }
        [HttpPost]
        public IActionResult Update(Studant st)
        {
            var select=_conect.studants.Where(a=>a.id==st.id).SingleOrDefault();
            select.name=st.name;
            select.family=st.family;
            _conect.studants.Update(select);
            _conect.SaveChanges();
        
            return RedirectToAction("index");
        }
    }
}
