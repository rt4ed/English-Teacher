using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TeacherEnglish.Entities;

namespace TeacherEnglish
{
    public class IrregularVerbsSite
    {
        public IrregularVerbsSite()
        {

        }

        public List<List<string>> GetIrregularVerbs(string address)
        {
            WebClient webClient = new WebClient();
            string page = webClient.DownloadString(address);

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(page);

            List<List<string>> table = doc.DocumentNode.SelectSingleNode("//table[@class='profile']")
                        .Descendants("tr")
                        .Skip(1)
                        .Where(tr => tr.Elements("td").Count() > 1)
                        .Select(tr => tr.Elements("td").Select(td => td.InnerText.Trim()).ToList())
                        .ToList();

            return table;
        }
    }
}
