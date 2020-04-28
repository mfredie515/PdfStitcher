using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using PdfSharp.Pdf;

namespace PdfStitcher
{
    internal class StitcherBuilder
    {
        internal StitcherBuilder()
        {
            Rotation = 0;
            Origin = Environment.CurrentDirectory;
            Recursive = true;
            Show = true;
            Destination = Environment.CurrentDirectory;
            Name = "MERGED_" + DateTime.Now.ToString("yyyyMMddHHmmss");
            Files = null;
            Pattern = null;
            Canceled = false;
        }

        internal int Rotation { get; set; }
        internal string Origin { get; set; }
        internal bool Recursive { get; set; }
        internal string Destination { get; set; }
        internal string Name { get; set; }
        internal string[] Files { get; set; }
        internal string Pattern { get; set; }
        internal bool Show { get; set; }
        internal bool Canceled { get; set; }

        internal bool IsValid
        {
            get
            {
                bool fileNameValid = !string.IsNullOrEmpty(Name) && Name.IndexOfAny(Path.GetInvalidFileNameChars()) < 0 && !File.Exists(Path.Combine(Destination, Name));
                if (!fileNameValid)
                    return false;

                return true;
            }
        }

        internal PdfDocument Stitch()
        {
            if (!IsValid)
                return null;
            PdfDocument document;
            StitchPdf(this, out document);

            return document;
        }

        private static void StitchDocuments(IEnumerable<string> documents, int rotation, ref PdfDocument pdfDocument)
        {
            PdfDocument importPdf;
            int count = documents.Count();
            int i = 1;
            foreach (string document in documents)
            {
                using (importPdf = PdfSharp.Pdf.IO.PdfReader.Open(document, PdfSharp.Pdf.IO.PdfDocumentOpenMode.Import))
                {
                    foreach (PdfPage page in importPdf.Pages)
                    {
                        page.Rotate = rotation % 360;
                        pdfDocument.AddPage(page);
                    }
                    Console.Write("\rStitching PDFs {0} of {1}", i++, count);
                }
            }
        }

        private static void StitchPdf(StitcherBuilder stitcherBuilder, out PdfDocument document)
        {
            document = new PdfDocument();

            if ((stitcherBuilder.Files == null || stitcherBuilder.Files.Count() == 0) && stitcherBuilder.Pattern == null) //Get all pdfs in origin directory.
            {
                string[] files = Directory.GetFiles(stitcherBuilder.Origin + "\\", "*.pdf", (stitcherBuilder.Recursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly));

                StitchDocuments(files, stitcherBuilder.Rotation, ref document);

            }
            else if (stitcherBuilder.Pattern != null) //Use the regex string to get all needed files
            {
                string fileName;
                string[] files = Directory.GetFiles(stitcherBuilder.Origin + "\\", "*.pdf", (stitcherBuilder.Recursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly));
                List<string> matchedFiles = new List<string>();
                foreach (string file in files)
                {
                    int startIndex = file.LastIndexOf('\\') + 1;
                    int length = file.Length - startIndex - 4;
                    fileName = file.Substring(startIndex, length);

                    if (Regex.IsMatch(fileName, stitcherBuilder.Pattern))
                        matchedFiles.Add(stitcherBuilder.Origin + "\\" + fileName + ".pdf");
                }

                StitchDocuments(matchedFiles, stitcherBuilder.Rotation, ref document);

            }
            else //Use the file list
            {                
                //StitchDocuments(stitcherBuilder.Files.Select(s => string.Concat(stitcherBuilder.Origin + "\\" + (s.First() == '\"' ? s.Substring(1, s.Length - 2) : s) + ".pdf")), stitcherBuilder.Rotation, ref document);
                StitchDocuments(stitcherBuilder.Files.Select(s => string.Concat((File.Exists(stitcherBuilder.Origin + "\\" + (s.First() == '\"' ? s.Substring(1, s.Length - 2) : s) + ".pdf") ? (stitcherBuilder.Origin + "\\" + (s.First() == '\"' ? s.Substring(1, s.Length - 2) : s) + ".pdf") : (s.First() == '\"' ? s.Substring(1, s.Length - 2) : s)))), stitcherBuilder.Rotation, ref document);
            }
        }
    }
}
