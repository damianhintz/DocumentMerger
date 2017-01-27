using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DocumentMergerDomena
{
    /// <summary>
    /// Grupa plików przeznaczonych do scalenia.
    /// </summary>
    public class DocumentGroup
    {
        /// <summary>
        /// Czy grupa została scalona?
        /// </summary>
        public bool IsMerged => Pliki.Contains(Plik);

        /// <summary>
        /// Nazwa pliku scalenia.
        /// </summary>
        public string Plik => Path.Combine(Folder, Nazwa + ".pdf");

        /// <summary>
        /// Nazwa folderu scalenia.
        /// </summary>
        public string Nazwa => Path.GetFileName(Folder);

        /// <summary>
        /// Położenie docelowego folderu scalenia.
        /// </summary>
        public string Folder { get; set; }

        /// <summary>
        /// Lista plików w grupie.
        /// </summary>
        public IEnumerable<string> Pliki => _pliki;
        List<string> _pliki = new List<string>();

        public void DodajPlik(string fileName)
        {
            _pliki.Add(fileName);
        }
    }
}
