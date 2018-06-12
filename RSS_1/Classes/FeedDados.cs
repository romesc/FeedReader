using System;
using System.Collections.Generic;
using System.Linq;

namespace RSS_1.Classes
{
    public static class FeedDados
    {
        public static List<Feed> RetornaNaoLidos()
        {
            List<Feed> resFeed;

            using (var context = new bancoRSSEntities())
            {
                resFeed = context.Feeds
                    .Where(b => b.feed_qt_nao_lidos.Value > 0).ToList();
            }

            return resFeed;
        }

        public static Feed Insert(Feed oFeed)
        {
            int QtRes = -1;

            // Ajuste dos campos


            using (var context = new bancoRSSEntities())
            {
                Feed resFeed = context.Feeds
                    .Where(b => b.feed_url.Equals(oFeed.feed_url))
                    .FirstOrDefault();

                if (resFeed == null)
                {
                    try
                    {
                        context.Feeds.Add(oFeed);
                        QtRes = context.SaveChanges();
                    }
                    catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                    {

                    }
                }
            }

            return oFeed;
        }
    }
}
