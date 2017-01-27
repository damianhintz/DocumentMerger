using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentMergerDomena
{
    /// <summary>
    /// Scalacz grupy plików.
    /// </summary>
    public class CPdfDocumentMerger
    {
        public string Merge(DocumentGroup grupa)
        {
            if (grupa.IsMerged) throw new InvalidOperationException();
            //cpdf -merge -i ex1.pdf ex2.pdf -o test.pdf
            var pliki = string.Join(" ", grupa.Pliki);
            var wynikowyPlik = grupa.Plik;
            var cmd =  "cpdf.exe -merge -i " + pliki + " -o " + wynikowyPlik;
            grupa.DodajPlik(wynikowyPlik);
            return cmd;
        }
    }
}
