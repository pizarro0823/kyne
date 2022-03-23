namespace Kine.Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txt_pass = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ingresar = new Guna.UI.WinForms.GunaButton();
            this.btncerrar = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.Transparent;
            this.txt_pass.BaseColor = System.Drawing.Color.White;
            this.txt_pass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txt_pass.BorderSize = 1;
            this.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_pass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_pass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.Color.Red;
            this.txt_pass.Location = new System.Drawing.Point(36, 117);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Radius = 9;
            this.txt_pass.SelectedText = "";
            this.txt_pass.Size = new System.Drawing.Size(229, 37);
            this.txt_pass.TabIndex = 0;
            this.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(36, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Requiere Autenticacion";
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.AnimationHoverSpeed = 0.07F;
            this.btn_ingresar.AnimationSpeed = 0.03F;
            this.btn_ingresar.BackColor = System.Drawing.Color.Transparent;
            this.btn_ingresar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_ingresar.BorderColor = System.Drawing.Color.Black;
            this.btn_ingresar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_ingresar.FocusedColor = System.Drawing.Color.Empty;
            this.btn_ingresar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.ForeColor = System.Drawing.Color.White;
            this.btn_ingresar.Image = null;
            this.btn_ingresar.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_ingresar.Location = new System.Drawing.Point(71, 200);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_ingresar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_ingresar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_ingresar.OnHoverImage = null;
            this.btn_ingresar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_ingresar.Radius = 9;
            this.btn_ingresar.Size = new System.Drawing.Size(160, 42);
            this.btn_ingresar.TabIndex = 2;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btncerrar
            // 
            this.btncerrar.AnimationHoverSpeed = 0.07F;
            this.btncerrar.AnimationSpeed = 0.03F;
            this.btncerrar.BackColor = System.Drawing.Color.Transparent;
            this.btncerrar.BaseColor = System.Drawing.Color.Transparent;
            this.btncerrar.BorderColor = System.Drawing.Color.Black;
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btncerrar.FocusedColor = System.Drawing.Color.Empty;
            this.btncerrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.ForeColor = System.Drawing.Color.White;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btncerrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btncerrar.Location = new System.Drawing.Point(278, 1);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
            this.btncerrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btncerrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btncerrar.OnHoverImage = null;
            this.btncerrar.OnPressedColor = System.Drawing.Color.Black;
            this.btncerrar.Radius = 9;
            this.btncerrar.Size = new System.Drawing.Size(24, 26);
            this.btncerrar.TabIndex = 23;
            this.btncerrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 266);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.95D;
            this.Text = "v";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox txt_pass;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btn_ingresar;
        private Guna.UI.WinForms.GunaButton btncerrar;
    }
}