﻿namespace NIDE
{
    partial class fPngEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPngEditor));
            this.DrawPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbColor = new System.Windows.Forms.ToolStripButton();
            this.tsbDraw = new System.Windows.Forms.ToolStripButton();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawPanel
            // 
            this.DrawPanel.BackColor = System.Drawing.Color.White;
            this.DrawPanel.BackgroundImage = global::NIDE.Properties.Resources.background;
            this.DrawPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.DrawPanel.ColumnCount = 16;
            this.DrawPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrawPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrawPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrawPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrawPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrawPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrawPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrawPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrawPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrawPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrawPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrawPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrawPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrawPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrawPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrawPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.DrawPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DrawPanel.Location = new System.Drawing.Point(0, 28);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.RowCount = 16;
            this.DrawPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrawPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrawPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrawPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrawPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrawPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrawPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrawPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrawPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrawPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrawPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrawPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrawPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrawPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrawPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrawPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DrawPanel.Size = new System.Drawing.Size(337, 336);
            this.DrawPanel.TabIndex = 0;
            this.DrawPanel.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.DrawPanel_CellPaint);
            this.DrawPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseClick);
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.tsbSave,
            this.toolStripSeparator1,
            this.tsbColor,
            this.toolStripButton1,
            this.tsbDraw,
            this.tsbClear});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(337, 25);
            this.tsMain.TabIndex = 0;
            this.tsMain.Text = "toolStrip1";
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Text = "Save";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbOpen
            // 
            this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpen.Image")));
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(23, 22);
            this.tsbOpen.Text = "Open";
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // tsbColor
            // 
            this.tsbColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbColor.Image = ((System.Drawing.Image)(resources.GetObject("tsbColor.Image")));
            this.tsbColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbColor.Name = "tsbColor";
            this.tsbColor.Size = new System.Drawing.Size(23, 22);
            this.tsbColor.Text = "Choose color";
            this.tsbColor.Click += new System.EventHandler(this.tsbColor_Click);
            // 
            // tsbDraw
            // 
            this.tsbDraw.Checked = true;
            this.tsbDraw.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbDraw.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDraw.Image = ((System.Drawing.Image)(resources.GetObject("tsbDraw.Image")));
            this.tsbDraw.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDraw.Name = "tsbDraw";
            this.tsbDraw.Size = new System.Drawing.Size(23, 22);
            this.tsbDraw.Text = "Draw";
            this.tsbDraw.Click += new System.EventHandler(this.tsbDraw_Click);
            // 
            // tsbClear
            // 
            this.tsbClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClear.Image = ((System.Drawing.Image)(resources.GetObject("tsbClear.Image")));
            this.tsbClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClear.Name = "tsbClear";
            this.tsbClear.Size = new System.Drawing.Size(23, 22);
            this.tsbClear.Text = "Erase";
            this.tsbClear.Click += new System.EventHandler(this.tsbClear_Click);
            // 
            // dlgColor
            // 
            this.dlgColor.FullOpen = true;
            // 
            // dlgOpen
            // 
            this.dlgOpen.DefaultExt = "png";
            this.dlgOpen.FileName = "/textures";
            this.dlgOpen.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgOpen_FileOk);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Pick color";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // fPngEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 364);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.DrawPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "fPngEditor";
            this.Text = "fPngEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fPngEditor_FormClosing);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel DrawPanel;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ColorDialog dlgColor;
        private System.Windows.Forms.ToolStripButton tsbColor;
        private System.Windows.Forms.ToolStripButton tsbDraw;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}