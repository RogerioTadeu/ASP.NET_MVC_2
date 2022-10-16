using SWE2_TP2_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWE2_TP2_4.DAO
{
    public class ContainerDAO
    {
        public IList<Container> Lista()
        {
            using (var contexto = new ManifestoContext())
            {

                return contexto.Containers.ToList();
            }
        }

        public void Adiciona(Models.Container produto)
        {
            using (var context = new ManifestoContext())
            {
                context.Containers.Add(produto);
                context.SaveChanges();
            }
        }
        public Container BuscaPorId(int id)
        {
            using (var contexto = new ManifestoContext())
            {
                return contexto.Containers.Find(id);
            }
        }
    }
}