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
    public class ContaContabilInvestimentoesController : Controller
    {
        private BankingContext db = new BankingContext();

        // GET: ContaContabilInvestimentoes
        public ActionResult Index()
        {
            return View(db.ContaContabilInvestimentoes.ToList());
        }

        // GET: ContaContabilInvestimentoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContaContabilInvestimento contaContabilInvestimento = db.ContaContabilInvestimentoes.Find(id);
            if (contaContabilInvestimento == null)
            {
                return HttpNotFound();
            }
            return View(contaContabilInvestimento);
        }

        // GET: ContaContabilInvestimentoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContaContabilInvestimentoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id")] ContaContabilInvestimento contaContabilInvestimento)
        {
            if (ModelState.IsValid)
            {
                db.ContaContabilInvestimentoes.Add(contaContabilInvestimento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contaContabilInvestimento);
        }

        // GET: ContaContabilInvestimentoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContaContabilInvestimento contaContabilInvestimento = db.ContaContabilInvestimentoes.Find(id);
            if (contaContabilInvestimento == null)
            {
                return HttpNotFound();
            }
            return View(contaContabilInvestimento);
        }

        // POST: ContaContabilInvestimentoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id")] ContaContabilInvestimento contaContabilInvestimento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contaContabilInvestimento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contaContabilInvestimento);
        }

        // GET: ContaContabilInvestimentoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContaContabilInvestimento contaContabilInvestimento = db.ContaContabilInvestimentoes.Find(id);
            if (contaContabilInvestimento == null)
            {
                return HttpNotFound();
            }
            return View(contaContabilInvestimento);
        }

        // POST: ContaContabilInvestimentoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ContaContabilInvestimento contaContabilInvestimento = db.ContaContabilInvestimentoes.Find(id);
            db.ContaContabilInvestimentoes.Remove(contaContabilInvestimento);
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
