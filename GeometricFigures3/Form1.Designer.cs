﻿using System.Drawing;

namespace GF3
{
    partial class FigureForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Сanvas = new System.Windows.Forms.PictureBox();
            this.panelCircle = new System.Windows.Forms.Panel();
            this.btnBackColor_Circle = new System.Windows.Forms.Button();
            this.btnStrokeColor_Circle = new System.Windows.Forms.Button();
            this.lblBackColor_Circle = new System.Windows.Forms.Label();
            this.lblStrokeColor_Circle = new System.Windows.Forms.Label();
            this.lblRadius_Circle = new System.Windows.Forms.Label();
            this.txtBoxBackColor_Circle = new System.Windows.Forms.TextBox();
            this.txtBoxStrokeColor_Circle = new System.Windows.Forms.TextBox();
            this.txtBoxRadius_Circle = new System.Windows.Forms.TextBox();
            this.panelRectangle = new System.Windows.Forms.Panel();
            this.lblWidth_Rectangle = new System.Windows.Forms.Label();
            this.txtBoxWidth_Rectangle = new System.Windows.Forms.TextBox();
            this.txtBoxHeight_Rectangle = new System.Windows.Forms.TextBox();
            this.lblHeight_Rectangle = new System.Windows.Forms.Label();
            this.btnBackColor_Rectangle = new System.Windows.Forms.Button();
            this.txtBoxBackColor_Rectangle = new System.Windows.Forms.TextBox();
            this.lblBackColor_Rectangle = new System.Windows.Forms.Label();
            this.btnStrokeColor_Rectangle = new System.Windows.Forms.Button();
            this.lblStrokeColor_Rectangle = new System.Windows.Forms.Label();
            this.txtBoxStrokeColor_Rectangle = new System.Windows.Forms.TextBox();
            this.Texter = new System.Windows.Forms.Label();
            this.colorDialogFigure = new System.Windows.Forms.ColorDialog();
            this.panelLine = new System.Windows.Forms.Panel();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.ItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.itemLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearB = new System.Windows.Forms.Button();
            this.TextScroll = new System.Windows.Forms.Label();
            this.ScrollB = new System.Windows.Forms.TrackBar();
            this.Textun = new System.Windows.Forms.Label();
            this.BlueP = new System.Windows.Forms.Button();
            this.GreenP = new System.Windows.Forms.Button();
            this.RedP = new System.Windows.Forms.Button();
            this.CustomP = new System.Windows.Forms.Button();
            this.linB = new System.Windows.Forms.Button();
            this.cirB = new System.Windows.Forms.Button();
            this.triB = new System.Windows.Forms.Button();
            this.recB = new System.Windows.Forms.Button();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.dlgLoad = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Сanvas)).BeginInit();
            this.panelCircle.SuspendLayout();
            this.panelRectangle.SuspendLayout();
            this.panelLine.SuspendLayout();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScrollB)).BeginInit();
            this.SuspendLayout();
            // 
            // Сanvas
            // 
            this.Сanvas.BackColor = System.Drawing.Color.White;
            this.Сanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Сanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Сanvas.Location = new System.Drawing.Point(0, 85);
            this.Сanvas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Сanvas.Name = "Сanvas";
            this.Сanvas.Size = new System.Drawing.Size(1002, 356);
            this.Сanvas.TabIndex = 1;
            this.Сanvas.TabStop = false;
            this.Сanvas.ClientSizeChanged += new System.EventHandler(this.Сanvas_ClientSizeChanged);
            this.Сanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Сanvas_MouseClick);
            // 
            // panelCircle
            // 
            this.panelCircle.Controls.Add(this.btnBackColor_Circle);
            this.panelCircle.Controls.Add(this.btnStrokeColor_Circle);
            this.panelCircle.Controls.Add(this.lblBackColor_Circle);
            this.panelCircle.Controls.Add(this.lblStrokeColor_Circle);
            this.panelCircle.Controls.Add(this.lblRadius_Circle);
            this.panelCircle.Controls.Add(this.txtBoxBackColor_Circle);
            this.panelCircle.Controls.Add(this.txtBoxStrokeColor_Circle);
            this.panelCircle.Controls.Add(this.txtBoxRadius_Circle);
            this.panelCircle.Location = new System.Drawing.Point(295, 4);
            this.panelCircle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCircle.Name = "panelCircle";
            this.panelCircle.Size = new System.Drawing.Size(468, 43);
            this.panelCircle.TabIndex = 2;
            this.panelCircle.Visible = false;
            // 
            // btnBackColor_Circle
            // 
            this.btnBackColor_Circle.Location = new System.Drawing.Point(0, 0);
            this.btnBackColor_Circle.Name = "btnBackColor_Circle";
            this.btnBackColor_Circle.Size = new System.Drawing.Size(75, 23);
            this.btnBackColor_Circle.TabIndex = 0;
            // 
            // btnStrokeColor_Circle
            // 
            this.btnStrokeColor_Circle.Location = new System.Drawing.Point(0, 0);
            this.btnStrokeColor_Circle.Name = "btnStrokeColor_Circle";
            this.btnStrokeColor_Circle.Size = new System.Drawing.Size(75, 23);
            this.btnStrokeColor_Circle.TabIndex = 1;
            // 
            // lblBackColor_Circle
            // 
            this.lblBackColor_Circle.AutoSize = true;
            this.lblBackColor_Circle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBackColor_Circle.Location = new System.Drawing.Point(306, 2);
            this.lblBackColor_Circle.Name = "lblBackColor_Circle";
            this.lblBackColor_Circle.Size = new System.Drawing.Size(97, 20);
            this.lblBackColor_Circle.TabIndex = 5;
            this.lblBackColor_Circle.Text = "Цвет заливки";
            // 
            // lblStrokeColor_Circle
            // 
            this.lblStrokeColor_Circle.AutoSize = true;
            this.lblStrokeColor_Circle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStrokeColor_Circle.Location = new System.Drawing.Point(183, 2);
            this.lblStrokeColor_Circle.Name = "lblStrokeColor_Circle";
            this.lblStrokeColor_Circle.Size = new System.Drawing.Size(84, 20);
            this.lblStrokeColor_Circle.TabIndex = 4;
            this.lblStrokeColor_Circle.Text = "Цвет линии";
            // 
            // lblRadius_Circle
            // 
            this.lblRadius_Circle.AutoSize = true;
            this.lblRadius_Circle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRadius_Circle.Location = new System.Drawing.Point(32, 2);
            this.lblRadius_Circle.Name = "lblRadius_Circle";
            this.lblRadius_Circle.Size = new System.Drawing.Size(55, 20);
            this.lblRadius_Circle.TabIndex = 3;
            this.lblRadius_Circle.Text = "Радиус";
            // 
            // txtBoxBackColor_Circle
            // 
            this.txtBoxBackColor_Circle.Location = new System.Drawing.Point(306, 20);
            this.txtBoxBackColor_Circle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxBackColor_Circle.Name = "txtBoxBackColor_Circle";
            this.txtBoxBackColor_Circle.Size = new System.Drawing.Size(24, 23);
            this.txtBoxBackColor_Circle.TabIndex = 2;
            // 
            // txtBoxStrokeColor_Circle
            // 
            this.txtBoxStrokeColor_Circle.Location = new System.Drawing.Point(173, 20);
            this.txtBoxStrokeColor_Circle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxStrokeColor_Circle.Name = "txtBoxStrokeColor_Circle";
            this.txtBoxStrokeColor_Circle.Size = new System.Drawing.Size(24, 23);
            this.txtBoxStrokeColor_Circle.TabIndex = 1;
            // 
            // txtBoxRadius_Circle
            // 
            this.txtBoxRadius_Circle.Location = new System.Drawing.Point(0, 0);
            this.txtBoxRadius_Circle.Name = "txtBoxRadius_Circle";
            this.txtBoxRadius_Circle.Size = new System.Drawing.Size(100, 23);
            this.txtBoxRadius_Circle.TabIndex = 6;
            // 
            // panelRectangle
            // 
            this.panelRectangle.Controls.Add(this.lblWidth_Rectangle);
            this.panelRectangle.Controls.Add(this.txtBoxWidth_Rectangle);
            this.panelRectangle.Controls.Add(this.txtBoxHeight_Rectangle);
            this.panelRectangle.Controls.Add(this.lblHeight_Rectangle);
            this.panelRectangle.Controls.Add(this.btnBackColor_Rectangle);
            this.panelRectangle.Controls.Add(this.txtBoxBackColor_Rectangle);
            this.panelRectangle.Controls.Add(this.lblBackColor_Rectangle);
            this.panelRectangle.Controls.Add(this.btnStrokeColor_Rectangle);
            this.panelRectangle.Controls.Add(this.lblStrokeColor_Rectangle);
            this.panelRectangle.Controls.Add(this.txtBoxStrokeColor_Rectangle);
            this.panelRectangle.Location = new System.Drawing.Point(292, 4);
            this.panelRectangle.Name = "panelRectangle";
            this.panelRectangle.Size = new System.Drawing.Size(468, 43);
            this.panelRectangle.TabIndex = 5;
            this.panelRectangle.Visible = false;
            // 
            // lblWidth_Rectangle
            // 
            this.lblWidth_Rectangle.AutoSize = true;
            this.lblWidth_Rectangle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWidth_Rectangle.Location = new System.Drawing.Point(67, 0);
            this.lblWidth_Rectangle.Name = "lblWidth_Rectangle";
            this.lblWidth_Rectangle.Size = new System.Drawing.Size(61, 20);
            this.lblWidth_Rectangle.TabIndex = 9;
            this.lblWidth_Rectangle.Text = "Ширина";
            // 
            // txtBoxWidth_Rectangle
            // 
            this.txtBoxWidth_Rectangle.Location = new System.Drawing.Point(0, 0);
            this.txtBoxWidth_Rectangle.Name = "txtBoxWidth_Rectangle";
            this.txtBoxWidth_Rectangle.Size = new System.Drawing.Size(100, 23);
            this.txtBoxWidth_Rectangle.TabIndex = 10;
            // 
            // txtBoxHeight_Rectangle
            // 
            this.txtBoxHeight_Rectangle.Location = new System.Drawing.Point(0, 0);
            this.txtBoxHeight_Rectangle.Name = "txtBoxHeight_Rectangle";
            this.txtBoxHeight_Rectangle.Size = new System.Drawing.Size(100, 23);
            this.txtBoxHeight_Rectangle.TabIndex = 11;
            // 
            // lblHeight_Rectangle
            // 
            this.lblHeight_Rectangle.AutoSize = true;
            this.lblHeight_Rectangle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeight_Rectangle.ForeColor = System.Drawing.Color.Black;
            this.lblHeight_Rectangle.Location = new System.Drawing.Point(3, 0);
            this.lblHeight_Rectangle.Name = "lblHeight_Rectangle";
            this.lblHeight_Rectangle.Size = new System.Drawing.Size(49, 20);
            this.lblHeight_Rectangle.TabIndex = 6;
            this.lblHeight_Rectangle.Text = "Длина";
            // 
            // btnBackColor_Rectangle
            // 
            this.btnBackColor_Rectangle.Location = new System.Drawing.Point(0, 0);
            this.btnBackColor_Rectangle.Name = "btnBackColor_Rectangle";
            this.btnBackColor_Rectangle.Size = new System.Drawing.Size(75, 23);
            this.btnBackColor_Rectangle.TabIndex = 10;
            // 
            // txtBoxBackColor_Rectangle
            // 
            this.txtBoxBackColor_Rectangle.Location = new System.Drawing.Point(306, 19);
            this.txtBoxBackColor_Rectangle.Name = "txtBoxBackColor_Rectangle";
            this.txtBoxBackColor_Rectangle.Size = new System.Drawing.Size(24, 23);
            this.txtBoxBackColor_Rectangle.TabIndex = 4;
            // 
            // lblBackColor_Rectangle
            // 
            this.lblBackColor_Rectangle.AutoSize = true;
            this.lblBackColor_Rectangle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBackColor_Rectangle.Location = new System.Drawing.Point(306, 0);
            this.lblBackColor_Rectangle.Name = "lblBackColor_Rectangle";
            this.lblBackColor_Rectangle.Size = new System.Drawing.Size(97, 20);
            this.lblBackColor_Rectangle.TabIndex = 3;
            this.lblBackColor_Rectangle.Text = "Цвет заливки";
            // 
            // btnStrokeColor_Rectangle
            // 
            this.btnStrokeColor_Rectangle.Location = new System.Drawing.Point(0, 0);
            this.btnStrokeColor_Rectangle.Name = "btnStrokeColor_Rectangle";
            this.btnStrokeColor_Rectangle.Size = new System.Drawing.Size(75, 23);
            this.btnStrokeColor_Rectangle.TabIndex = 11;
            // 
            // lblStrokeColor_Rectangle
            // 
            this.lblStrokeColor_Rectangle.AutoSize = true;
            this.lblStrokeColor_Rectangle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStrokeColor_Rectangle.Location = new System.Drawing.Point(183, 0);
            this.lblStrokeColor_Rectangle.Name = "lblStrokeColor_Rectangle";
            this.lblStrokeColor_Rectangle.Size = new System.Drawing.Size(84, 20);
            this.lblStrokeColor_Rectangle.TabIndex = 1;
            this.lblStrokeColor_Rectangle.Text = "Цвет линии";
            // 
            // txtBoxStrokeColor_Rectangle
            // 
            this.txtBoxStrokeColor_Rectangle.Location = new System.Drawing.Point(173, 20);
            this.txtBoxStrokeColor_Rectangle.Name = "txtBoxStrokeColor_Rectangle";
            this.txtBoxStrokeColor_Rectangle.Size = new System.Drawing.Size(24, 23);
            this.txtBoxStrokeColor_Rectangle.TabIndex = 0;
            // 
            // Texter
            // 
            this.Texter.AutoSize = true;
            this.Texter.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Texter.Location = new System.Drawing.Point(126, 6);
            this.Texter.Name = "Texter";
            this.Texter.Size = new System.Drawing.Size(124, 20);
            this.Texter.TabIndex = 3;
            this.Texter.Text = "Выберите фигуру";
            this.Texter.Click += new System.EventHandler(this.Texter_Click);
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelLine.Controls.Add(this.msMenu);
            this.panelLine.Controls.Add(this.ClearB);
            this.panelLine.Controls.Add(this.TextScroll);
            this.panelLine.Controls.Add(this.ScrollB);
            this.panelLine.Controls.Add(this.Textun);
            this.panelLine.Controls.Add(this.BlueP);
            this.panelLine.Controls.Add(this.GreenP);
            this.panelLine.Controls.Add(this.RedP);
            this.panelLine.Controls.Add(this.CustomP);
            this.panelLine.Controls.Add(this.linB);
            this.panelLine.Controls.Add(this.Texter);
            this.panelLine.Controls.Add(this.cirB);
            this.panelLine.Controls.Add(this.triB);
            this.panelLine.Controls.Add(this.recB);
            this.panelLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLine.Location = new System.Drawing.Point(0, 0);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(1002, 85);
            this.panelLine.TabIndex = 4;
            this.panelLine.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLine_Paint);
            // 
            // msMenu
            // 
            this.msMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemFile});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(45, 24);
            this.msMenu.TabIndex = 6;
            this.msMenu.Text = "File";
            // 
            // ItemFile
            // 
            this.ItemFile.BackColor = System.Drawing.Color.White;
            this.ItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemSave,
            this.itemLoad});
            this.ItemFile.Name = "ItemFile";
            this.ItemFile.Size = new System.Drawing.Size(37, 20);
            this.ItemFile.Text = "File";
            // 
            // ItemSave
            // 
            this.ItemSave.Name = "ItemSave";
            this.ItemSave.Size = new System.Drawing.Size(100, 22);
            this.ItemSave.Text = "Save";
            this.ItemSave.Click += new System.EventHandler(this.ItemSave_Click);
            // 
            // itemLoad
            // 
            this.itemLoad.Name = "itemLoad";
            this.itemLoad.Size = new System.Drawing.Size(100, 22);
            this.itemLoad.Text = "Load";
            this.itemLoad.Click += new System.EventHandler(this.itemLoad_Click);
            // 
            // ClearB
            // 
            this.ClearB.Location = new System.Drawing.Point(927, 0);
            this.ClearB.Name = "ClearB";
            this.ClearB.Size = new System.Drawing.Size(75, 23);
            this.ClearB.TabIndex = 24;
            this.ClearB.Text = "clear";
            this.ClearB.UseVisualStyleBackColor = true;
            this.ClearB.Click += new System.EventHandler(this.ClearB_Click);
            // 
            // TextScroll
            // 
            this.TextScroll.AutoSize = true;
            this.TextScroll.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextScroll.Location = new System.Drawing.Point(628, 9);
            this.TextScroll.Name = "TextScroll";
            this.TextScroll.Size = new System.Drawing.Size(174, 20);
            this.TextScroll.TabIndex = 23;
            this.TextScroll.Text = "Выберите толщину кисти";
            // 
            // ScrollB
            // 
            this.ScrollB.Location = new System.Drawing.Point(653, 32);
            this.ScrollB.Minimum = 1;
            this.ScrollB.Name = "ScrollB";
            this.ScrollB.Size = new System.Drawing.Size(104, 45);
            this.ScrollB.TabIndex = 22;
            this.ScrollB.Value = 1;
            // 
            // Textun
            // 
            this.Textun.AutoSize = true;
            this.Textun.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Textun.Location = new System.Drawing.Point(409, 9);
            this.Textun.Name = "Textun";
            this.Textun.Size = new System.Drawing.Size(147, 20);
            this.Textun.TabIndex = 21;
            this.Textun.Text = "Выберите цвет кисти";
            // 
            // BlueP
            // 
            this.BlueP.BackColor = System.Drawing.Color.Blue;
            this.BlueP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BlueP.Location = new System.Drawing.Point(517, 32);
            this.BlueP.Name = "BlueP";
            this.BlueP.Size = new System.Drawing.Size(30, 23);
            this.BlueP.TabIndex = 20;
            this.BlueP.UseVisualStyleBackColor = false;
            this.BlueP.Click += new System.EventHandler(this.BlueP_Click);
            // 
            // GreenP
            // 
            this.GreenP.BackColor = System.Drawing.Color.Green;
            this.GreenP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GreenP.Location = new System.Drawing.Point(481, 32);
            this.GreenP.Name = "GreenP";
            this.GreenP.Size = new System.Drawing.Size(30, 23);
            this.GreenP.TabIndex = 19;
            this.GreenP.UseVisualStyleBackColor = false;
            this.GreenP.Click += new System.EventHandler(this.GreenP_Click);
            // 
            // RedP
            // 
            this.RedP.BackColor = System.Drawing.Color.Red;
            this.RedP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RedP.Location = new System.Drawing.Point(445, 32);
            this.RedP.Name = "RedP";
            this.RedP.Size = new System.Drawing.Size(30, 23);
            this.RedP.TabIndex = 18;
            this.RedP.UseVisualStyleBackColor = false;
            this.RedP.Click += new System.EventHandler(this.RedP_Click);
            // 
            // CustomP
            // 
            this.CustomP.BackColor = System.Drawing.Color.White;
            this.CustomP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CustomP.Location = new System.Drawing.Point(409, 32);
            this.CustomP.Name = "CustomP";
            this.CustomP.Size = new System.Drawing.Size(30, 23);
            this.CustomP.TabIndex = 17;
            this.CustomP.UseVisualStyleBackColor = false;
            this.CustomP.Click += new System.EventHandler(this.CustomP_Click);
            // 
            // linB
            // 
            this.linB.Location = new System.Drawing.Point(268, 32);
            this.linB.Name = "linB";
            this.linB.Size = new System.Drawing.Size(65, 23);
            this.linB.TabIndex = 11;
            this.linB.Text = "—";
            this.linB.UseVisualStyleBackColor = true;
            this.linB.Click += new System.EventHandler(this.Line_Click);
            // 
            // cirB
            // 
            this.cirB.Location = new System.Drawing.Point(126, 32);
            this.cirB.Name = "cirB";
            this.cirB.Size = new System.Drawing.Size(65, 23);
            this.cirB.TabIndex = 10;
            this.cirB.Text = "○";
            this.cirB.UseVisualStyleBackColor = true;
            this.cirB.Click += new System.EventHandler(this.Circle_Click);
            // 
            // triB
            // 
            this.triB.Location = new System.Drawing.Point(55, 32);
            this.triB.Name = "triB";
            this.triB.Size = new System.Drawing.Size(65, 23);
            this.triB.TabIndex = 8;
            this.triB.Text = "▲";
            this.triB.UseVisualStyleBackColor = true;
            this.triB.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // recB
            // 
            this.recB.Location = new System.Drawing.Point(197, 32);
            this.recB.Name = "recB";
            this.recB.Size = new System.Drawing.Size(65, 23);
            this.recB.TabIndex = 9;
            this.recB.Text = "▬";
            this.recB.UseVisualStyleBackColor = true;
            this.recB.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // dlgLoad
            // 
            this.dlgLoad.FileName = "openFileDialog1";
            // 
            // FigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 441);
            this.Controls.Add(this.Сanvas);
            this.Controls.Add(this.panelLine);
            this.Controls.Add(this.panelCircle);
            this.Controls.Add(this.panelRectangle);
            this.MainMenuStrip = this.msMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FigureForm";
            this.Text = "FigureForm";
            this.Load += new System.EventHandler(this.Figure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Сanvas)).EndInit();
            this.panelCircle.ResumeLayout(false);
            this.panelCircle.PerformLayout();
            this.panelRectangle.ResumeLayout(false);
            this.panelRectangle.PerformLayout();
            this.panelLine.ResumeLayout(false);
            this.panelLine.PerformLayout();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScrollB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public PictureBox Сanvas;
        private Panel panelCircle;
        private Label lblBackColor_Circle;
        private Label lblStrokeColor_Circle;
        private Label lblRadius_Circle;
        public TextBox txtBoxBackColor_Circle;
        public TextBox txtBoxStrokeColor_Circle;
        private TextBox txtBoxRadius_Circle;
        private Label Texter;
        private Button btnBackColor_Circle;
        private Button btnStrokeColor_Circle;
        private ColorDialog colorDialogFigure;
        private Panel panelLine;
        private Panel panelRectangle;
        private Label lblStrokeColor_Rectangle;
        private TextBox txtBoxStrokeColor_Rectangle;
        private Button btnBackColor_Rectangle;
        private TextBox txtBoxBackColor_Rectangle;
        private Label lblBackColor_Rectangle;
        private Button btnStrokeColor_Rectangle;
        private TextBox txtBoxWidth_Rectangle;
        private TextBox txtBoxHeight_Rectangle;
        private Label lblHeight_Rectangle;
        private Label lblWidth_Rectangle;
        private MenuStrip msMenu;
        private ToolStripMenuItem ItemFile;
        private ToolStripMenuItem ItemSave;
        private ToolStripMenuItem itemLoad;
        private SaveFileDialog dlgSave;
        private OpenFileDialog dlgLoad;
        private Button triB;
        private Button recB;
        private Button cirB;
        private Button linB;
        private Label Textun;
        private Button BlueP;
        private Button GreenP;
        private Button RedP;
        private Button CustomP;
        private TrackBar ScrollB;
        private Label TextScroll;
        private Button ClearB;
    }
}