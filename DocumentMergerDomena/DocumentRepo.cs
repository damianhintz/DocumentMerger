using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentMergerDomena
{
    /// <summary>
    /// Repozytorium plików do scalenia.
    /// </summary>
    public class DocumentRepo
    {
        /// <summary>
        /// Lista wszystkich plików do scalenia.
        /// </summary>
        public IEnumerable<string> Pliki => _pliki;
        List<string> _pliki = new List<string>();

        public void DodajPlik(string fileName)
        {
            _pliki.Add(fileName);
        }
    }
}
