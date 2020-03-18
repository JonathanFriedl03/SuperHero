using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroes.Data;
using SuperHeroes.Models;

namespace SuperHeroes.Controllers
{
    
    public class SuperHeroController : Controller
    {
        public ApplicationDbContext db;//global variable passed in to the below parameter
        public SuperHeroController(ApplicationDbContext context)
        {
           db = context; //this gives full access to database
        }
        // GET: SuperHero
        public ActionResult Index()
        {
            var superHeroes = db.SuperHeroes;
            return View(superHeroes);
        }

        // GET: SuperHero/Details/5
        public ActionResult Details(int id)
        {
            SuperHero superHero = db.SuperHeroes.Where(a => a.Id == id).FirstOrDefault();
            return View(superHero);
        }

        // GET: SuperHero/Create
        public ActionResult Create()
        {
            SuperHero superHero = new SuperHero();
            return View(superHero);
        }

        // POST: SuperHero/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SuperHero superHero)
        {
            try//could also do an if statement using (ModelState.Isvalid)which is a dictionary thats stores user input 
                    //isvalid relates to requirements initiated in the superhero cs which i commented out..theres more that can be done in view pg for error displaying
                        //then do the following...cool to try as a turnary statement but not sure how
            {
                // TODO: Add insert logic here
               db.SuperHeroes.Add(superHero);
                db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHero/Edit/5
        public ActionResult Edit(int id)
        {
            //SuperHero superhero = db.SuperHeroes.Where(a => a.Id == id).FirstOrDefault();
            //return View(superhero);
                return View(db.SuperHeroes.Find(id));//find works with the primary key 
        }

        // POST: SuperHero/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SuperHero superHero)
        {
            try
            {
                // TODO: Add update logic here 
                db.SuperHeroes.Update(superHero);//this is so cool compared to creating new instance searching then having to write out each property
                db.SaveChanges();               //as cool that theyre the top options with dot notation
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("Edit");
            }
        }

        // GET: SuperHero/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.SuperHeroes.Find(id));
        }

        // POST: SuperHero/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, SuperHero superHero)
        {
            try
            {
                // TODO: Add delete logic here
                db.SuperHeroes.Remove(superHero);//and can use same logic as update
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("Delete");
            }
        }
    }
}