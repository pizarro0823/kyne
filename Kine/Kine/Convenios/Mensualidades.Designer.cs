namespace Kine.Convenios
{
    partial class Mensualidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mensualidades));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbsoga = new System.Windows.Forms.PictureBox();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.btnmin = new Guna.UI.WinForms.GunaButton();
            this.btnmax = new Guna.UI.WinForms.GunaButton();
            this.btncerrar = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.caldesde = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btn_guardar = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calhasta = new Guna.UI.WinForms.GunaDateTimePicker();
            this.pbresize = new System.Windows.Forms.PictureBox();
            this.btn_delete = new Guna.UI.WinForms.GunaButton();
            this.adgvconvenios = new ADGV.AdvancedDataGridView();
            this.chfecing = new System.Windows.Forms.CheckBox();
            this.chfecfin = new System.Windows.Forms.CheckBox();
            this.cmsgrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.opcCopiadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarConEncabezdoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosEliminadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bsgrid = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbsoga)).BeginInit();
            this.gunaGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbresize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adgvconvenios)).BeginInit();
            this.cmsgrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pbsoga
            // 
            this.pbsoga.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbsoga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbsoga.Image = ((System.Drawing.Image)(resources.GetObject("pbsoga.Image")));
            this.pbsoga.Location = new System.Drawing.Point(987, 10);
            this.pbsoga.Name = "pbsoga";
            this.pbsoga.Size = new System.Drawing.Size(169, 652);
            this.pbsoga.TabIndex = 0;
            this.pbsoga.TabStop = false;
            this.pbsoga.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mensualidades_MouseMove);
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
            this.gunaGradientPanel1.Location = new System.Drawing.Point(-4, -2);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(1164, 42);
            this.gunaGradientPanel1.TabIndex = 1;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            this.gunaGradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mensualidades_MouseMove);
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
            this.btnmin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnmin.Location = new System.Drawing.Point(1068, 3);
            this.btnmin.Name = "btnmin";
            this.btnmin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
            this.btnmin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnmin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnmin.OnHoverImage = null;
            this.btnmin.OnPressedColor = System.Drawing.Color.Black;
            this.btnmin.Radius = 9;
            this.btnmin.Size = new System.Drawing.Size(31, 26);
            this.btnmin.TabIndex = 27;
            this.btnmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // btnmax
            // 
            this.btnmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmax.AnimationHoverSpeed = 0.07F;
            this.btnmax.AnimationSpeed = 0.03F;
            this.btnmax.BackColor = System.Drawing.Color.Transparent;
            this.btnmax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmax.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
            this.btnmax.BorderColor = System.Drawing.Color.Black;
            this.btnmax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmax.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnmax.FocusedColor = System.Drawing.Color.Empty;
            this.btnmax.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnmax.ForeColor = System.Drawing.Color.White;
            this.btnmax.Image = ((System.Drawing.Image)(resources.GetObject("btnmax.Image")));
            this.btnmax.ImageSize = new System.Drawing.Size(20, 20);
            this.btnmax.Location = new System.Drawing.Point(1097, 3);
            this.btnmax.Name = "btnmax";
            this.btnmax.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
            this.btnmax.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnmax.OnHoverForeColor = System.Drawing.Color.White;
            this.btnmax.OnHoverImage = null;
            this.btnmax.OnPressedColor = System.Drawing.Color.Black;
            this.btnmax.Radius = 9;
            this.btnmax.Size = new System.Drawing.Size(34, 26);
            this.btnmax.TabIndex = 26;
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
            this.btncerrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btncerrar.Location = new System.Drawing.Point(1125, 3);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
            this.btncerrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btncerrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btncerrar.OnHoverImage = null;
            this.btncerrar.OnPressedColor = System.Drawing.Color.Black;
            this.btncerrar.Radius = 9;
            this.btncerrar.Size = new System.Drawing.Size(31, 26);
            this.btncerrar.TabIndex = 25;
            this.btncerrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btncerrar.Click += new System.EventHandler(this.bbtncerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Convenios";
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
            this.caldesde.Location = new System.Drawing.Point(67, 72);
            this.caldesde.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.caldesde.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.caldesde.Name = "caldesde";
            this.caldesde.OnHoverBaseColor = System.Drawing.Color.White;
            this.caldesde.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.caldesde.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.caldesde.OnPressedColor = System.Drawing.Color.Black;
            this.caldesde.Size = new System.Drawing.Size(132, 30);
            this.caldesde.TabIndex = 18;
            this.caldesde.Text = "16/11/2020";
            this.caldesde.Value = new System.DateTime(2020, 11, 16, 19, 8, 11, 883);
            // 
            // btn_guardar
            // 
            this.btn_guardar.AnimationHoverSpeed = 0.07F;
            this.btn_guardar.AnimationSpeed = 0.03F;
            this.btn_guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_guardar.BorderColor = System.Drawing.Color.Black;
            this.btn_guardar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_guardar.FocusedColor = System.Drawing.Color.Empty;
            this.btn_guardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Image = null;
            this.btn_guardar.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_guardar.Location = new System.Drawing.Point(417, 70);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btn_guardar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_guardar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_guardar.OnHoverImage = null;
            this.btn_guardar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_guardar.Radius = 9;
            this.btn_guardar.Size = new System.Drawing.Size(85, 32);
            this.btn_guardar.TabIndex = 20;
            this.btn_guardar.Text = "Consultar";
            this.btn_guardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(213, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 23;
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
            this.calhasta.Location = new System.Drawing.Point(268, 72);
            this.calhasta.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.calhasta.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.calhasta.Name = "calhasta";
            this.calhasta.OnHoverBaseColor = System.Drawing.Color.White;
            this.calhasta.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.calhasta.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.calhasta.OnPressedColor = System.Drawing.Color.Black;
            this.calhasta.Size = new System.Drawing.Size(132, 30);
            this.calhasta.TabIndex = 22;
            this.calhasta.Text = "16/11/2020";
            this.calhasta.Value = new System.DateTime(2020, 11, 16, 19, 8, 11, 883);
            // 
            // pbresize
            // 
            this.pbresize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbresize.BackColor = System.Drawing.Color.Transparent;
            this.pbresize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbresize.BackgroundImage")));
            this.pbresize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbresize.Location = new System.Drawing.Point(1134, 643);
            this.pbresize.Name = "pbresize";
            this.pbresize.Size = new System.Drawing.Size(19, 19);
            this.pbresize.TabIndex = 25;
            this.pbresize.TabStop = false;
            this.pbresize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mensualidades_MouseMove);
            // 
            // btn_delete
            // 
            this.btn_delete.AnimationHoverSpeed = 0.07F;
            this.btn_delete.AnimationSpeed = 0.03F;
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BaseColor = System.Drawing.Color.Red;
            this.btn_delete.BorderColor = System.Drawing.Color.Black;
            this.btn_delete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_delete.FocusedColor = System.Drawing.Color.Empty;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Image = null;
            this.btn_delete.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_delete.Location = new System.Drawing.Point(516, 70);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btn_delete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_delete.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_delete.OnHoverImage = null;
            this.btn_delete.OnPressedColor = System.Drawing.Color.Black;
            this.btn_delete.Radius = 9;
            this.btn_delete.Size = new System.Drawing.Size(79, 32);
            this.btn_delete.TabIndex = 26;
            this.btn_delete.Text = "Eliminar";
            this.btn_delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // adgvconvenios
            // 
            this.adgvconvenios.AllowUserToAddRows = false;
            this.adgvconvenios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adgvconvenios.AutoGenerateContextFilters = true;
            this.adgvconvenios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adgvconvenios.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adgvconvenios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.adgvconvenios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvconvenios.ContextMenuStrip = this.cmsgrid;
            this.adgvconvenios.DateWithTime = false;
            this.adgvconvenios.EnableHeadersVisualStyles = false;
            this.adgvconvenios.Location = new System.Drawing.Point(12, 114);
            this.adgvconvenios.Name = "adgvconvenios";
            this.adgvconvenios.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adgvconvenios.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.adgvconvenios.Size = new System.Drawing.Size(984, 536);
            this.adgvconvenios.TabIndex = 27;
            this.adgvconvenios.TimeFilter = false;
            this.adgvconvenios.SortStringChanged += new System.EventHandler(this.dgv_sort);
            this.adgvconvenios.FilterStringChanged += new System.EventHandler(this.dgv_filters);
            // 
            // chfecing
            // 
            this.chfecing.AutoSize = true;
            this.chfecing.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chfecing.Location = new System.Drawing.Point(24, 46);
            this.chfecing.Name = "chfecing";
            this.chfecing.Size = new System.Drawing.Size(118, 20);
            this.chfecing.TabIndex = 28;
            this.chfecing.Text = "Fecha ingreso";
            this.chfecing.UseVisualStyleBackColor = true;
            this.chfecing.Click += new System.EventHandler(this.chfecing_Click);
            // 
            // chfecfin
            // 
            this.chfecfin.AutoSize = true;
            this.chfecfin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chfecfin.Location = new System.Drawing.Point(172, 46);
            this.chfecfin.Name = "chfecfin";
            this.chfecfin.Size = new System.Drawing.Size(146, 20);
            this.chfecfin.TabIndex = 29;
            this.chfecfin.Text = "Fecha finalización";
            this.chfecfin.UseVisualStyleBackColor = true;
            this.chfecfin.Click += new System.EventHandler(this.chfecfin_Click);
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
            // Mensualidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 662);
            this.Controls.Add(this.chfecfin);
            this.Controls.Add(this.chfecing);
            this.Controls.Add(this.adgvconvenios);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.pbresize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calhasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.caldesde);
            this.Controls.Add(this.gunaGradientPanel1);
            this.Controls.Add(this.pbsoga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mensualidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensualidades";
            this.Load += new System.EventHandler(this.Mensualidades_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mensualidades_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbsoga)).EndInit();
            this.gunaGradientPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbresize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adgvconvenios)).EndInit();
            this.cmsgrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbsoga;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDateTimePicker caldesde;
        private Guna.UI.WinForms.GunaButton btn_guardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaDateTimePicker calhasta;
        private Guna.UI.WinForms.GunaButton btnmin;
        private Guna.UI.WinForms.GunaButton btnmax;
        private Guna.UI.WinForms.GunaButton btncerrar;
        private System.Windows.Forms.PictureBox pbresize;
        private Guna.UI.WinForms.GunaButton btn_delete;
        private ADGV.AdvancedDataGridView adgvconvenios;
        private System.Windows.Forms.CheckBox chfecing;
        private System.Windows.Forms.CheckBox chfecfin;
        private System.Windows.Forms.ContextMenuStrip cmsgrid;
        private System.Windows.Forms.ToolStripMenuItem opcCopiadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarConEncabezdoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosEliminadosToolStripMenuItem;
        private System.Windows.Forms.BindingSource bsgrid;
    }
}