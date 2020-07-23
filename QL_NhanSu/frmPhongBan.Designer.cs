namespace QL_NhanSu
{
    partial class frmPhongBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhongBan));
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtGHICHU = new System.Windows.Forms.TextBox();
            this.txtSONHANVIEN = new System.Windows.Forms.TextBox();
            this.txtMAPH = new System.Windows.Forms.TextBox();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTENPH = new System.Windows.Forms.TextBox();
            this.listViewExPhongBan = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.itemThoat = new DevComponents.DotNetBar.ButtonX();
            this.itemXoa = new DevComponents.DotNetBar.ButtonX();
            this.itemLuu = new DevComponents.DotNetBar.ButtonX();
            this.itemThemMoi = new DevComponents.DotNetBar.ButtonX();
            this.itemBoQua = new DevComponents.DotNetBar.ButtonX();
            this.itemInNhanh = new DevComponents.DotNetBar.ButtonX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(48, 63);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 20;
            this.labelX5.Text = "Tên Phòng:";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(48, 95);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 19;
            this.labelX4.Text = "Số Nhân Viên:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(48, 130);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 18;
            this.labelX3.Text = "Ghi Chú:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(48, 31);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 16;
            this.labelX1.Text = "Mã Phòng:";
            // 
            // txtGHICHU
            // 
            this.txtGHICHU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGHICHU.Location = new System.Drawing.Point(129, 130);
            this.txtGHICHU.Multiline = true;
            this.txtGHICHU.Name = "txtGHICHU";
            this.txtGHICHU.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGHICHU.Size = new System.Drawing.Size(411, 49);
            this.txtGHICHU.TabIndex = 15;
            // 
            // txtSONHANVIEN
            // 
            this.txtSONHANVIEN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSONHANVIEN.Location = new System.Drawing.Point(129, 98);
            this.txtSONHANVIEN.Name = "txtSONHANVIEN";
            this.txtSONHANVIEN.Size = new System.Drawing.Size(327, 20);
            this.txtSONHANVIEN.TabIndex = 13;
            // 
            // txtMAPH
            // 
            this.txtMAPH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMAPH.Location = new System.Drawing.Point(129, 34);
            this.txtMAPH.Name = "txtMAPH";
            this.txtMAPH.ReadOnly = true;
            this.txtMAPH.Size = new System.Drawing.Size(327, 20);
            this.txtMAPH.TabIndex = 9;
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel3.Location = new System.Drawing.Point(0, 233);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(573, 100);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 1;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Phòng Ban";
            this.columnHeader2.Width = 145;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MP";
            this.columnHeader1.Width = 40;
            // 
            // txtTENPH
            // 
            this.txtTENPH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTENPH.Location = new System.Drawing.Point(129, 66);
            this.txtTENPH.Name = "txtTENPH";
            this.txtTENPH.Size = new System.Drawing.Size(327, 20);
            this.txtTENPH.TabIndex = 11;
            // 
            // listViewExPhongBan
            // 
            // 
            // 
            // 
            this.listViewExPhongBan.Border.Class = "ListViewBorder";
            this.listViewExPhongBan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.listViewExPhongBan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewExPhongBan.DisabledBackColor = System.Drawing.Color.Empty;
            this.listViewExPhongBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewExPhongBan.FullRowSelect = true;
            this.listViewExPhongBan.GridLines = true;
            this.listViewExPhongBan.Location = new System.Drawing.Point(0, 0);
            this.listViewExPhongBan.MultiSelect = false;
            this.listViewExPhongBan.Name = "listViewExPhongBan";
            this.listViewExPhongBan.Size = new System.Drawing.Size(279, 460);
            this.listViewExPhongBan.TabIndex = 2;
            this.listViewExPhongBan.UseCompatibleStateImageBehavior = false;
            this.listViewExPhongBan.View = System.Windows.Forms.View.Details;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupPanel3);
            this.splitContainer1.Panel2.Controls.Add(this.groupPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(862, 481);
            this.splitContainer1.SplitterDistance = 285;
            this.splitContainer1.TabIndex = 3;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.listViewExPhongBan);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(285, 481);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "Danh Sách Phòng Ban";
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.labelX5);
            this.groupPanel2.Controls.Add(this.labelX4);
            this.groupPanel2.Controls.Add(this.labelX3);
            this.groupPanel2.Controls.Add(this.labelX1);
            this.groupPanel2.Controls.Add(this.txtGHICHU);
            this.groupPanel2.Controls.Add(this.txtSONHANVIEN);
            this.groupPanel2.Controls.Add(this.txtTENPH);
            this.groupPanel2.Controls.Add(this.txtMAPH);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel2.Location = new System.Drawing.Point(0, 0);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(573, 233);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 0;
            this.groupPanel2.Text = "Thông Tin";
            // 
            // itemThoat
            // 
            this.itemThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.itemThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.itemThoat.Location = new System.Drawing.Point(509, 28);
            this.itemThoat.Name = "itemThoat";
            this.itemThoat.Size = new System.Drawing.Size(75, 23);
            this.itemThoat.TabIndex = 5;
            this.itemThoat.Text = "Thoát";
            // 
            // itemXoa
            // 
            this.itemXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.itemXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.itemXoa.Location = new System.Drawing.Point(428, 28);
            this.itemXoa.Name = "itemXoa";
            this.itemXoa.Size = new System.Drawing.Size(75, 23);
            this.itemXoa.TabIndex = 4;
            this.itemXoa.Text = "Xóa";
            // 
            // itemLuu
            // 
            this.itemLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.itemLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.itemLuu.Location = new System.Drawing.Point(347, 29);
            this.itemLuu.Name = "itemLuu";
            this.itemLuu.Size = new System.Drawing.Size(75, 23);
            this.itemLuu.TabIndex = 3;
            this.itemLuu.Text = "Lưu Lại";
            // 
            // itemThemMoi
            // 
            this.itemThemMoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.itemThemMoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.itemThemMoi.Location = new System.Drawing.Point(175, 28);
            this.itemThemMoi.Name = "itemThemMoi";
            this.itemThemMoi.Size = new System.Drawing.Size(75, 23);
            this.itemThemMoi.TabIndex = 2;
            this.itemThemMoi.Text = "Thêm Mới";
            // 
            // itemBoQua
            // 
            this.itemBoQua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.itemBoQua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.itemBoQua.Location = new System.Drawing.Point(256, 29);
            this.itemBoQua.Name = "itemBoQua";
            this.itemBoQua.Size = new System.Drawing.Size(75, 23);
            this.itemBoQua.TabIndex = 1;
            this.itemBoQua.Text = "Bỏ Qua";
            // 
            // itemInNhanh
            // 
            this.itemInNhanh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.itemInNhanh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.itemInNhanh.Location = new System.Drawing.Point(3, 28);
            this.itemInNhanh.Name = "itemInNhanh";
            this.itemInNhanh.Size = new System.Drawing.Size(75, 23);
            this.itemInNhanh.TabIndex = 0;
            this.itemInNhanh.Text = "In Nhanh";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.itemThoat);
            this.panel1.Controls.Add(this.itemXoa);
            this.panel1.Controls.Add(this.itemLuu);
            this.panel1.Controls.Add(this.itemThemMoi);
            this.panel1.Controls.Add(this.itemBoQua);
            this.panel1.Controls.Add(this.itemInNhanh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 481);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 64);
            this.panel1.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "start.png");
            // 
            // frmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 545);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "frmPhongBan";
            this.Text = "frmPhongBan";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.TextBox txtGHICHU;
        private System.Windows.Forms.TextBox txtSONHANVIEN;
        private System.Windows.Forms.TextBox txtMAPH;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox txtTENPH;
        private DevComponents.DotNetBar.Controls.ListViewEx listViewExPhongBan;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX itemThoat;
        private DevComponents.DotNetBar.ButtonX itemXoa;
        private DevComponents.DotNetBar.ButtonX itemLuu;
        private DevComponents.DotNetBar.ButtonX itemThemMoi;
        private DevComponents.DotNetBar.ButtonX itemBoQua;
        private DevComponents.DotNetBar.ButtonX itemInNhanh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
    }
}