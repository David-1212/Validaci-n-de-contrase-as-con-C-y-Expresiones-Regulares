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
            lblcontraseña = new Label();
            lblcontraseña2 = new Label();
            txtcontrasena1 = new TextBox();
            txtcontrasena2 = new TextBox();
            btnvalidar = new Button();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // lblcontraseña
            // 
            lblcontraseña.AutoSize = true;
            lblcontraseña.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcontraseña.Location = new Point(226, 90);
            lblcontraseña.Name = "lblcontraseña";
            lblcontraseña.Size = new Size(89, 21);
            lblcontraseña.TabIndex = 1;
            lblcontraseña.Text = "Contraseña";
            // 
            // lblcontraseña2
            // 
            lblcontraseña2.AutoSize = true;
            lblcontraseña2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcontraseña2.Location = new Point(226, 146);
            lblcontraseña2.Name = "lblcontraseña2";
            lblcontraseña2.Size = new Size(60, 21);
            lblcontraseña2.TabIndex = 2;
            lblcontraseña2.Text = "Repetir";
            // 
            // txtcontrasena1
            // 
            txtcontrasena1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcontrasena1.Location = new Point(318, 91);
            txtcontrasena1.Name = "txtcontrasena1";
            txtcontrasena1.Size = new Size(254, 29);
            txtcontrasena1.TabIndex = 3;
            // 
            // txtcontrasena2
            // 
            txtcontrasena2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcontrasena2.Location = new Point(318, 143);
            txtcontrasena2.Name = "txtcontrasena2";
            txtcontrasena2.Size = new Size(254, 29);
            txtcontrasena2.TabIndex = 4;
            // 
            // btnvalidar
            // 
            btnvalidar.BackColor = SystemColors.InactiveCaption;
            btnvalidar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnvalidar.ForeColor = SystemColors.ActiveCaptionText;
            btnvalidar.Location = new Point(390, 198);
            btnvalidar.Name = "btnvalidar";
            btnvalidar.Size = new Size(84, 30);
            btnvalidar.TabIndex = 5;
            btnvalidar.Text = "VALIDAR";
            btnvalidar.UseVisualStyleBackColor = false;
            btnvalidar.Click += btnvalidar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(49, 90);
            label2.Name = "label2";
            label2.Size = new Size(172, 147);
            label2.TabIndex = 6;
            label2.Text = "La contraseña debe\r\n incluir al menos:\r\n- Una letra mayúscula \r\n- Una letra minúscula \r\n- Un dígito \r\n- Un carácter especial \r\n(@, #, $, %, !, ?, *)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(327, 44);
            label4.Name = "label4";
            label4.Size = new Size(236, 25);
            label4.TabIndex = 8;
            label4.Text = "Validador de contraseñas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnvalidar);
            Controls.Add(txtcontrasena2);
            Controls.Add(txtcontrasena1);
            Controls.Add(lblcontraseña2);
            Controls.Add(lblcontraseña);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblcontraseña;
        private Label lblcontraseña2;
        private TextBox txtcontrasena1;
        private TextBox txtcontrasena2;
        private Button btnvalidar;
        private Label label2;
        private Label label4;
    }
}
