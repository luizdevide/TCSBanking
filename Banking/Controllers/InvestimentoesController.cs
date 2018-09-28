using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Banking;
using Banking.Models;

namespace Banking.Controllers
{
    public class InvestimentoesController : Controller
    {
        private BankingContext db = new BankingContext();

        // GET: Investimentoes
        public ActionResult Index()
        {
            return View(db.Investimentoes.ToList());
        }

        // GET: Investimentoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Investimento investimento = db.Investimentoes.Find(id);
            if (investimento == null)
            {
                return HttpNotFound();
            }
            return View(investimento);
        }

        // GET: Investimentoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Investimentoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,tipoTaxa,valor,dataEntrada,dataResgate")] Investimento investimento)
        {
            if (ModelState.IsValid)
            {
                db.Investimentoes.Add(investimento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(investimento);
        }

        // GET: Investimentoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Investimento investimento = db.Investimentoes.Find(id);
            if (investimento == null)
            {
                return HttpNotFound();
            }
            return View(investimento);
        }

        // POST: Investimentoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,tipoTaxa,valor,dataEntrada,dataResgate")] Investimento investimento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(investimento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(investimento);
        }

        // GET: Investimentoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Investimento investimento = db.Investimentoes.Find(id);
            if (investimento == null)
            {
                return HttpNotFound();
            }
            return View(investimento);
        }

        // POST: Investimentoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Investimento investimento = db.Investimentoes.Find(id);
            db.Investimentoes.Remove(investimento);
            db.SaveChanges();
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
