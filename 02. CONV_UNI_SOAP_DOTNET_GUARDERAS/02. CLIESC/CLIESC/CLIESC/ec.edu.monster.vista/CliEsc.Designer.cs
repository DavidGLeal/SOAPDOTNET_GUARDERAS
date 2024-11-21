namespace CLIESC.ec.edu.monster.vista
{
    partial class CliEsc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CliEsc));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCel = new TextBox();
            txtFar = new TextBox();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(144, 12);
            label1.Name = "label1";
            label1.Size = new Size(280, 40);
            label1.TabIndex = 0;
            label1.Text = "Celsius ↔ Farenheit";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(71, 77);
            label2.Name = "label2";
            label2.Size = new Size(107, 30);
            label2.TabIndex = 1;
            label2.Text = "Celsius °C";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(383, 77);
            label3.Name = "label3";
            label3.Size = new Size(129, 30);
            label3.TabIndex = 2;
            label3.Text = "Farenheit °F";
            // 
            // txtCel
            // 
            txtCel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCel.Location = new Point(25, 124);
            txtCel.Multiline = true;
            txtCel.Name = "txtCel";
            txtCel.Size = new Size(194, 102);
            txtCel.TabIndex = 3;
            txtCel.TextAlign = HorizontalAlignment.Center;
            txtCel.TextChanged += txtCel_TextChanged;
            // 
            // txtFar
            // 
            txtFar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFar.Location = new Point(345, 124);
            txtFar.Multiline = true;
            txtFar.Name = "txtFar";
            txtFar.Size = new Size(194, 102);
            txtFar.TabIndex = 4;
            txtFar.TextAlign = HorizontalAlignment.Center;
            txtFar.TextChanged += txtFar_TextChanged;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Maroon;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(449, 274);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(90, 23);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar Sesión";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // CliEsc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(565, 309);
            Controls.Add(btnCerrar);
            Controls.Add(txtFar);
            Controls.Add(txtCel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CliEsc";
            Text = "CliEsc";
            FormClosing += CliEsc_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCel;
        private TextBox txtFar;
        private Button btnCerrar;
    }
}