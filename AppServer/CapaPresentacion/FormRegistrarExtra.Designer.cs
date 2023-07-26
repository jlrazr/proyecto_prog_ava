namespace AppServidor.Forms
{
    partial class FormRegistrarExtra
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
            label1 = new Label();
            label2 = new Label();
            textBox_reg_extra_desc = new TextBox();
            textBox_reg_extra_idCateg = new TextBox();
            label3 = new Label();
            textBox_reg_extra_precio = new TextBox();
            label5 = new Label();
            button_reg_extras = new Button();
            checkBox_reg_extra_activa = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 0;
            label1.Text = "Registrar Extras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 1;
            label2.Text = "Descripción";
            // 
            // textBox_reg_extra_desc
            // 
            textBox_reg_extra_desc.Location = new Point(12, 105);
            textBox_reg_extra_desc.Name = "textBox_reg_extra_desc";
            textBox_reg_extra_desc.Size = new Size(490, 31);
            textBox_reg_extra_desc.TabIndex = 2;
            // 
            // textBox_reg_extra_idCateg
            // 
            textBox_reg_extra_idCateg.Location = new Point(12, 200);
            textBox_reg_extra_idCateg.Name = "textBox_reg_extra_idCateg";
            textBox_reg_extra_idCateg.Size = new Size(490, 31);
            textBox_reg_extra_idCateg.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 172);
            label3.Name = "label3";
            label3.Size = new Size(303, 25);
            label3.TabIndex = 3;
            label3.Text = "ID de la Categoría a la que pertenece";
            // 
            // textBox_reg_extra_precio
            // 
            textBox_reg_extra_precio.Location = new Point(12, 378);
            textBox_reg_extra_precio.Name = "textBox_reg_extra_precio";
            textBox_reg_extra_precio.Size = new Size(490, 31);
            textBox_reg_extra_precio.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 350);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 7;
            label5.Text = "Precio";
            // 
            // button_reg_extras
            // 
            button_reg_extras.Location = new Point(12, 492);
            button_reg_extras.Name = "button_reg_extras";
            button_reg_extras.Size = new Size(490, 58);
            button_reg_extras.TabIndex = 9;
            button_reg_extras.Text = "Registrar Extras";
            button_reg_extras.UseVisualStyleBackColor = true;
            button_reg_extras.Click += button_reg_extras_Click;
            // 
            // checkBox_reg_extra_activa
            // 
            checkBox_reg_extra_activa.AutoSize = true;
            checkBox_reg_extra_activa.Location = new Point(12, 277);
            checkBox_reg_extra_activa.Name = "checkBox_reg_extra_activa";
            checkBox_reg_extra_activa.Size = new Size(198, 29);
            checkBox_reg_extra_activa.TabIndex = 10;
            checkBox_reg_extra_activa.Text = "¿Es una extra activa?";
            checkBox_reg_extra_activa.UseVisualStyleBackColor = true;
            // 
            // FormRegistrarExtra
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 904);
            Controls.Add(checkBox_reg_extra_activa);
            Controls.Add(button_reg_extras);
            Controls.Add(textBox_reg_extra_precio);
            Controls.Add(label5);
            Controls.Add(textBox_reg_extra_idCateg);
            Controls.Add(label3);
            Controls.Add(textBox_reg_extra_desc);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormRegistrarExtra";
            Text = "Registrar Extras";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox_reg_extra_desc;
        private TextBox textBox_reg_extra_idCateg;
        private Label label3;
        private TextBox textBox_reg_extra_precio;
        private Label label5;
        private Button button_reg_extras;
        private CheckBox checkBox_reg_extra_activa;
    }
}