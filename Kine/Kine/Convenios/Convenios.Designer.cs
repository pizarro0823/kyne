namespace Kine.Convenios
{
    partial class Convenios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Convenios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaButton5 = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tipo_convenio = new Guna.UI.WinForms.GunaTextBox();
            this.txt_convenio_dias = new Guna.UI.WinForms.GunaTextBox();
            this.txt_convenio_valor = new Guna.UI.WinForms.GunaTextBox();
            this.btn_convenio_Save = new Guna.UI.WinForms.GunaButton();
            this.btn_convenio_Modificar = new Guna.UI.WinForms.GunaButton();
            this.btn_delete = new Guna.UI.WinForms.GunaButton();
            this.adgvconv = new ADGV.AdvancedDataGridView();
            this.bsconv = new System.Windows.Forms.BindingSource(this.components);
            this.gunaGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adgvconv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsconv)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.gunaButton5);
            this.gunaGradientPanel1.Controls.Add(this.label1);
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
            this.gunaGradientPanel1.Location = new System.Drawing.Point(-36, -1);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(1035, 42);
            this.gunaGradientPanel1.TabIndex = 10;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            this.gunaGradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gen_MouseMove);
            // 
            // gunaButton5
            // 
            this.gunaButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaButton5.AnimationHoverSpeed = 0.07F;
            this.gunaButton5.AnimationSpeed = 0.03F;
            this.gunaButton5.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
            this.gunaButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton5.ForeColor = System.Drawing.Color.White;
            this.gunaButton5.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton5.Image")));
            this.gunaButton5.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton5.Location = new System.Drawing.Point(998, 2);
            this.gunaButton5.Name = "gunaButton5";
            this.gunaButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
            this.gunaButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton5.OnHoverImage = null;
            this.gunaButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton5.Radius = 9;
            this.gunaButton5.Size = new System.Drawing.Size(31, 26);
            this.gunaButton5.TabIndex = 19;
            this.gunaButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton5.Click += new System.EventHandler(this.gunaButton5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 10);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar Convenios";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(-347, 41);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(630, 430);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 3;
            this.gunaPictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(307, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Convenio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(562, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dias:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(307, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor:";
            // 
            // txt_tipo_convenio
            // 
            this.txt_tipo_convenio.BackColor = System.Drawing.Color.Transparent;
            this.txt_tipo_convenio.BaseColor = System.Drawing.Color.White;
            this.txt_tipo_convenio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.txt_tipo_convenio.BorderSize = 1;
            this.txt_tipo_convenio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tipo_convenio.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_tipo_convenio.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_tipo_convenio.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_tipo_convenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txt_tipo_convenio.Location = new System.Drawing.Point(418, 69);
            this.txt_tipo_convenio.Name = "txt_tipo_convenio";
            this.txt_tipo_convenio.PasswordChar = '\0';
            this.txt_tipo_convenio.Radius = 9;
            this.txt_tipo_convenio.SelectedText = "";
            this.txt_tipo_convenio.Size = new System.Drawing.Size(332, 30);
            this.txt_tipo_convenio.TabIndex = 1;
            // 
            // txt_convenio_dias
            // 
            this.txt_convenio_dias.BackColor = System.Drawing.Color.Transparent;
            this.txt_convenio_dias.BaseColor = System.Drawing.Color.White;
            this.txt_convenio_dias.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.txt_convenio_dias.BorderSize = 1;
            this.txt_convenio_dias.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_convenio_dias.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_convenio_dias.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_convenio_dias.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_convenio_dias.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_convenio_dias.ForeColor = System.Drawing.Color.Red;
            this.txt_convenio_dias.Location = new System.Drawing.Point(624, 105);
            this.txt_convenio_dias.MaxLength = 3;
            this.txt_convenio_dias.Name = "txt_convenio_dias";
            this.txt_convenio_dias.PasswordChar = '\0';
            this.txt_convenio_dias.Radius = 9;
            this.txt_convenio_dias.SelectedText = "";
            this.txt_convenio_dias.Size = new System.Drawing.Size(113, 32);
            this.txt_convenio_dias.TabIndex = 3;
            this.txt_convenio_dias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_convenio_valor
            // 
            this.txt_convenio_valor.BackColor = System.Drawing.Color.Transparent;
            this.txt_convenio_valor.BaseColor = System.Drawing.Color.White;
            this.txt_convenio_valor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.txt_convenio_valor.BorderSize = 1;
            this.txt_convenio_valor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_convenio_valor.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_convenio_valor.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_convenio_valor.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_convenio_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txt_convenio_valor.Location = new System.Drawing.Point(379, 105);
            this.txt_convenio_valor.MaxLength = 100000;
            this.txt_convenio_valor.Name = "txt_convenio_valor";
            this.txt_convenio_valor.PasswordChar = '\0';
            this.txt_convenio_valor.Radius = 9;
            this.txt_convenio_valor.SelectedText = "";
            this.txt_convenio_valor.Size = new System.Drawing.Size(151, 30);
            this.txt_convenio_valor.TabIndex = 2;
            // 
            // btn_convenio_Save
            // 
            this.btn_convenio_Save.AnimationHoverSpeed = 0.07F;
            this.btn_convenio_Save.AnimationSpeed = 0.03F;
            this.btn_convenio_Save.BackColor = System.Drawing.Color.Transparent;
            this.btn_convenio_Save.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_convenio_Save.BorderColor = System.Drawing.Color.Black;
            this.btn_convenio_Save.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_convenio_Save.FocusedColor = System.Drawing.Color.Empty;
            this.btn_convenio_Save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_convenio_Save.ForeColor = System.Drawing.Color.White;
            this.btn_convenio_Save.Image = null;
            this.btn_convenio_Save.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_convenio_Save.Location = new System.Drawing.Point(300, 425);
            this.btn_convenio_Save.Name = "btn_convenio_Save";
            this.btn_convenio_Save.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btn_convenio_Save.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_convenio_Save.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_convenio_Save.OnHoverImage = null;
            this.btn_convenio_Save.OnPressedColor = System.Drawing.Color.Black;
            this.btn_convenio_Save.Radius = 9;
            this.btn_convenio_Save.Size = new System.Drawing.Size(131, 32);
            this.btn_convenio_Save.TabIndex = 15;
            this.btn_convenio_Save.Text = "Guardar";
            this.btn_convenio_Save.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_convenio_Save.Click += new System.EventHandler(this.btn_convenio_Save_Click);
            // 
            // btn_convenio_Modificar
            // 
            this.btn_convenio_Modificar.AnimationHoverSpeed = 0.07F;
            this.btn_convenio_Modificar.AnimationSpeed = 0.03F;
            this.btn_convenio_Modificar.BackColor = System.Drawing.Color.Transparent;
            this.btn_convenio_Modificar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_convenio_Modificar.BorderColor = System.Drawing.Color.Black;
            this.btn_convenio_Modificar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_convenio_Modificar.FocusedColor = System.Drawing.Color.Empty;
            this.btn_convenio_Modificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_convenio_Modificar.ForeColor = System.Drawing.Color.White;
            this.btn_convenio_Modificar.Image = null;
            this.btn_convenio_Modificar.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_convenio_Modificar.Location = new System.Drawing.Point(437, 425);
            this.btn_convenio_Modificar.Name = "btn_convenio_Modificar";
            this.btn_convenio_Modificar.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btn_convenio_Modificar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_convenio_Modificar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_convenio_Modificar.OnHoverImage = null;
            this.btn_convenio_Modificar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_convenio_Modificar.Radius = 9;
            this.btn_convenio_Modificar.Size = new System.Drawing.Size(131, 32);
            this.btn_convenio_Modificar.TabIndex = 16;
            this.btn_convenio_Modificar.Text = "Modificar";
            this.btn_convenio_Modificar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_convenio_Modificar.Click += new System.EventHandler(this.btn_convenio_Modificar_Click);
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
            this.btn_delete.Location = new System.Drawing.Point(577, 425);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btn_delete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_delete.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_delete.OnHoverImage = null;
            this.btn_delete.OnPressedColor = System.Drawing.Color.Black;
            this.btn_delete.Radius = 9;
            this.btn_delete.Size = new System.Drawing.Size(126, 32);
            this.btn_delete.TabIndex = 18;
            this.btn_delete.Text = "Eliminar";
            this.btn_delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // adgvconv
            // 
            this.adgvconv.AllowUserToAddRows = false;
            this.adgvconv.AutoGenerateContextFilters = true;
            this.adgvconv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adgvconv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adgvconv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.adgvconv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvconv.DateWithTime = false;
            this.adgvconv.EnableHeadersVisualStyles = false;
            this.adgvconv.Location = new System.Drawing.Point(300, 157);
            this.adgvconv.Name = "adgvconv";
            this.adgvconv.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adgvconv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.adgvconv.Size = new System.Drawing.Size(688, 258);
            this.adgvconv.TabIndex = 19;
            this.adgvconv.TimeFilter = false;
            this.adgvconv.SortStringChanged += new System.EventHandler(this.dgv_sort);
            this.adgvconv.FilterStringChanged += new System.EventHandler(this.dgv_filters);
            this.adgvconv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.advancedDataGridView1_CellValueChanged);
            this.adgvconv.Click += new System.EventHandler(this.advancedDataGridView1_Click);
            // 
            // Convenios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(998, 473);
            this.Controls.Add(this.adgvconv);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_convenio_Modificar);
            this.Controls.Add(this.btn_convenio_Save);
            this.Controls.Add(this.txt_convenio_valor);
            this.Controls.Add(this.txt_convenio_dias);
            this.Controls.Add(this.txt_tipo_convenio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Convenios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convenios";
            this.gunaGradientPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adgvconv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsconv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private Guna.UI.WinForms.GunaButton gunaButton5;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txt_tipo_convenio;
        private Guna.UI.WinForms.GunaTextBox txt_convenio_dias;
        private Guna.UI.WinForms.GunaTextBox txt_convenio_valor;
        private Guna.UI.WinForms.GunaButton btn_convenio_Save;
        private Guna.UI.WinForms.GunaButton btn_convenio_Modificar;
        private Guna.UI.WinForms.GunaButton btn_delete;
        private ADGV.AdvancedDataGridView adgvconv;
        private System.Windows.Forms.BindingSource bsconv;
    }
}