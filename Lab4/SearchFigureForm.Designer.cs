
namespace Lab3
{
    partial class SearchFigureForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckBoxVolume = new System.Windows.Forms.CheckBox();
            this.TextBoxVolume = new System.Windows.Forms.TextBox();
            this.CheckBoxBall = new System.Windows.Forms.CheckBox();
            this.CheckBoxPyramid = new System.Windows.Forms.CheckBox();
            this.CheckBoxParallelepiped = new System.Windows.Forms.CheckBox();
            this.ButtonShowFigure = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CheckBoxVolume);
            this.groupBox1.Controls.Add(this.TextBoxVolume);
            this.groupBox1.Controls.Add(this.CheckBoxBall);
            this.groupBox1.Controls.Add(this.CheckBoxPyramid);
            this.groupBox1.Controls.Add(this.CheckBoxParallelepiped);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Найти фигуру...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "м";
            // 
            // CheckBoxVolume
            // 
            this.CheckBoxVolume.AutoSize = true;
            this.CheckBoxVolume.Location = new System.Drawing.Point(6, 88);
            this.CheckBoxVolume.Name = "CheckBoxVolume";
            this.CheckBoxVolume.Size = new System.Drawing.Size(83, 17);
            this.CheckBoxVolume.TabIndex = 5;
            this.CheckBoxVolume.Text = "С объёмом";
            this.CheckBoxVolume.UseVisualStyleBackColor = true;
            this.CheckBoxVolume.CheckedChanged += new System.EventHandler(this.CheckBoxVolumeCheckedChanged);
            // 
            // TextBoxVolume
            // 
            this.TextBoxVolume.Location = new System.Drawing.Point(95, 85);
            this.TextBoxVolume.Name = "TextBoxVolume";
            this.TextBoxVolume.Size = new System.Drawing.Size(58, 20);
            this.TextBoxVolume.TabIndex = 4;
            this.TextBoxVolume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericTextbox_KeyPress);
            // 
            // CheckBoxBall
            // 
            this.CheckBoxBall.AutoSize = true;
            this.CheckBoxBall.Location = new System.Drawing.Point(6, 65);
            this.CheckBoxBall.Name = "CheckBoxBall";
            this.CheckBoxBall.Size = new System.Drawing.Size(47, 17);
            this.CheckBoxBall.TabIndex = 2;
            this.CheckBoxBall.Text = "Шар";
            this.CheckBoxBall.UseVisualStyleBackColor = true;
            // 
            // CheckBoxPyramid
            // 
            this.CheckBoxPyramid.AutoSize = true;
            this.CheckBoxPyramid.Location = new System.Drawing.Point(6, 42);
            this.CheckBoxPyramid.Name = "CheckBoxPyramid";
            this.CheckBoxPyramid.Size = new System.Drawing.Size(77, 17);
            this.CheckBoxPyramid.TabIndex = 1;
            this.CheckBoxPyramid.Text = "Пирамиду";
            this.CheckBoxPyramid.UseVisualStyleBackColor = true;
            // 
            // CheckBoxParallelepiped
            // 
            this.CheckBoxParallelepiped.AutoSize = true;
            this.CheckBoxParallelepiped.Location = new System.Drawing.Point(6, 19);
            this.CheckBoxParallelepiped.Name = "CheckBoxParallelepiped";
            this.CheckBoxParallelepiped.Size = new System.Drawing.Size(112, 17);
            this.CheckBoxParallelepiped.TabIndex = 0;
            this.CheckBoxParallelepiped.Text = "Параллелепипед";
            this.CheckBoxParallelepiped.UseVisualStyleBackColor = true;
            // 
            // ButtonShowFigure
            // 
            this.ButtonShowFigure.Location = new System.Drawing.Point(12, 135);
            this.ButtonShowFigure.Name = "ButtonShowFigure";
            this.ButtonShowFigure.Size = new System.Drawing.Size(185, 23);
            this.ButtonShowFigure.TabIndex = 1;
            this.ButtonShowFigure.Text = "Показать";
            this.ButtonShowFigure.UseVisualStyleBackColor = true;
            this.ButtonShowFigure.Click += new System.EventHandler(this.ButtonShowFigure_Click);
            // 
            // SearchFigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 170);
            this.Controls.Add(this.ButtonShowFigure);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SearchFigureForm";
            this.Text = "Поиск";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CheckBoxVolume;
        private System.Windows.Forms.TextBox TextBoxVolume;
        private System.Windows.Forms.CheckBox CheckBoxBall;
        private System.Windows.Forms.CheckBox CheckBoxPyramid;
        private System.Windows.Forms.CheckBox CheckBoxParallelepiped;
        private System.Windows.Forms.Button ButtonShowFigure;
    }
}