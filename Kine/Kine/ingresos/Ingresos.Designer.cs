namespace Kine.ingresos
{
    partial class Ingresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingresos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.btnmin = new Guna.UI.WinForms.GunaButton();
            this.btnmax = new Guna.UI.WinForms.GunaButton();
            this.btncerrar = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calhasta = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnconsultar = new Guna.UI.WinForms.GunaButton();
            this.caldesde = new Guna.UI.WinForms.GunaDateTimePicker();
            this.adgvingresos = new ADGV.AdvancedDataGridView();
            this.pbresize = new System.Windows.Forms.PictureBox();
            this.lbltotales = new System.Windows.Forms.Label();
            this.bsgrid = new System.Windows.Forms.BindingSource(this.components);
            this.cmsgrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.opcCopiadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarConEncabezdoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosEliminadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.gunaGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adgvingresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbresize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsgrid)).BeginInit();
            this.cmsgrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(1070, 41);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(122, 450);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.btnmin);
            this.gunaGradientPanel1.Controls.Add(this.btnmax);
            this.gunaGradientPanel1.Controls.Add(this.btncerrar);
            this.gunaGradientPanel1.Controls.Add(this.label1);
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
            this.gunaGradientPanel1.Location = new System.Drawing.Point(-7, -1);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(1208, 42);
            this.gunaGradientPanel1.TabIndex = 2;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            this.gunaGradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gen_MouseMove);
            // 
            // btnmin
            // 
            this.btnmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmin.AnimationHoverSpeed = 0.07F;
            this.btnmin.AnimationSpeed = 0.03F;
            this.btnmin.BackColor = System.Drawing.Color.Transparent;
            this.btnmin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
            this.btnmin.BorderColor = System.Drawing.Color.Black;
            this.btnmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnmin.FocusedColor = System.Drawing.Color.Empty;
            this.btnmin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmin.ForeColor = System.Drawing.Color.White;
            this.btnmin.Image = ((System.Drawing.Image)(resources.GetObject("btnmin.Image")));
            this.btnmin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnmin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnmin.Location = new System.Drawing.Point(1114, 3);
            this.btnmin.Name = "btnmin";
            this.btnmin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
            this.btnmin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnmin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnmin.OnHoverImage = null;
            this.btnmin.OnPressedColor = System.Drawing.Color.Black;
            this.btnmin.Radius = 9;
            this.btnmin.Size = new System.Drawing.Size(27, 26);
            this.btnmin.TabIndex = 24;
            this.btnmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // btnmax
            // 
            this.btnmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmax.AnimationHoverSpeed = 0.07F;
            this.btnmax.AnimationSpeed = 0.03F;
            this.btnmax.BackColor = System.Drawing.Color.Transparent;
            this.btnmax.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
            this.btnmax.BorderColor = System.Drawing.Color.Black;
            this.btnmax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmax.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnmax.FocusedColor = System.Drawing.Color.Empty;
            this.btnmax.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnmax.ForeColor = System.Drawing.Color.White;
            this.btnmax.Image = ((System.Drawing.Image)(resources.GetObject("btnmax.Image")));
            this.btnmax.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnmax.ImageSize = new System.Drawing.Size(20, 20);
            this.btnmax.Location = new System.Drawing.Point(1142, 3);
            this.btnmax.Name = "btnmax";
            this.btnmax.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
            this.btnmax.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnmax.OnHoverForeColor = System.Drawing.Color.White;
            this.btnmax.OnHoverImage = null;
            this.btnmax.OnPressedColor = System.Drawing.Color.Black;
            this.btnmax.Radius = 9;
            this.btnmax.Size = new System.Drawing.Size(27, 26);
            this.btnmax.TabIndex = 23;
            this.btnmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnmax.Click += new System.EventHandler(this.btnmax_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.AnimationHoverSpeed = 0.07F;
            this.btncerrar.AnimationSpeed = 0.03F;
            this.btncerrar.BackColor = System.Drawing.Color.Transparent;
            this.btncerrar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
            this.btncerrar.BorderColor = System.Drawing.Color.Black;
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btncerrar.FocusedColor = System.Drawing.Color.Empty;
            this.btncerrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.ForeColor = System.Drawing.Color.White;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btncerrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btncerrar.Location = new System.Drawing.Point(1168, 3);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
            this.btncerrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btncerrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btncerrar.OnHoverImage = null;
            this.btncerrar.OnPressedColor = System.Drawing.Color.Black;
            this.btncerrar.Radius = 9;
            this.btncerrar.Size = new System.Drawing.Size(31, 26);
            this.btncerrar.TabIndex = 22;
            this.btncerrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btncerrar.Click += new System.EventHandler(this.gunaButton5_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 10);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar ingresos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(221, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Hasta";
            // 
            // calhasta
            // 
            this.calhasta.BaseColor = System.Drawing.Color.White;
            this.calhasta.BorderColor = System.Drawing.Color.Silver;
            this.calhasta.CustomFormat = null;
            this.calhasta.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.calhasta.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.calhasta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.calhasta.ForeColor = System.Drawing.Color.Black;
            this.calhasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.calhasta.Location = new System.Drawing.Point(276, 56);
            this.calhasta.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.calhasta.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.calhasta.Name = "calhasta";
            this.calhasta.OnHoverBaseColor = System.Drawing.Color.White;
            this.calhasta.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.calhasta.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.calhasta.OnPressedColor = System.Drawing.Color.Black;
            this.calhasta.Size = new System.Drawing.Size(132, 30);
            this.calhasta.TabIndex = 27;
            this.calhasta.Text = "16/11/2020";
            this.calhasta.Value = new System.DateTime(2020, 11, 16, 19, 8, 11, 883);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Desde";
            // 
            // btnconsultar
            // 
            this.btnconsultar.AnimationHoverSpeed = 0.07F;
            this.btnconsultar.AnimationSpeed = 0.03F;
            this.btnconsultar.BackColor = System.Drawing.Color.Transparent;
            this.btnconsultar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnconsultar.BorderColor = System.Drawing.Color.Black;
            this.btnconsultar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnconsultar.FocusedColor = System.Drawing.Color.Empty;
            this.btnconsultar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnconsultar.ForeColor = System.Drawing.Color.White;
            this.btnconsultar.Image = null;
            this.btnconsultar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnconsultar.Location = new System.Drawing.Point(425, 54);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnconsultar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnconsultar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnconsultar.OnHoverImage = null;
            this.btnconsultar.OnPressedColor = System.Drawing.Color.Black;
            this.btnconsultar.Radius = 9;
            this.btnconsultar.Size = new System.Drawing.Size(85, 32);
            this.btnconsultar.TabIndex = 25;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // caldesde
            // 
            this.caldesde.BaseColor = System.Drawing.Color.White;
            this.caldesde.BorderColor = System.Drawing.Color.Silver;
            this.caldesde.CustomFormat = null;
            this.caldesde.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.caldesde.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.caldesde.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.caldesde.ForeColor = System.Drawing.Color.Black;
            this.caldesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.caldesde.Location = new System.Drawing.Point(75, 56);
            this.caldesde.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.caldesde.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.caldesde.Name = "caldesde";
            this.caldesde.OnHoverBaseColor = System.Drawing.Color.White;
            this.caldesde.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.caldesde.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.caldesde.OnPressedColor = System.Drawing.Color.Black;
            this.caldesde.Size = new System.Drawing.Size(132, 30);
            this.caldesde.TabIndex = 24;
            this.caldesde.Text = "16/11/2020";
            this.caldesde.Value = new System.DateTime(2020, 11, 16, 19, 8, 11, 883);
            // 
            // adgvingresos
            // 
            this.adgvingresos.AllowUserToAddRows = false;
            this.adgvingresos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adgvingresos.AutoGenerateContextFilters = true;
            this.adgvingresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adgvingresos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adgvingresos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.adgvingresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvingresos.ContextMenuStrip = this.cmsgrid;
            this.adgvingresos.DateWithTime = false;
            this.adgvingresos.EnableHeadersVisualStyles = false;
            this.adgvingresos.Location = new System.Drawing.Point(12, 92);
            this.adgvingresos.Name = "adgvingresos";
            this.adgvingresos.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adgvingresos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.adgvingresos.Size = new System.Drawing.Size(1052, 460);
            this.adgvingresos.TabIndex = 29;
            this.adgvingresos.TimeFilter = false;
            this.adgvingresos.SortStringChanged += new System.EventHandler(this.dgv_sort);
            this.adgvingresos.FilterStringChanged += new System.EventHandler(this.dgv_filters);
            // 
            // pbresize
            // 
            this.pbresize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbresize.BackColor = System.Drawing.Color.Transparent;
            this.pbresize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbresize.BackgroundImage")));
            this.pbresize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbresize.Location = new System.Drawing.Point(1173, 574);
            this.pbresize.Name = "pbresize";
            this.pbresize.Size = new System.Drawing.Size(19, 19);
            this.pbresize.TabIndex = 30;
            this.pbresize.TabStop = false;
            this.pbresize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gen_MouseMove);
            // 
            // lbltotales
            // 
            this.lbltotales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltotales.AutoSize = true;
            this.lbltotales.BackColor = System.Drawing.Color.Transparent;
            this.lbltotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbltotales.ForeColor = System.Drawing.Color.Black;
            this.lbltotales.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbltotales.Location = new System.Drawing.Point(20, 565);
            this.lbltotales.Name = "lbltotales";
            this.lbltotales.Size = new System.Drawing.Size(65, 16);
            this.lbltotales.TabIndex = 31;
            this.lbltotales.Text = "Totales:";
            this.lbltotales.Visible = false;
            // 
            // cmsgrid
            // 
            this.cmsgrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcCopiadoToolStripMenuItem,
            this.datosEliminadosToolStripMenuItem});
            this.cmsgrid.Name = "cmsgrid";
            this.cmsgrid.Size = new System.Drawing.Size(166, 48);
            // 
            // opcCopiadoToolStripMenuItem
            // 
            this.opcCopiadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.copiarConEncabezdoToolStripMenuItem});
            this.opcCopiadoToolStripMenuItem.Name = "opcCopiadoToolStripMenuItem";
            this.opcCopiadoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.opcCopiadoToolStripMenuItem.Text = "Opc. copiado";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // copiarConEncabezdoToolStripMenuItem
            // 
            this.copiarConEncabezdoToolStripMenuItem.Name = "copiarConEncabezdoToolStripMenuItem";
            this.copiarConEncabezdoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.copiarConEncabezdoToolStripMenuItem.Text = "Copiar con encabezdo";
            this.copiarConEncabezdoToolStripMenuItem.Click += new System.EventHandler(this.copiarConEncabezdoToolStripMenuItem_Click);
            // 
            // datosEliminadosToolStripMenuItem
            // 
            this.datosEliminadosToolStripMenuItem.Name = "datosEliminadosToolStripMenuItem";
            this.datosEliminadosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.datosEliminadosToolStripMenuItem.Text = "Datos eliminados";
            this.datosEliminadosToolStripMenuItem.Click += new System.EventHandler(this.datosEliminadosToolStripMenuItem_Click);
            // 
            // Ingresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 596);
            this.Controls.Add(this.lbltotales);
            this.Controls.Add(this.pbresize);
            this.Controls.Add(this.adgvingresos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gunaGradientPanel1);
            this.Controls.Add(this.calhasta);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.caldesde);
            this.Controls.Add(this.btnconsultar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ingresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresos";
            this.Load += new System.EventHandler(this.Ingresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.gunaGradientPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adgvingresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbresize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsgrid)).EndInit();
            this.cmsgrid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaDateTimePicker calhasta;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton btnconsultar;
        private Guna.UI.WinForms.GunaDateTimePicker caldesde;
        private Guna.UI.WinForms.GunaButton btnmin;
        private Guna.UI.WinForms.GunaButton btnmax;
        private Guna.UI.WinForms.GunaButton btncerrar;
        private ADGV.AdvancedDataGridView adgvingresos;
        private System.Windows.Forms.PictureBox pbresize;
        private System.Windows.Forms.Label lbltotales;
        private System.Windows.Forms.BindingSource bsgrid;
        private System.Windows.Forms.ContextMenuStrip cmsgrid;
        private System.Windows.Forms.ToolStripMenuItem opcCopiadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarConEncabezdoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosEliminadosToolStripMenuItem;
    }
}