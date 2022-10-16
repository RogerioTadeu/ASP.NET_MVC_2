using SWE2_TP2_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace SWE2_TP2_4.DAO
{
    public class BLDAO
    {
        public IList<BL> Lista()
        {
            using (var contexto = new ManifestoContext())
            {

                return contexto.BLs.ToList();
            }
        }

        public void Adiciona(BL produto)
        {
            //foreach (BL produtos in produto)
            ////    dao.Adiciona(produto);
            //{
            MessageBox.Show("DAO");
            MessageBox.Show(produto.Consignee);
                
            //}
            using (var context = new ManifestoContext())
            {
                context.BLs.Add(produto);
                context.SaveChanges();
            }
        }

        public BL BuscaPorId(int id)
        {
            using (var contexto = new ManifestoContext())
            {
                return contexto.BLs.Find(id);
            }
        }
    }
}