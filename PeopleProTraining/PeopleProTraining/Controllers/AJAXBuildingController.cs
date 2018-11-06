using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PeopleProTraining.Dal.Models;

namespace PeopleProTraining.Controllers
{
    public class AJAXBuildingController : Controller
    {
        private PeopleProDataBaseEntities db = new PeopleProDataBaseEntities();

        // GET: AJAXBuilding
        public async Task<ActionResult> Index()
        {
            return View(await db.Buildings.ToListAsync());
        }

        // GET: AJAXBuilding/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Building building = await db.Buildings.FindAsync(id);
            if (building == null)
            {
                return HttpNotFound();
            }
            return View(building);
        }

        // GET: AJAXBuilding/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AJAXBuilding/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "BuildingId,BuildingName")] Building building)
        {
            if (ModelState.IsValid)
            {
                db.Buildings.Add(building);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(building);
        }

        // GET: AJAXBuilding/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Building building = await db.Buildings.FindAsync(id);
            if (building == null)
            {
                return HttpNotFound();
            }
            return View(building);
        }

        // POST: AJAXBuilding/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "BuildingId,BuildingName")] Building building)
        {
            if (ModelState.IsValid)
            {
                db.Entry(building).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(building);
        }

        // GET: AJAXBuilding/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Building building = await db.Buildings.FindAsync(id);
            if (building == null)
            {
                return HttpNotFound();
            }
            return View(building);
        }

        // POST: AJAXBuilding/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Building building = await db.Buildings.FindAsync(id);
            db.Buildings.Remove(building);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
