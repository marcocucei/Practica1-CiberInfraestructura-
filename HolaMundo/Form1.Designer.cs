namespace HolaMundo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtContrasenaUno = new TextBox();
            txtContrasenaDos = new TextBox();
            btnValidar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtContrasenaUno
            // 
            txtContrasenaUno.BackColor = Color.Silver;
            txtContrasenaUno.Location = new Point(218, 45);
            txtContrasenaUno.Name = "txtContrasenaUno";
            txtContrasenaUno.Size = new Size(199, 23);
            txtContrasenaUno.TabIndex = 0;
            // 
            // txtContrasenaDos
            // 
            txtContrasenaDos.BackColor = Color.Silver;
            txtContrasenaDos.Location = new Point(218, 94);
            txtContrasenaDos.Name = "txtContrasenaDos";
            txtContrasenaDos.Size = new Size(199, 23);
            txtContrasenaDos.TabIndex = 1;
            // 
            // btnValidar
            // 
            btnValidar.BackColor = Color.DarkRed;
            btnValidar.Location = new Point(294, 146);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(125, 27);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = false;
            btnValidar.Click += btnValidar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkRed;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(36, 103);
            label3.Name = "label3";
            label3.Size = new Size(160, 18);
            label3.TabIndex = 3;
            label3.Text = "Repite tu contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkRed;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.ImageAlign = ContentAlignment.BottomLeft;
            label4.Location = new Point(29, 45);
            label4.Name = "label4";
            label4.Size = new Size(170, 18);
            label4.TabIndex = 4;
            label4.Text = "Ingresa tu contraseña";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(483, 198);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnValidar);
            Controls.Add(txtContrasenaDos);
            Controls.Add(txtContrasenaUno);
            Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Form1";
            Text = "Marco Hernandez";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContrasenaUno;
        private TextBox txtContrasenaDos;
        private Button btnValidar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}