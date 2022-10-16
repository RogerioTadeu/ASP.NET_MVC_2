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
    public class BLController : Controller
    {
        public ActionResult BLIndex()
        {
            BLDAO dao = new BLDAO();

            IList<BL> produtos = dao.Lista();
            ViewBag.BL = produtos;
            return View();

        }

        [HttpPost]
        public ActionResult Adiciona(BL categoria)
        {
            MessageBox.Show("Controller");
            MessageBox.Show(categoria.Consignee);
            BLDAO dao = new BLDAO();
            dao.Adiciona(categoria);
            return RedirectToAction("BLIndex");
        }
        public ActionResult BLForm()
        {

            return View();
        }
        public ActionResult BLPesquisa()
        {
            return View();
        }

        public ActionResult BLPesquisa2()
        {
            return View();
        }
        public ActionResult Pesquisa(int Id)
        {
            BLDAO dao = new BLDAO();
            ViewBag.Busca = dao.BuscaPorId(Id);
            MessageBox.Show(ViewBag.Busca.Numero.ToString());
            MessageBox.Show(ViewBag.Busca.Consignee);
            MessageBox.Show(ViewBag.Busca.Navio);
            return RedirectToAction("BLPesquisa2");

        }
    }
}