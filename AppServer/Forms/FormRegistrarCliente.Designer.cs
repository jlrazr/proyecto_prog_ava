namespace AppServer.Forms
{
    partial class FormRegistrarCliente
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
            textBox_reg_cliente_nombre = new TextBox();
            textBox_reg_cliente_apellido1 = new TextBox();
            label3 = new Label();
            textBox_reg_cliente_apellido2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker_reg_cliente_dob = new DateTimePicker();
            radioButton_reg_cliente_m = new RadioButton();
            label6 = new Label();
            radioButton_reg_cliente_f = new RadioButton();
            button_reg_cliente = new Button();
            panel_reg_cliente_radio_contenedor = new Panel();
            button_connect = new Button();
            panel_reg_cliente_radio_contenedor.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 15);
            label1.Name = "label1";
            label1.Size = new Size(139, 25);
            label1.TabIndex = 0;
            label1.Text = "Registrar Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 73);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // textBox_reg_cliente_nombre
            // 
            textBox_reg_cliente_nombre.Location = new Point(13, 112);
            textBox_reg_cliente_nombre.Name = "textBox_reg_cliente_nombre";
            textBox_reg_cliente_nombre.Size = new Size(493, 31);
            textBox_reg_cliente_nombre.TabIndex = 2;
            // 
            // textBox_reg_cliente_apellido1
            // 
            textBox_reg_cliente_apellido1.Location = new Point(13, 214);
            textBox_reg_cliente_apellido1.Name = "textBox_reg_cliente_apellido1";
            textBox_reg_cliente_apellido1.Size = new Size(493, 31);
            textBox_reg_cliente_apellido1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 175);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 3;
            label3.Text = "Primer Apellido";
            // 
            // textBox_reg_cliente_apellido2
            // 
            textBox_reg_cliente_apellido2.Location = new Point(13, 325);
            textBox_reg_cliente_apellido2.Name = "textBox_reg_cliente_apellido2";
            textBox_reg_cliente_apellido2.Size = new Size(493, 31);
            textBox_reg_cliente_apellido2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 286);
            label4.Name = "label4";
            label4.Size = new Size(155, 25);
            label4.TabIndex = 5;
            label4.Text = "Segundo Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 395);
            label5.Name = "label5";
            label5.Size = new Size(177, 25);
            label5.TabIndex = 7;
            label5.Text = "Fecha de Nacimiento";
            // 
            // dateTimePicker_reg_cliente_dob
            // 
            dateTimePicker_reg_cliente_dob.Location = new Point(13, 440);
            dateTimePicker_reg_cliente_dob.Name = "dateTimePicker_reg_cliente_dob";
            dateTimePicker_reg_cliente_dob.Size = new Size(493, 31);
            dateTimePicker_reg_cliente_dob.TabIndex = 8;
            // 
            // radioButton_reg_cliente_m
            // 
            radioButton_reg_cliente_m.AutoSize = true;
            radioButton_reg_cliente_m.Location = new Point(12, 14);
            radioButton_reg_cliente_m.Name = "radioButton_reg_cliente_m";
            radioButton_reg_cliente_m.Size = new Size(117, 29);
            radioButton_reg_cliente_m.TabIndex = 9;
            radioButton_reg_cliente_m.TabStop = true;
            radioButton_reg_cliente_m.Text = "Masculino";
            radioButton_reg_cliente_m.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 509);
            label6.Name = "label6";
            label6.Size = new Size(69, 25);
            label6.TabIndex = 10;
            label6.Text = "Género";
            // 
            // radioButton_reg_cliente_f
            // 
            radioButton_reg_cliente_f.AutoSize = true;
            radioButton_reg_cliente_f.Location = new Point(12, 66);
            radioButton_reg_cliente_f.Name = "radioButton_reg_cliente_f";
            radioButton_reg_cliente_f.Size = new Size(115, 29);
            radioButton_reg_cliente_f.TabIndex = 11;
            radioButton_reg_cliente_f.TabStop = true;
            radioButton_reg_cliente_f.Text = "Femenino";
            radioButton_reg_cliente_f.UseVisualStyleBackColor = true;
            // 
            // button_reg_cliente
            // 
            button_reg_cliente.Location = new Point(12, 677);
            button_reg_cliente.Name = "button_reg_cliente";
            button_reg_cliente.Size = new Size(494, 58);
            button_reg_cliente.TabIndex = 12;
            button_reg_cliente.Text = "Registrar Cliente";
            button_reg_cliente.UseVisualStyleBackColor = true;
            button_reg_cliente.Click += button_reg_cliente_Click;
            // 
            // panel_reg_cliente_radio_contenedor
            // 
            panel_reg_cliente_radio_contenedor.Controls.Add(radioButton_reg_cliente_m);
            panel_reg_cliente_radio_contenedor.Controls.Add(radioButton_reg_cliente_f);
            panel_reg_cliente_radio_contenedor.Location = new Point(13, 537);
            panel_reg_cliente_radio_contenedor.Name = "panel_reg_cliente_radio_contenedor";
            panel_reg_cliente_radio_contenedor.Size = new Size(401, 110);
            panel_reg_cliente_radio_contenedor.TabIndex = 13;
            // 
            // button_connect
            // 
            button_connect.Location = new Point(12, 767);
            button_connect.Name = "button_connect";
            button_connect.Size = new Size(494, 95);
            button_connect.TabIndex = 14;
            button_connect.Text = "Prueba Conexion";
            button_connect.UseVisualStyleBackColor = true;
            button_connect.Click += button_connect_Click;
            // 
            // FormRegistrarCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 904);
            Controls.Add(button_connect);
            Controls.Add(panel_reg_cliente_radio_contenedor);
            Controls.Add(button_reg_cliente);
            Controls.Add(label6);
            Controls.Add(dateTimePicker_reg_cliente_dob);
            Controls.Add(label5);
            Controls.Add(textBox_reg_cliente_apellido2);
            Controls.Add(label4);
            Controls.Add(textBox_reg_cliente_apellido1);
            Controls.Add(label3);
            Controls.Add(textBox_reg_cliente_nombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormRegistrarCliente";
            Text = "Registrar Cliente";
            panel_reg_cliente_radio_contenedor.ResumeLayout(false);
            panel_reg_cliente_radio_contenedor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox_reg_cliente_nombre;
        private TextBox textBox_reg_cliente_apellido1;
        private Label label3;
        private TextBox textBox_reg_cliente_apellido2;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker_reg_cliente_dob;
        private RadioButton radioButton_reg_cliente_m;
        private Label label6;
        private RadioButton radioButton_reg_cliente_f;
        private Button button_reg_cliente;
        private Panel panel_reg_cliente_radio_contenedor;
        private Button button_connect;
    }
}