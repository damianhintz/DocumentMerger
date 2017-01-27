using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DocumentMergerDomena;

namespace DocumentMerger.Model
{
    /// <summary>
    /// Widok modelu grupy dokumentów.
    /// </summary>
    class FolderViewModel : ListViewItem
    {
        public string Folder => _grupa.Folder;
        public string Pliki => _grupa.Pliki.Count().ToString();
        public string Strony => 0.ToString();
        public string ScalonyPlik => _grupa.IsMerged ? _grupa.Plik : "";
        public string ScaloneStrony => 0.ToString();
        public DocumentGroup Grupa => _grupa;
        DocumentGroup _grupa;

        public FolderViewModel(DocumentGroup grupa)
            : base(grupa.Folder)
        {
            _grupa = grupa;
            Odśwież();
            Tag = grupa;
        }

        public void Odśwież()
        {
            SubItems.Clear();
            SubItems[0].Text = Folder;
            SubItems.Add(Pliki);
            SubItems.Add(Strony);
            SubItems.Add(ScalonyPlik);
            SubItems.Add(ScaloneStrony);
        }
    }
}
