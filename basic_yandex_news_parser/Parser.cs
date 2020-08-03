using System;
using System.Net;
using System.IO;
using HtmlAgilityPack;
using System.Xaml;
using System.Linq;
using System.Collections.Generic;

namespace basic_yandex_news_parser
{
    class Parser
    {

        public Parser()
        {
            var url = @"https://yandex.ru/";

            HtmlWeb webDoc = new HtmlWeb();
            HtmlDocument doc = webDoc.Load(url);
            //"//span[@class='news__item - content ']" 

            List<HtmlNode> nodes = doc.DocumentNode.SelectNodes("//ol[@class='list b-news-list']").ToList();

            if (nodes != null)
            {                
                foreach(HtmlNode node in nodes[0].ChildNodes)
                {
                    Console.WriteLine(node.InnerText);
                    Console.WriteLine(new string('=', node.InnerText.Length));
                }
            }
            else
            {
                Console.WriteLine("Something went wrong :(");
            }
           

        }
    }
}
