
using CLIESC.ec.edu.monster.controlador;
using CLIESC.ec.edu.monster.vista;

namespace CLIESC.ec.edu.monster.vista
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            txtUs = new TextBox();
            txtPass = new TextBox();
            btnLogIn = new Button();
            lblError = new Label();
            SuspendLayout();
            // 
            // txtUs
            // 
            txtUs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUs.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUs.Location = new Point(62, 174);
            txtUs.Name = "txtUs";
            txtUs.Size = new Size(182, 29);
            txtUs.TabIndex = 0;
            txtUs.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPass
            // 
            txtPass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(62, 243);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(182, 29);
            txtPass.TabIndex = 1;
            txtPass.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLogIn
            // 
            btnLogIn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogIn.BackColor = Color.DarkGoldenrod;
            btnLogIn.BackgroundImageLayout = ImageLayout.None;
            btnLogIn.FlatStyle = FlatStyle.Popup;
            btnLogIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Location = new Point(88, 343);
            btnLogIn.Margin = new Padding(0);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(131, 49);
            btnLogIn.TabIndex = 2;
            btnLogIn.Text = "Iniciar Sesión";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblError.AutoSize = true;
            lblError.BackColor = Color.Black;
            lblError.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.FromArgb(192, 0, 0);
            lblError.Location = new Point(49, 305);
            lblError.Name = "lblError";
            lblError.Size = new Size(208, 17);
            lblError.TabIndex = 3;
            lblError.Text = "Las credenciales son incorrectas.";
            lblError.Visible = false;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(315, 450);
            Controls.Add(lblError);
            Controls.Add(btnLogIn);
            Controls.Add(txtPass);
            Controls.Add(txtUs);
            Name = "LogIn";
            Text = "SOAP .NET";
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LoginControlador controlador = new LoginControlador();
            string us = txtUs.Text,ps = txtPass.Text;
            bool res = controlador.verificar(us,ps);

            if (res)
            {
                this.Hide();
                new CliEsc().ShowDialog();
            }
            else
            {
                lblError.Visible = true;
            }
        }

        #endregion

        private TextBox txtUs;
        private TextBox txtPass;
        private Button btnLogIn;
        private Label lblError;
    }
}
