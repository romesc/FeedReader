using System;
using System.Collections.Generic;
using System.Linq;

namespace RSS_1.Classes
{
    public static class ItemDados
    {
        public static List<Item> RetornaNaoLidos()
        {
            List<Item> resItem;

            using (var context = new bancoRSSEntities())
            {
                resItem = context.Items
                    .Where(b => !(bool)b.item_lido).ToList();
            }

            return resItem;
        }

        public static Item Insert(Item oItem)
        {
            int QtRes = -1;

            // Ajuste dos campos
            if (oItem.item_dthr < DateTime.Now.AddYears(-1))
                oItem.item_dthr = DateTime.Now;

            while (oItem.item_titulo.Contains("  "))
            {
                oItem.item_titulo = oItem.item_titulo.Replace("  ", " ");
            }

            using (var context = new bancoRSSEntities())
            {
                Item resItem = context.Items
                    .Where(b => b.item_url.Equals(oItem))
                    .FirstOrDefault();

                if (resItem == null)
                {
                    try
                    {
                        context.Items.Add(oItem);
                        QtRes = context.SaveChanges();
                    }
                    catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                    {

                    }
                }
            }

            return oItem;
        }
    }
}
