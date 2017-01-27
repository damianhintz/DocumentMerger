using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DocumentMergerDomena;
using DocumentMerger.Model;
using System.IO;
using System.Diagnostics;

namespace DocumentMerger
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Lista zaznaczonych grup plików.
        /// </summary>
        IEnumerable<FolderViewModel> Zaznaczone
        {
            get
            {
                var items = new List<FolderViewModel>();
                foreach (int i in folderView.SelectedIndices)
                {
                    var item = folderView.Items[i] as FolderViewModel;
                    items.Add(item);
                }
                return items;
            }
        }
        List<DocumentGroup> _folders = new List<DocumentGroup>();

        public MainForm()
        {
            InitializeComponent();
            folderView.RetrieveVirtualItem += FolderView_RetrieveVirtualItem;
        }

        private void FolderView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            var grupa = _folders[e.ItemIndex];
            var item = new FolderViewModel(grupa);
            e.Item = item;
        }

        private void zakończMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dodajFolderMenuItem_Click(object sender, EventArgs e)
        {
            var browser = new FolderBrowserDialog();
            var result = browser.ShowDialog(this);
            if (result != DialogResult.OK) return;
            var repo = new DocumentRepo();
            var reader = new DocumentsReader(repo);
            reader.Wczytaj(browser.SelectedPath);
            var classifier = new DocumentsClassifier();
            var grupy = classifier.ClassifyDocuments(repo.Pliki);
            _folders.Clear();
            _folders.AddRange(grupy);
            folderView.VirtualListSize = _folders.Count;
            MessageBox.Show("Wczytane pliki: " + repo.Pliki.Count() +
                "\nWczytane grupy: " + _folders.Count +
                "\nKoniec.");
        }

        private void cpdfMergeMenuItem_Click(object sender, EventArgs e)
        {
            var items = Zaznaczone;
            if (!items.Any()) return;
            var records = new List<string>();
            foreach(var item in items)
            {
                var merger = new CPdfDocumentMerger();
                var result = merger.Merge(item.Grupa);
                records.Add(result);
            }
            var fileName = Path.GetTempFileName();
            fileName = Path.ChangeExtension(fileName, "txt");
            File.WriteAllLines(fileName, records);
            Process.Start(fileName);
        }
    }
}
