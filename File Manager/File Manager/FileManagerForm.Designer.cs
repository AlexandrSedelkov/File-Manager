
namespace File_Manager
{
    partial class fileManagerForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fileManagerForm));
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.quantityLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainTreeView = new System.Windows.Forms.TreeView();
            this.mainListView = new System.Windows.Forms.ListView();
            this.mainContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyButton = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteButton = new System.Windows.Forms.ToolStripMenuItem();
            this.renameButton = new System.Windows.Forms.ToolStripMenuItem();
            this.compressButton = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesButton = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteButton = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewFolderButton = new System.Windows.Forms.ToolStripMenuItem();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.gridStyleButton = new System.Windows.Forms.Button();
            this.listStyleButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.blackThemeButton = new System.Windows.Forms.Button();
            this.whiteThemeButton = new System.Windows.Forms.Button();
            this.thistleThemeButton = new System.Windows.Forms.Button();
            this.mistyRoseTheme = new System.Windows.Forms.Button();
            this.mainStatusStrip.SuspendLayout();
            this.mainContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quantityLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 524);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(1062, 26);
            this.mainStatusStrip.TabIndex = 0;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // quantityLabel
            // 
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(92, 20);
            this.quantityLabel.Text = "Элементов: ";
            // 
            // mainTreeView
            // 
            this.mainTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mainTreeView.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainTreeView.Location = new System.Drawing.Point(0, 30);
            this.mainTreeView.Name = "mainTreeView";
            this.mainTreeView.Size = new System.Drawing.Size(250, 494);
            this.mainTreeView.TabIndex = 5;
            this.mainTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MainTreeView_AfterSelect);
            // 
            // mainListView
            // 
            this.mainListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainListView.BackColor = System.Drawing.Color.White;
            this.mainListView.ContextMenuStrip = this.mainContextMenuStrip;
            this.mainListView.ForeColor = System.Drawing.Color.Black;
            this.mainListView.HideSelection = false;
            this.mainListView.LabelEdit = true;
            this.mainListView.LargeImageList = this.iconList;
            this.mainListView.Location = new System.Drawing.Point(256, 30);
            this.mainListView.Name = "mainListView";
            this.mainListView.Size = new System.Drawing.Size(806, 494);
            this.mainListView.SmallImageList = this.iconList;
            this.mainListView.TabIndex = 6;
            this.mainListView.UseCompatibleStateImageBehavior = false;
            this.mainListView.DoubleClick += new System.EventHandler(this.Open);
            // 
            // mainContextMenuStrip
            // 
            this.mainContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyButton,
            this.pasteButton,
            this.renameButton,
            this.compressButton,
            this.propertiesButton,
            this.deleteButton,
            this.createNewFolderButton});
            this.mainContextMenuStrip.Name = "contextMenuStrip1";
            this.mainContextMenuStrip.Size = new System.Drawing.Size(229, 172);
            // 
            // copyButton
            // 
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(228, 24);
            this.copyButton.Text = "Копировать";
            this.copyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // pasteButton
            // 
            this.pasteButton.Name = "pasteButton";
            this.pasteButton.Size = new System.Drawing.Size(228, 24);
            this.pasteButton.Text = "Вставить";
            this.pasteButton.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // renameButton
            // 
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(228, 24);
            this.renameButton.Text = "Переименовать";
            this.renameButton.Click += new System.EventHandler(this.RenameButton_Click);
            // 
            // compressButton
            // 
            this.compressButton.Name = "compressButton";
            this.compressButton.Size = new System.Drawing.Size(228, 24);
            this.compressButton.Text = "Добавить в архив...";
            this.compressButton.Click += new System.EventHandler(this.CompressButton_Click);
            // 
            // propertiesButton
            // 
            this.propertiesButton.Name = "propertiesButton";
            this.propertiesButton.Size = new System.Drawing.Size(228, 24);
            this.propertiesButton.Text = "Свойства";
            this.propertiesButton.Click += new System.EventHandler(this.PropertiesButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(228, 24);
            this.deleteButton.Text = "Удалить";
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // createNewFolderButton
            // 
            this.createNewFolderButton.Name = "createNewFolderButton";
            this.createNewFolderButton.Size = new System.Drawing.Size(228, 24);
            this.createNewFolderButton.Text = "Создать Новую папку";
            this.createNewFolderButton.Click += new System.EventHandler(this.CreateNewFolderButton_Click);
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "folder (2).png");
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.filePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filePathTextBox.Location = new System.Drawing.Point(145, 4);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(728, 22);
            this.filePathTextBox.TabIndex = 8;
            // 
            // gridStyleButton
            // 
            this.gridStyleButton.BackgroundImage = global::File_Manager.Properties.Resources.grid;
            this.gridStyleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gridStyleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridStyleButton.Location = new System.Drawing.Point(66, 0);
            this.gridStyleButton.Name = "gridStyleButton";
            this.gridStyleButton.Size = new System.Drawing.Size(30, 30);
            this.gridStyleButton.TabIndex = 12;
            this.gridStyleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.gridStyleButton.UseVisualStyleBackColor = true;
            this.gridStyleButton.Click += new System.EventHandler(this.GridStyleButton_Click);
            // 
            // listStyleButton
            // 
            this.listStyleButton.BackgroundImage = global::File_Manager.Properties.Resources.list_interface_symbol;
            this.listStyleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.listStyleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listStyleButton.Location = new System.Drawing.Point(30, 0);
            this.listStyleButton.Name = "listStyleButton";
            this.listStyleButton.Size = new System.Drawing.Size(30, 30);
            this.listStyleButton.TabIndex = 11;
            this.listStyleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.listStyleButton.UseVisualStyleBackColor = true;
            this.listStyleButton.Click += new System.EventHandler(this.ListStyleButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackgroundImage = global::File_Manager.Properties.Resources.refresh_page_option;
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshButton.Location = new System.Drawing.Point(0, 0);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(30, 30);
            this.refreshButton.TabIndex = 10;
            this.refreshButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Путь:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(874, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Темы:";
            // 
            // blackThemeButton
            // 
            this.blackThemeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.blackThemeButton.BackColor = System.Drawing.Color.Black;
            this.blackThemeButton.Location = new System.Drawing.Point(959, 0);
            this.blackThemeButton.Name = "blackThemeButton";
            this.blackThemeButton.Size = new System.Drawing.Size(30, 30);
            this.blackThemeButton.TabIndex = 15;
            this.blackThemeButton.UseVisualStyleBackColor = false;
            this.blackThemeButton.Click += new System.EventHandler(this.BlackThemeButton_Click);
            // 
            // whiteThemeButton
            // 
            this.whiteThemeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.whiteThemeButton.BackColor = System.Drawing.Color.White;
            this.whiteThemeButton.Location = new System.Drawing.Point(923, 0);
            this.whiteThemeButton.Name = "whiteThemeButton";
            this.whiteThemeButton.Size = new System.Drawing.Size(30, 30);
            this.whiteThemeButton.TabIndex = 16;
            this.whiteThemeButton.UseVisualStyleBackColor = false;
            this.whiteThemeButton.Click += new System.EventHandler(this.WhiteThemeButton_Click);
            // 
            // thistleThemeButton
            // 
            this.thistleThemeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.thistleThemeButton.BackColor = System.Drawing.Color.Thistle;
            this.thistleThemeButton.Location = new System.Drawing.Point(996, 0);
            this.thistleThemeButton.Name = "thistleThemeButton";
            this.thistleThemeButton.Size = new System.Drawing.Size(30, 30);
            this.thistleThemeButton.TabIndex = 17;
            this.thistleThemeButton.UseVisualStyleBackColor = false;
            this.thistleThemeButton.Click += new System.EventHandler(this.ThistleThemeButton_Click);
            // 
            // mistyRoseTheme
            // 
            this.mistyRoseTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mistyRoseTheme.BackColor = System.Drawing.Color.MistyRose;
            this.mistyRoseTheme.Location = new System.Drawing.Point(1032, 0);
            this.mistyRoseTheme.Name = "mistyRoseTheme";
            this.mistyRoseTheme.Size = new System.Drawing.Size(30, 30);
            this.mistyRoseTheme.TabIndex = 18;
            this.mistyRoseTheme.UseVisualStyleBackColor = false;
            this.mistyRoseTheme.Click += new System.EventHandler(this.MistyRoseTheme_Click);
            // 
            // fileManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1062, 550);
            this.Controls.Add(this.mistyRoseTheme);
            this.Controls.Add(this.thistleThemeButton);
            this.Controls.Add(this.whiteThemeButton);
            this.Controls.Add(this.blackThemeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridStyleButton);
            this.Controls.Add(this.listStyleButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.mainListView);
            this.Controls.Add(this.mainTreeView);
            this.Controls.Add(this.mainStatusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fileManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Explorer";
            this.Load += new System.EventHandler(this.FileManagerForm_Load);
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.mainContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel quantityLabel;
        private System.Windows.Forms.TreeView mainTreeView;
        private System.Windows.Forms.ListView mainListView;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ContextMenuStrip mainContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyButton;
        private System.Windows.Forms.ToolStripMenuItem pasteButton;
        private System.Windows.Forms.ToolStripMenuItem renameButton;
        private System.Windows.Forms.ToolStripMenuItem compressButton;
        private System.Windows.Forms.ToolStripMenuItem propertiesButton;
        private System.Windows.Forms.ToolStripMenuItem deleteButton;
        private System.Windows.Forms.ToolStripMenuItem createNewFolderButton;
        private System.Windows.Forms.Button listStyleButton;
        private System.Windows.Forms.Button gridStyleButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button blackThemeButton;
        private System.Windows.Forms.Button whiteThemeButton;
        private System.Windows.Forms.Button thistleThemeButton;
        private System.Windows.Forms.Button mistyRoseTheme;
    }
}

