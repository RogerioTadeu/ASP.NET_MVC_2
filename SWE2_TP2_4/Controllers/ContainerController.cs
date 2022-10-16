using SWE2_TP2_4.DAO;
using SWE2_TP2_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;

namespace SWE2_TP2_4.Controllers
{
    public class ContainerController : Controller
    {
        public ActionResult ContainerIndex()
        {
            ContainerDAO dao = new ContainerDAO();

            IList<Container> produtos = dao.Lista();
            ViewBag.Container = produtos;

            return View();
        }

        [HttpPost]
        public ActionResult Adiciona(Container categoria)
        {
            ContainerDAO dao = new ContainerDAO();
            dao.Adiciona(categoria);
            return RedirectToAction("ContainerIndex");
        }

        public ActionResult ContainerForm()
        {
            return View();
        }
        public ActionResult ContainerPesquisa()
        {
            return View();
        }

        public ActionResult ContainerPesquisa2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Pesquisa(int Id)
        {
           // Container cont = new Container();
            ContainerDAO dao = new ContainerDAO();
            //Container cont = dao.BuscaPorId(Id);
            ViewBag.Busca = dao.BuscaPorId(Id);
            //MessageBox.Show(cont.Numero.ToString());
            //MessageBox.Show(cont.Numero.ToString());
            MessageBox.Show(ViewBag.Busca.Tipo);
            MessageBox.Show(ViewBag.Busca.Tipo);
            //MessageBox.Show(ViewBag.Busca.Tamanho);
            return RedirectToAction("ContainerPesquisa2", ViewBag.Busca);

        }
    }
}