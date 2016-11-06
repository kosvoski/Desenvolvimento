using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class FuncionarioController : Controller
    {
        desenvolvimentoEntities db = new desenvolvimentoEntities();

        public ActionResult Index()
        {
            return View(db.Funcionario.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                funcionario.foto = "";

                db.Funcionario.Add(funcionario);
                db.SaveChanges();

                HttpPostedFileBase arquivo = Request.Files[0];

                if (arquivo.ContentLength > 0)
                {
                    string nomeDaFoto = funcionario.id.ToString() + Path.GetExtension(arquivo.FileName);
                    var uploadPath = Server.MapPath("~/Content/Uploads");

                    arquivo.SaveAs(Path.Combine(uploadPath, nomeDaFoto));
                                                               
                    funcionario.foto = Path.Combine("/Content/Uploads/",nomeDaFoto);

                    db.Entry(funcionario).State = EntityState.Modified;
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            return View(funcionario);
        }

        public ActionResult Details(int id)
        {
            Funcionario funcionario = db.Funcionario.Find(id);
            if (funcionario == null)
            {
                return HttpNotFound();
            }
            return View(funcionario);
        }

        public ActionResult Edit(int id = 0)
        {
            Funcionario funcionario = db.Funcionario.Find(id);
            if (funcionario == null)
            {
                return HttpNotFound();
            }

            return View(funcionario);
        }

        [HttpPost]
        public ActionResult Edit(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                if (funcionario.deleteFoto)
                    funcionario.foto = "";

                db.Entry(funcionario).State = EntityState.Modified;
                db.SaveChanges();

                HttpPostedFileBase arquivo = Request.Files[0];

                if (arquivo.ContentLength > 0)
                {
                    string nomeDaFoto = funcionario.id.ToString() + Path.GetExtension(arquivo.FileName);
                    var uploadPath = Server.MapPath("~/Content/Uploads");

                    arquivo.SaveAs(Path.Combine(uploadPath, nomeDaFoto));

                    funcionario.foto = Path.Combine("/Content/Uploads/", nomeDaFoto);

                    db.Entry(funcionario).State = EntityState.Modified;
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            return View(funcionario);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funcionario funcionario = db.Funcionario.Find(id);
            if (funcionario == null)
            {
                return HttpNotFound();
            }
            return View(funcionario);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Funcionario funcionario = db.Funcionario.Find(id);

            string fotoDoFuncionario = Server.MapPath("~" + funcionario.foto);

            db.Funcionario.Remove(funcionario);
            db.SaveChanges();

            if (System.IO.File.Exists(fotoDoFuncionario))
            {
                System.IO.File.Delete(fotoDoFuncionario);
            }            

            return RedirectToAction("Index");
        }
    }
}