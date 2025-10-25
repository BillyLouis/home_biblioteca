using lb2engineering.Models;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Hosting;


namespace lb2engineering.Models
{
    public class DownloadFiles
    {
        public List<FreePDFdownloads> GetFiles()
        {
            List<FreePDFdownloads> _FreePDF = new List<FreePDFdownloads>();
            DirectoryInfo dirInfo = new DirectoryInfo(HostingEnvironment.MapPath("~/myPDF"));

            int i = 0;
            foreach (var item in dirInfo.GetFiles())
            {
                _FreePDF.Add(new FreePDFdownloads()
                {

                    Id = i + 1,
                    Name = item.Name,
                    FilePath = dirInfo.FullName + @"\" + item.Name
                    
                });
                i = i + 1;
            }
            return _FreePDF;
        } 
    }
}