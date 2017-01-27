using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DocumentMergerDomena
{
    /// <summary>
    /// Importer scalanych plików.
    /// </summary>
    public class DocumentsReader
    {
        /// <summary>
        /// Repozytorium plików do którego wczytujemy pliki.
        /// </summary>
        public DocumentRepo Repo => _repo;
        DocumentRepo _repo;

        public DocumentsReader(DocumentRepo repo)
        {
            _repo = repo;
        }

        public void Wczytaj(string folder)
        {
            var pliki = Directory.GetFiles(folder, "*.pdf", SearchOption.AllDirectories);
            foreach (var plik in pliki) _repo.DodajPlik(plik);
        }
    }
}
