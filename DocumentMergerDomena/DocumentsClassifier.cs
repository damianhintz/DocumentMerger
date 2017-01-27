using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DocumentMergerDomena
{
    /// <summary>
    /// Klasyfikator plików tworzący grupy scalania.
    /// </summary>
    public class DocumentsClassifier
    {
        public IEnumerable<DocumentGroup> ClassifyDocuments(IEnumerable<string> pliki)
        {
            var grupyPlików = pliki.GroupBy(f => Path.GetDirectoryName(f));
            foreach(var grupa in grupyPlików)
            {
                var folder = grupa.Key;
                var grupaPlików = new DocumentGroup { Folder = folder };
                foreach(var plik in grupa)
                {
                    grupaPlików.DodajPlik(plik);
                }
                yield return grupaPlików;
            }
        }
    }
}
