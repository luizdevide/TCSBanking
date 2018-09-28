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
    public class ContaContabilEmprestimoesController : Controller
    {
        private BankingContext db = new BankingContext();

        // GET: ContaContabilEmprestimoes
        public ActionResult Index()
        {
            return View(db.ContaContabilEmprestimoes.ToList());
        }

        // GET: ContaContabilEmprestimoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContaContabilEmprestimo contaContabilEmprestimo = db.ContaContabilEmprestimoes.Find(id);
            if (contaContabilEmprestimo == null)
            {
                return HttpNotFound();
            }
            return View(contaContabilEmprestimo);
        }

        // GET: ContaContabilEmprestimoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContaContabilEmprestimoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id")] ContaContabilEmprestimo contaContabilEmprestimo)
        {
            if (ModelState.IsValid)
            {
                db.ContaContabilEmprestimoes.Add(contaContabilEmprestimo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contaContabilEmprestimo);
        }

        // GET: ContaContabilEmprestimoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContaContabilEmprestimo contaContabilEmprestimo = db.ContaContabilEmprestimoes.Find(id);
            if (contaContabilEmprestimo == null)
            {
                return HttpNotFound();
            }
            return View(contaContabilEmprestimo);
        }

        // POST: ContaContabilEmprestimoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id")] ContaContabilEmprestimo contaContabilEmprestimo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contaContabilEmprestimo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contaContabilEmprestimo);
        }

        // GET: ContaContabilEmprestimoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContaContabilEmprestimo contaContabilEmprestimo = db.ContaContabilEmprestimoes.Find(id);
            if (contaContabilEmprestimo == null)
            {
                return HttpNotFound();
            }
            return View(contaContabilEmprestimo);
        }

        // POST: ContaContabilEmprestimoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ContaContabilEmprestimo contaContabilEmprestimo = db.ContaContabilEmprestimoes.Find(id);
            db.ContaContabilEmprestimoes.Remove(contaContabilEmprestimo);
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
