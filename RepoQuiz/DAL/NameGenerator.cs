using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Xml.Linq;

namespace RepoQuiz.DAL
{
    
    public class NameGenerator
    {
                
        public static string RandomStr()

        {
            string randomString = Path.GetRandomFileName();
            randomString = randomString.Replace(".", ""); 
            return randomString;
        }
    }
}