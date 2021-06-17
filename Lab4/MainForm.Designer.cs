
namespace Lab3
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataFigureView = new System.Windows.Forms.DataGridView();
            this.AddFigureButton = new System.Windows.Forms.Button();
            this.DeleteFugureButton = new System.Windows.Forms.Button();
            this.SearchFigureButton = new System.Windows.Forms.Button();
            this.RandomFigureButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripDropDownButtonFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DropFilterButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataFigureView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataFigureView);
            this.groupBox1.Location = new System.Drawing.Point(9, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(254, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вычисление объёмов фигур";
            // 
            // DataFigureView
            // 
            this.DataFigureView.AllowUserToResizeColumns = false;
            this.DataFigureView.AllowUserToResizeRows = false;
            this.DataFigureView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataFigureView.Location = new System.Drawing.Point(6, 18);
            this.DataFigureView.Name = "DataFigureView";
            this.DataFigureView.ReadOnly = true;
            this.DataFigureView.RowHeadersWidth = 51;
            this.DataFigureView.Size = new System.Drawing.Size(243, 143);
            this.DataFigureView.TabIndex = 0;
            // 
            // AddFigureButton
            // 
            this.AddFigureButton.Location = new System.Drawing.Point(15, 210);
            this.AddFigureButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddFigureButton.Name = "AddFigureButton";
            this.AddFigureButton.Size = new System.Drawing.Size(117, 21);
            this.AddFigureButton.TabIndex = 1;
            this.AddFigureButton.Text = "Добавить...";
            this.AddFigureButton.UseVisualStyleBackColor = true;
            this.AddFigureButton.Click += new System.EventHandler(this.AddFigureButton_Click);
            // 
            // DeleteFugureButton
            // 
            this.DeleteFugureButton.Location = new System.Drawing.Point(148, 210);
            this.DeleteFugureButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteFugureButton.Name = "DeleteFugureButton";
            this.DeleteFugureButton.Size = new System.Drawing.Size(110, 21);
            this.DeleteFugureButton.TabIndex = 2;
            this.DeleteFugureButton.Text = "Удалить";
            this.DeleteFugureButton.UseVisualStyleBackColor = true;
            this.DeleteFugureButton.Click += new System.EventHandler(this.DeleteFugureButton_Click);
            // 
            // SearchFigureButton
            // 
            this.SearchFigureButton.Location = new System.Drawing.Point(148, 243);
            this.SearchFigureButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchFigureButton.Name = "SearchFigureButton";
            this.SearchFigureButton.Size = new System.Drawing.Size(110, 21);
            this.SearchFigureButton.TabIndex = 3;
            this.SearchFigureButton.Text = "Найти...";
            this.SearchFigureButton.UseVisualStyleBackColor = true;
            this.SearchFigureButton.Click += new System.EventHandler(this.SearchFigureButton_Click);
            // 
            // RandomFigureButton
            // 
            this.RandomFigureButton.Location = new System.Drawing.Point(15, 243);
            this.RandomFigureButton.Margin = new System.Windows.Forms.Padding(2);
            this.RandomFigureButton.Name = "RandomFigureButton";
            this.RandomFigureButton.Size = new System.Drawing.Size(117, 21);
            this.RandomFigureButton.TabIndex = 5;
            this.RandomFigureButton.Text = "Случайная фигура";
            this.RandomFigureButton.UseVisualStyleBackColor = true;
            this.RandomFigureButton.Click += new System.EventHandler(this.RandomFigureButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripDropDownButtonFile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(270, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ToolStripDropDownButtonFile
            // 
            this.ToolStripDropDownButtonFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripDropDownButtonFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadToolStripMenuItem,
            this.SaveToolStripMenuItem});
            this.ToolStripDropDownButtonFile.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripDropDownButtonFile.Image")));
            this.ToolStripDropDownButtonFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripDropDownButtonFile.Name = "ToolStripDropDownButtonFile";
            this.ToolStripDropDownButtonFile.Size = new System.Drawing.Size(58, 22);
            this.ToolStripDropDownButtonFile.Text = "Файл...";
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.LoadToolStripMenuItem.Text = "Загрузить";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItemClick);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItemClick);
            // 
            // DropFilterButton
            // 
            this.DropFilterButton.Location = new System.Drawing.Point(148, 274);
            this.DropFilterButton.Margin = new System.Windows.Forms.Padding(2);
            this.DropFilterButton.Name = "DropFilterButton";
            this.DropFilterButton.Size = new System.Drawing.Size(110, 21);
            this.DropFilterButton.TabIndex = 7;
            this.DropFilterButton.Text = "Сбросить фильтр";
            this.DropFilterButton.UseVisualStyleBackColor = true;
            this.DropFilterButton.Click += new System.EventHandler(this.DropFilterButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 304);
            this.Controls.Add(this.DropFilterButton);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.RandomFigureButton);
            this.Controls.Add(this.SearchFigureButton);
            this.Controls.Add(this.DeleteFugureButton);
            this.Controls.Add(this.AddFigureButton);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Вычислятор";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataFigureView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddFigureButton;
        private System.Windows.Forms.Button DeleteFugureButton;
        private System.Windows.Forms.Button SearchFigureButton;
        private System.Windows.Forms.Button RandomFigureButton;
        private System.Windows.Forms.DataGridView DataFigureView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton ToolStripDropDownButtonFile;
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.Button DropFilterButton;
    }
}