namespace DocumentMerger
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.plikMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajFolderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.zakończMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widokMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaznaczWszystkoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odwróćZaznaczenieMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokażZaznaczenieMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czytajToMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel = new System.Windows.Forms.Panel();
            this.folderView = new System.Windows.Forms.ListView();
            this.folderHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.plikiHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mergeFileHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folderMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pokażFolderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokażRaportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.scalPlikiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cpdfMergeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sejdaMergeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gsMergeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiwizujPlikiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spakujPlikiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńNazwęMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przenieśPlikiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńPlikiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.usuńFolderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stronyHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mergePagesHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.policzStronyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cpdfCountMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.status.SuspendLayout();
            this.panel.SuspendLayout();
            this.folderMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Menu;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikMenuItem,
            this.widokMenuItem,
            this.pomocMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menu.Size = new System.Drawing.Size(1027, 26);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // plikMenuItem
            // 
            this.plikMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajFolderMenuItem,
            this.toolStripSeparator3,
            this.zakończMenuItem});
            this.plikMenuItem.Name = "plikMenuItem";
            this.plikMenuItem.Size = new System.Drawing.Size(39, 22);
            this.plikMenuItem.Text = "Plik";
            // 
            // dodajFolderMenuItem
            // 
            this.dodajFolderMenuItem.Name = "dodajFolderMenuItem";
            this.dodajFolderMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.dodajFolderMenuItem.Size = new System.Drawing.Size(212, 26);
            this.dodajFolderMenuItem.Text = "Dodaj folder";
            this.dodajFolderMenuItem.Click += new System.EventHandler(this.dodajFolderMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(209, 6);
            // 
            // zakończMenuItem
            // 
            this.zakończMenuItem.Name = "zakończMenuItem";
            this.zakończMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.zakończMenuItem.Size = new System.Drawing.Size(212, 26);
            this.zakończMenuItem.Text = "Zakończ";
            this.zakończMenuItem.Click += new System.EventHandler(this.zakończMenuItem_Click);
            // 
            // widokMenuItem
            // 
            this.widokMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zaznaczWszystkoMenuItem,
            this.odwróćZaznaczenieMenuItem,
            this.pokażZaznaczenieMenuItem});
            this.widokMenuItem.Name = "widokMenuItem";
            this.widokMenuItem.Size = new System.Drawing.Size(59, 22);
            this.widokMenuItem.Text = "Widok";
            // 
            // zaznaczWszystkoMenuItem
            // 
            this.zaznaczWszystkoMenuItem.Name = "zaznaczWszystkoMenuItem";
            this.zaznaczWszystkoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.zaznaczWszystkoMenuItem.Size = new System.Drawing.Size(263, 26);
            this.zaznaczWszystkoMenuItem.Text = "Zaznacz wszystko";
            // 
            // odwróćZaznaczenieMenuItem
            // 
            this.odwróćZaznaczenieMenuItem.Name = "odwróćZaznaczenieMenuItem";
            this.odwróćZaznaczenieMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.odwróćZaznaczenieMenuItem.Size = new System.Drawing.Size(263, 26);
            this.odwróćZaznaczenieMenuItem.Text = "Odwróć zaznaczenie";
            // 
            // pokażZaznaczenieMenuItem
            // 
            this.pokażZaznaczenieMenuItem.Name = "pokażZaznaczenieMenuItem";
            this.pokażZaznaczenieMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pokażZaznaczenieMenuItem.Size = new System.Drawing.Size(263, 26);
            this.pokażZaznaczenieMenuItem.Text = "Pokaż zaznaczenie";
            // 
            // pomocMenuItem
            // 
            this.pomocMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.czytajToMenuItem});
            this.pomocMenuItem.Name = "pomocMenuItem";
            this.pomocMenuItem.Size = new System.Drawing.Size(64, 22);
            this.pomocMenuItem.Text = "Pomoc";
            // 
            // czytajToMenuItem
            // 
            this.czytajToMenuItem.Name = "czytajToMenuItem";
            this.czytajToMenuItem.Size = new System.Drawing.Size(141, 26);
            this.czytajToMenuItem.Tag = "README.md";
            this.czytajToMenuItem.Text = "Czytaj to";
            this.czytajToMenuItem.ToolTipText = "README.md";
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.SystemColors.Menu;
            this.status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.status.Location = new System.Drawing.Point(0, 504);
            this.status.Name = "status";
            this.status.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.status.Size = new System.Drawing.Size(1027, 23);
            this.status.TabIndex = 1;
            this.status.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(57, 18);
            this.statusLabel.Text = "Gotowe";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.folderView);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 26);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1027, 478);
            this.panel.TabIndex = 2;
            // 
            // folderView
            // 
            this.folderView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.folderHeader,
            this.plikiHeader,
            this.stronyHeader,
            this.mergeFileHeader,
            this.mergePagesHeader});
            this.folderView.ContextMenuStrip = this.folderMenu;
            this.folderView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderView.FullRowSelect = true;
            this.folderView.HideSelection = false;
            this.folderView.Location = new System.Drawing.Point(0, 0);
            this.folderView.Margin = new System.Windows.Forms.Padding(4);
            this.folderView.Name = "folderView";
            this.folderView.Size = new System.Drawing.Size(1027, 478);
            this.folderView.TabIndex = 0;
            this.folderView.UseCompatibleStateImageBehavior = false;
            this.folderView.View = System.Windows.Forms.View.Details;
            this.folderView.VirtualMode = true;
            // 
            // folderHeader
            // 
            this.folderHeader.Text = "Folder";
            this.folderHeader.Width = 300;
            // 
            // plikiHeader
            // 
            this.plikiHeader.Text = "Pliki";
            // 
            // mergeFileHeader
            // 
            this.mergeFileHeader.Text = "Scalony plik";
            this.mergeFileHeader.Width = 300;
            // 
            // folderMenu
            // 
            this.folderMenu.BackColor = System.Drawing.SystemColors.Menu;
            this.folderMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.folderMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokażFolderMenuItem,
            this.pokażRaportMenuItem,
            this.toolStripSeparator2,
            this.scalPlikiMenuItem,
            this.policzStronyMenuItem,
            this.archiwizujPlikiMenuItem,
            this.toolStripSeparator1,
            this.usuńFolderMenuItem});
            this.folderMenu.Name = "folderMenu";
            this.folderMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.folderMenu.Size = new System.Drawing.Size(171, 172);
            // 
            // pokażFolderMenuItem
            // 
            this.pokażFolderMenuItem.Name = "pokażFolderMenuItem";
            this.pokażFolderMenuItem.Size = new System.Drawing.Size(181, 26);
            this.pokażFolderMenuItem.Text = "Pokaż folder";
            this.pokażFolderMenuItem.ToolTipText = "Otwórz folder w eksploratorze plików";
            // 
            // pokażRaportMenuItem
            // 
            this.pokażRaportMenuItem.Name = "pokażRaportMenuItem";
            this.pokażRaportMenuItem.Size = new System.Drawing.Size(181, 26);
            this.pokażRaportMenuItem.Text = "Pokaż raport";
            this.pokażRaportMenuItem.ToolTipText = "Pokaż raport scalania plików w danym folderze";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // scalPlikiMenuItem
            // 
            this.scalPlikiMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cpdfMergeMenuItem,
            this.sejdaMergeMenuItem,
            this.gsMergeMenuItem});
            this.scalPlikiMenuItem.Name = "scalPlikiMenuItem";
            this.scalPlikiMenuItem.Size = new System.Drawing.Size(181, 26);
            this.scalPlikiMenuItem.Text = "Scal pliki";
            // 
            // cpdfMergeMenuItem
            // 
            this.cpdfMergeMenuItem.Name = "cpdfMergeMenuItem";
            this.cpdfMergeMenuItem.Size = new System.Drawing.Size(181, 26);
            this.cpdfMergeMenuItem.Text = "cpdf";
            this.cpdfMergeMenuItem.Click += new System.EventHandler(this.cpdfMergeMenuItem_Click);
            // 
            // sejdaMergeMenuItem
            // 
            this.sejdaMergeMenuItem.Name = "sejdaMergeMenuItem";
            this.sejdaMergeMenuItem.Size = new System.Drawing.Size(181, 26);
            this.sejdaMergeMenuItem.Text = "Sejda";
            // 
            // gsMergeMenuItem
            // 
            this.gsMergeMenuItem.Name = "gsMergeMenuItem";
            this.gsMergeMenuItem.Size = new System.Drawing.Size(181, 26);
            this.gsMergeMenuItem.Text = "gs";
            // 
            // archiwizujPlikiMenuItem
            // 
            this.archiwizujPlikiMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spakujPlikiMenuItem,
            this.zmieńNazwęMenuItem,
            this.przenieśPlikiMenuItem,
            this.usuńPlikiMenuItem});
            this.archiwizujPlikiMenuItem.Name = "archiwizujPlikiMenuItem";
            this.archiwizujPlikiMenuItem.Size = new System.Drawing.Size(181, 26);
            this.archiwizujPlikiMenuItem.Text = "Archiwizuj pliki";
            // 
            // spakujPlikiMenuItem
            // 
            this.spakujPlikiMenuItem.Name = "spakujPlikiMenuItem";
            this.spakujPlikiMenuItem.Size = new System.Drawing.Size(167, 26);
            this.spakujPlikiMenuItem.Text = "Spakuj pliki";
            // 
            // zmieńNazwęMenuItem
            // 
            this.zmieńNazwęMenuItem.Name = "zmieńNazwęMenuItem";
            this.zmieńNazwęMenuItem.Size = new System.Drawing.Size(167, 26);
            this.zmieńNazwęMenuItem.Text = "Zmień nazwę";
            // 
            // przenieśPlikiMenuItem
            // 
            this.przenieśPlikiMenuItem.Name = "przenieśPlikiMenuItem";
            this.przenieśPlikiMenuItem.Size = new System.Drawing.Size(167, 26);
            this.przenieśPlikiMenuItem.Text = "Przenieś pliki";
            // 
            // usuńPlikiMenuItem
            // 
            this.usuńPlikiMenuItem.Name = "usuńPlikiMenuItem";
            this.usuńPlikiMenuItem.Size = new System.Drawing.Size(167, 26);
            this.usuńPlikiMenuItem.Text = "Usuń pliki";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // usuńFolderMenuItem
            // 
            this.usuńFolderMenuItem.Name = "usuńFolderMenuItem";
            this.usuńFolderMenuItem.Size = new System.Drawing.Size(181, 26);
            this.usuńFolderMenuItem.Text = "Usuń";
            this.usuńFolderMenuItem.ToolTipText = "Usuń folder z widoku";
            // 
            // stronyHeader
            // 
            this.stronyHeader.Text = "Strony";
            // 
            // mergePagesHeader
            // 
            this.mergePagesHeader.Text = "Scalone strony";
            this.mergePagesHeader.Width = 120;
            // 
            // policzStronyMenuItem
            // 
            this.policzStronyMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cpdfCountMenuItem});
            this.policzStronyMenuItem.Name = "policzStronyMenuItem";
            this.policzStronyMenuItem.Size = new System.Drawing.Size(181, 26);
            this.policzStronyMenuItem.Text = "Policz strony";
            // 
            // cpdfCountMenuItem
            // 
            this.cpdfCountMenuItem.Name = "cpdfCountMenuItem";
            this.cpdfCountMenuItem.Size = new System.Drawing.Size(181, 26);
            this.cpdfCountMenuItem.Text = "cpdf";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 527);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "DocumentMerger v1.0-alfa - Wsadowe scalanie plików (25 stycznia 2017)";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.panel.ResumeLayout(false);
            this.folderMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem plikMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocMenuItem;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripMenuItem zakończMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widokMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaznaczWszystkoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czytajToMenuItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ListView folderView;
        private System.Windows.Forms.ColumnHeader folderHeader;
        private System.Windows.Forms.ContextMenuStrip folderMenu;
        private System.Windows.Forms.ColumnHeader plikiHeader;
        private System.Windows.Forms.ColumnHeader mergeFileHeader;
        private System.Windows.Forms.ToolStripMenuItem pokażFolderMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem scalPlikiMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cpdfMergeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sejdaMergeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gsMergeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archiwizujPlikiMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spakujPlikiMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmieńNazwęMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przenieśPlikiMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńPlikiMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem usuńFolderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odwróćZaznaczenieMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokażZaznaczenieMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajFolderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokażRaportMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ColumnHeader stronyHeader;
        private System.Windows.Forms.ColumnHeader mergePagesHeader;
        private System.Windows.Forms.ToolStripMenuItem policzStronyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cpdfCountMenuItem;
    }
}

