namespace AppServidor.Forms
{
    partial class FormRegistrarPlato
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
            textBox_reg_plato_nombre = new TextBox();
            textBox_reg_plato_precio = new TextBox();
            label3 = new Label();
            textBox_reg_plato_idCateg = new TextBox();
            label4 = new Label();
            button_reg_plato = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 13);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 0;
            label1.Text = "Registrar Plato";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 62);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // textBox_reg_plato_nombre
            // 
            textBox_reg_plato_nombre.Location = new Point(16, 99);
            textBox_reg_plato_nombre.Name = "textBox_reg_plato_nombre";
            textBox_reg_plato_nombre.Size = new Size(490, 31);
            textBox_reg_plato_nombre.TabIndex = 2;
            // 
            // textBox_reg_plato_precio
            // 
            textBox_reg_plato_precio.Location = new Point(16, 206);
            textBox_reg_plato_precio.Name = "textBox_reg_plato_precio";
            textBox_reg_plato_precio.Size = new Size(490, 31);
            textBox_reg_plato_precio.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 169);
            label3.Name = "label3";
            label3.Size = new Size(135, 25);
            label3.TabIndex = 3;
            label3.Text = "Precio del plato";
            // 
            // textBox_reg_plato_idCateg
            // 
            textBox_reg_plato_idCateg.Location = new Point(16, 320);
            textBox_reg_plato_idCateg.Name = "textBox_reg_plato_idCateg";
            textBox_reg_plato_idCateg.Size = new Size(490, 31);
            textBox_reg_plato_idCateg.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 283);
            label4.Name = "label4";
            label4.Size = new Size(300, 25);
            label4.TabIndex = 5;
            label4.Text = "ID de la categoría a la que pertenece";
            // 
            // button_reg_plato
            // 
            button_reg_plato.Location = new Point(16, 424);
            button_reg_plato.Name = "button_reg_plato";
            button_reg_plato.Size = new Size(490, 57);
            button_reg_plato.TabIndex = 7;
            button_reg_plato.Text = "Registrar Plato";
            button_reg_plato.UseVisualStyleBackColor = true;
            button_reg_plato.Click += button_reg_plato_Click;
            // 
            // FormRegistrarPlato
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 904);
            Controls.Add(button_reg_plato);
            Controls.Add(textBox_reg_plato_idCateg);
            Controls.Add(label4);
            Controls.Add(textBox_reg_plato_precio);
            Controls.Add(label3);
            Controls.Add(textBox_reg_plato_nombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormRegistrarPlato";
            Text = "Registrar Plato";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox_reg_plato_nombre;
        private TextBox textBox_reg_plato_precio;
        private Label label3;
        private TextBox textBox_reg_plato_idCateg;
        private Label label4;
        private Button button_reg_plato;
    }
}