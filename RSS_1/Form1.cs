using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RSS_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregaLista();
        }

        private void carregaLista()
        {
            //List<Feed> oFeed = FeedDados.RetornaNaoLidos();

            try
            {
                var urls = FeedReader.GetFeedUrlsFromUrlAsync("https://iplusall.com/feed/").Result;

                string feedUrl = "https://iplusall.com/feed/";
                if (urls == null || urls.Count() < 1)
                    feedUrl = "https://iplusall.com/feed/";
                else if (urls.Count() == 1)
                    feedUrl = urls.First().Url;
                else if (urls.Count() == 2) // if 2 urls, then its usually a feed and a comments feed, so take the first per default
                    feedUrl = urls.First().Url;

                var reader = FeedReader.ReadAsync(feedUrl).Result;

                foreach (var item in reader.Items)
                {
                    Console.WriteLine(item.Title + " - " + item.Link);
                }

                List<Item> oItens = new List<Item>();

                foreach (var oUrl in reader.Items)
                {
                    Item oItem = new Item();
                    oItem.item_titulo = oUrl.Title;
                    oItem.item_dthr = oUrl.PublishingDate;
                    oItem.item_conteudo = oUrl.Content;
                    oItem.item_url = oUrl.Link;
                    oItem.feed_codigo = 1;

                    oItens.Add(oItem);

                    Console.WriteLine(oUrl.Title + " - " + oUrl.Link);
                }

                itemBindingSource.DataSource = oItens;
                //itemBindingSource.DataSource = ItemDados.RetornaNaoLidos();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.InnerException.Message}{Environment.NewLine}{ex.InnerException.ToString()}");
            }
            Console.ReadKey();
        }
    }
}
