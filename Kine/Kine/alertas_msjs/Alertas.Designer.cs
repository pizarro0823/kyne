namespace Kine.alertas_msjs
{
    partial class Alertas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alertas));
            this.label1 = new System.Windows.Forms.Label();
            this.btnacep = new Guna.UI.WinForms.GunaButton();
            this.btncancelar = new Guna.UI.WinForms.GunaButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.panel1.SuspendLayout();
            this.gunaGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(875, 231);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tu convenio a caducado,\r\nrecuerda que debes pagar\r\nnuevamente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnacep
            // 
            this.btnacep.AnimationHoverSpeed = 0.07F;
            this.btnacep.AnimationSpeed = 0.03F;
            this.btnacep.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnacep.BorderColor = System.Drawing.Color.Black;
            this.btnacep.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnacep.FocusedColor = System.Drawing.Color.Empty;
            this.btnacep.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnacep.ForeColor = System.Drawing.Color.White;
            this.btnacep.Image = null;
            this.btnacep.ImageSize = new System.Drawing.Size(20, 20);
            this.btnacep.Location = new System.Drawing.Point(248, 289);
            this.btnacep.Name = "btnacep";
            this.btnacep.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnacep.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnacep.OnHoverForeColor = System.Drawing.Color.White;
            this.btnacep.OnHoverImage = null;
            this.btnacep.OnPressedColor = System.Drawing.Color.Black;
            this.btnacep.Size = new System.Drawing.Size(163, 34);
            this.btnacep.TabIndex = 18;
            this.btnacep.Text = "Aceptar";
            this.btnacep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnacep.Click += new System.EventHandler(this.btnacep_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.AnimationHoverSpeed = 0.07F;
            this.btncancelar.AnimationSpeed = 0.03F;
            this.btncancelar.BaseColor = System.Drawing.Color.Red;
            this.btncancelar.BorderColor = System.Drawing.Color.Black;
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btncancelar.FocusedColor = System.Drawing.Color.Empty;
            this.btncancelar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Image = null;
            this.btncancelar.ImageSize = new System.Drawing.Size(20, 20);
            this.btncancelar.Location = new System.Drawing.Point(456, 289);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btncancelar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btncancelar.OnHoverForeColor = System.Drawing.Color.White;
            this.btncancelar.OnHoverImage = null;
            this.btncancelar.OnPressedColor = System.Drawing.Color.Black;
            this.btncancelar.Size = new System.Drawing.Size(163, 34);
            this.btncancelar.TabIndex = 20;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btncancelar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnacep);
            this.panel1.Location = new System.Drawing.Point(3, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 337);
            this.panel1.TabIndex = 21;
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblmensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblmensaje.ForeColor = System.Drawing.Color.Black;
            this.lblmensaje.Location = new System.Drawing.Point(20, 1);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(179, 24);
            this.lblmensaje.TabIndex = 17;
            this.lblmensaje.Text = "Convenio vencido";
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.lblmensaje);
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
            this.gunaGradientPanel1.Location = new System.Drawing.Point(-1, 0);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(925, 30);
            this.gunaGradientPanel1.TabIndex = 1;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            this.gunaGradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gen_MouseMove);
            // 
            // Alertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(911, 369);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alertas";
            this.Text = "Alertas";
            this.Load += new System.EventHandler(this.Alertas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gunaGradientPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnacep;
        private Guna.UI.WinForms.GunaButton btncancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblmensaje;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
    }
}