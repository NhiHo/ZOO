namespace ZOO
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hồSơToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.mmuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mmuEnd = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaĐổiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saoChépToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cắtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lstThumoi = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstDanhsachthu = new System.Windows.Forms.ListBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hồSơToolStripMenuItem,
            this.sửaĐổiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(399, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hồSơToolStripMenuItem
            // 
            this.hồSơToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmuLoad,
            this.mmuSave,
            this.mmuEnd});
            this.hồSơToolStripMenuItem.Name = "hồSơToolStripMenuItem";
            this.hồSơToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.hồSơToolStripMenuItem.Text = "Hồ Sơ";
            // 
            // mmuLoad
            // 
            this.mmuLoad.Image = ((System.Drawing.Image)(resources.GetObject("mmuLoad.Image")));
            this.mmuLoad.Name = "mmuLoad";
            this.mmuLoad.Size = new System.Drawing.Size(151, 22);
            this.mmuLoad.Text = "Tạo danh sách";
            this.mmuLoad.Click += new System.EventHandler(this.mmuLoad_Click);
            // 
            // mmuSave
            // 
            this.mmuSave.Image = ((System.Drawing.Image)(resources.GetObject("mmuSave.Image")));
            this.mmuSave.Name = "mmuSave";
            this.mmuSave.Size = new System.Drawing.Size(151, 22);
            this.mmuSave.Text = "Lưu danh sách";
            // 
            // mmuEnd
            // 
            this.mmuEnd.Image = ((System.Drawing.Image)(resources.GetObject("mmuEnd.Image")));
            this.mmuEnd.Name = "mmuEnd";
            this.mmuEnd.Size = new System.Drawing.Size(151, 22);
            this.mmuEnd.Text = "Kết thúc";
            this.mmuEnd.Click += new System.EventHandler(this.mmuEnd_Click);
            // 
            // sửaĐổiToolStripMenuItem
            // 
            this.sửaĐổiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saoChépToolStripMenuItem,
            this.cắtToolStripMenuItem,
            this.dánToolStripMenuItem});
            this.sửaĐổiToolStripMenuItem.Name = "sửaĐổiToolStripMenuItem";
            this.sửaĐổiToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.sửaĐổiToolStripMenuItem.Text = "Sửa đổi";
            // 
            // saoChépToolStripMenuItem
            // 
            this.saoChépToolStripMenuItem.Name = "saoChépToolStripMenuItem";
            this.saoChépToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + C";
            this.saoChépToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.saoChépToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.saoChépToolStripMenuItem.Text = "Sao chép";
            // 
            // cắtToolStripMenuItem
            // 
            this.cắtToolStripMenuItem.Name = "cắtToolStripMenuItem";
            this.cắtToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + X";
            this.cắtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cắtToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.cắtToolStripMenuItem.Text = "Cắt";
            // 
            // dánToolStripMenuItem
            // 
            this.dánToolStripMenuItem.Name = "dánToolStripMenuItem";
            this.dánToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + V";
            this.dánToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.dánToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.dánToolStripMenuItem.Text = "Dán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thú mới";
            // 
            // lstThumoi
            // 
            this.lstThumoi.FormattingEnabled = true;
            this.lstThumoi.Location = new System.Drawing.Point(13, 45);
            this.lstThumoi.Name = "lstThumoi";
            this.lstThumoi.Size = new System.Drawing.Size(120, 160);
            this.lstThumoi.TabIndex = 2;
            this.lstThumoi.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            this.lstThumoi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách thú";
            // 
            // lstDanhsachthu
            // 
            this.lstDanhsachthu.FormattingEnabled = true;
            this.lstDanhsachthu.Location = new System.Drawing.Point(140, 45);
            this.lstDanhsachthu.Name = "lstDanhsachthu";
            this.lstDanhsachthu.Size = new System.Drawing.Size(120, 160);
            this.lstDanhsachthu.TabIndex = 4;
            this.lstDanhsachthu.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstDanhsachthu_DragDrop);
            this.lstDanhsachthu.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            this.lstDanhsachthu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(13, 239);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(35, 13);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "label3";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageIndex = 0;
            this.btnSave.ImageList = this.imageList1;
            this.btnSave.Location = new System.Drawing.Point(265, 229);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Lưu danh sách";
            this.toolTip1.SetToolTip(this.btnSave, "Lưu danh sách vào file Danhsachthu.txt");
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Save-icon.png");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 264);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lstDanhsachthu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstThumoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Zoo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hồSơToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mmuLoad;
        private System.Windows.Forms.ToolStripMenuItem mmuSave;
        private System.Windows.Forms.ToolStripMenuItem mmuEnd;
        private System.Windows.Forms.ToolStripMenuItem sửaĐổiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saoChépToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cắtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dánToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstThumoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstDanhsachthu;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
    }
}

