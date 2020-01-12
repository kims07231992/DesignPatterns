using PG5_DP_Factory.DocumentsOffice.Model;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.PowerPoint;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Factory.DocumentsOffice.FileHandlers
{
    public class PresentationHandler : FileHandler
    {
        public override void CreateFile(string filePath, DocumentModel data)
        {
            int slideIndex = 1; // created single slide file.
            Application pptApp = null;
            Presentation pptPresentation = null;
            Slides slides = null;
            _Slide slide = null;
            TextRange objText = null;
            CustomLayout customLayout = null;
            try
            {
                pptApp = new Application();
                pptPresentation = pptApp.Presentations.Add();

                // create new Slide
                slides = pptPresentation.Slides;
                customLayout = pptPresentation.SlideMaster.CustomLayouts[PpSlideLayout.ppLayoutText];
                slide = slides.AddSlide(slideIndex, customLayout);

                // write title
                objText = slide.Shapes[1].TextFrame.TextRange;
                objText.Text = data.Title;
                objText.Font.Name = "Arial";
                objText.Font.Size = 32;
                
                // write description
                objText = slide.Shapes[2].TextFrame.TextRange;
                objText.Text = data.Description;

                pptPresentation.SaveAs(filePath);
                pptPresentation.Close();
                pptApp.Quit();            
            }
            finally
            {
                ReleaseFileObject(pptPresentation);
                ReleaseFileObject(pptApp);
            }
        }
        public override void LaunchFile(string filePath)
        {
            Application pptApp = null;
            Presentation pptPresentation = null;

            // Launch file
            pptApp = new Application();
            pptPresentation = pptApp.Presentations.Open(filePath);
        }
    }
}
