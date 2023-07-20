namespace AppServer.Forms
{
    partial class FormRegistrarCategPlato
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
            textBox_reg_cat_descripcion = new TextBox();
            checkBox_reg_cat_activa = new CheckBox();
            button_reg_cat_plato = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 18);
            label1.Name = "label1";
            label1.Size = new Size(240, 25);
            label1.TabIndex = 0;
            label1.Text = "Resgistrar Categoría de Plato";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 81);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 1;
            label2.Text = "Descripción";
            // 
            // textBox_reg_cat_descripcion
            // 
            textBox_reg_cat_descripcion.Location = new Point(15, 124);
            textBox_reg_cat_descripcion.Name = "textBox_reg_cat_descripcion";
            textBox_reg_cat_descripcion.Size = new Size(491, 31);
            textBox_reg_cat_descripcion.TabIndex = 2;
            // 
            // checkBox_reg_cat_activa
            // 
            checkBox_reg_cat_activa.AutoSize = true;
            checkBox_reg_cat_activa.Location = new Point(15, 191);
            checkBox_reg_cat_activa.Name = "checkBox_reg_cat_activa";
            checkBox_reg_cat_activa.Size = new Size(233, 29);
            checkBox_reg_cat_activa.TabIndex = 3;
            checkBox_reg_cat_activa.Text = "¿Es una categoría activa?";
            checkBox_reg_cat_activa.UseVisualStyleBackColor = true;
            // 
            // button_reg_cat_plato
            // 
            button_reg_cat_plato.Location = new Point(15, 282);
            button_reg_cat_plato.Name = "button_reg_cat_plato";
            button_reg_cat_plato.Size = new Size(491, 56);
            button_reg_cat_plato.TabIndex = 4;
            button_reg_cat_plato.Text = "Registrar Categoría de Plato";
            button_reg_cat_plato.UseVisualStyleBackColor = true;
            button_reg_cat_plato.Click += button_reg_cat_plato_Click;
            // 
            // FormRegistrarCategPlato
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 904);
            Controls.Add(button_reg_cat_plato);
            Controls.Add(checkBox_reg_cat_activa);
            Controls.Add(textBox_reg_cat_descripcion);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormRegistrarCategPlato";
            Text = "Registrar Categoría de Plato";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox_reg_cat_descripcion;
        private CheckBox checkBox_reg_cat_activa;
        private Button button_reg_cat_plato;
    }
}