﻿namespace AppCliente
{
    partial class FormPrincipal
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
            button_cliente_login = new Button();
            textBox_cliente_id_login = new TextBox();
            groupBox_login = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            comboBox_lista_restaurantes = new ComboBox();
            label1 = new Label();
            dataGridView3 = new DataGridView();
            dataGridView4 = new DataGridView();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            button_hacer_pedido = new Button();
            label_cliente = new Label();
            label2 = new Label();
            button_cliente_logout = new Button();
            groupBox_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button_cliente_login
            // 
            button_cliente_login.Location = new Point(261, 32);
            button_cliente_login.Name = "button_cliente_login";
            button_cliente_login.Size = new Size(230, 54);
            button_cliente_login.TabIndex = 0;
            button_cliente_login.Text = "Ingresar";
            button_cliente_login.UseVisualStyleBackColor = true;
            button_cliente_login.Click += button_cliente_login_Click;
            // 
            // textBox_cliente_id_login
            // 
            textBox_cliente_id_login.Location = new Point(6, 55);
            textBox_cliente_id_login.Name = "textBox_cliente_id_login";
            textBox_cliente_id_login.Size = new Size(230, 31);
            textBox_cliente_id_login.TabIndex = 2;
            // 
            // groupBox_login
            // 
            groupBox_login.Controls.Add(label8);
            groupBox_login.Controls.Add(label7);
            groupBox_login.Controls.Add(button2);
            groupBox_login.Controls.Add(button1);
            groupBox_login.Controls.Add(label6);
            groupBox_login.Controls.Add(label5);
            groupBox_login.Controls.Add(label4);
            groupBox_login.Controls.Add(label3);
            groupBox_login.Controls.Add(comboBox_lista_restaurantes);
            groupBox_login.Controls.Add(label1);
            groupBox_login.Controls.Add(dataGridView3);
            groupBox_login.Controls.Add(dataGridView4);
            groupBox_login.Controls.Add(dataGridView2);
            groupBox_login.Controls.Add(dataGridView1);
            groupBox_login.Controls.Add(button_hacer_pedido);
            groupBox_login.Controls.Add(label_cliente);
            groupBox_login.Controls.Add(label2);
            groupBox_login.Controls.Add(button_cliente_logout);
            groupBox_login.Controls.Add(button_cliente_login);
            groupBox_login.Controls.Add(textBox_cliente_id_login);
            groupBox_login.Location = new Point(12, 12);
            groupBox_login.Name = "groupBox_login";
            groupBox_login.Size = new Size(1394, 880);
            groupBox_login.TabIndex = 3;
            groupBox_login.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(714, 730);
            label8.Name = "label8";
            label8.Size = new Size(31, 25);
            label8.TabIndex = 21;
            label8.Text = "->";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(719, 401);
            label7.Name = "label7";
            label7.Size = new Size(31, 25);
            label7.TabIndex = 20;
            label7.Text = "->";
            // 
            // button2
            // 
            button2.Location = new Point(587, 618);
            button2.Name = "button2";
            button2.Size = new Size(126, 249);
            button2.TabIndex = 19;
            button2.Text = "Elegir Extras";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(587, 289);
            button1.Name = "button1";
            button1.Size = new Size(126, 249);
            button1.TabIndex = 18;
            button1.Text = "Elegir Platos";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(750, 590);
            label6.Name = "label6";
            label6.Size = new Size(128, 25);
            label6.TabIndex = 15;
            label6.Text = "Extras Elegidas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(750, 261);
            label5.Name = "label5";
            label5.Size = new Size(132, 25);
            label5.TabIndex = 14;
            label5.Text = "Platos Elegidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 590);
            label4.Name = "label4";
            label4.Size = new Size(349, 25);
            label4.TabIndex = 13;
            label4.Text = "Extras Disponibles para los Platos Elegidos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 160);
            label3.Name = "label3";
            label3.Size = new Size(164, 25);
            label3.TabIndex = 12;
            label3.Text = "Elija un Restaurante";
            // 
            // comboBox_lista_restaurantes
            // 
            comboBox_lista_restaurantes.FormattingEnabled = true;
            comboBox_lista_restaurantes.Location = new Point(6, 188);
            comboBox_lista_restaurantes.Name = "comboBox_lista_restaurantes";
            comboBox_lista_restaurantes.Size = new Size(575, 33);
            comboBox_lista_restaurantes.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 261);
            label1.Name = "label1";
            label1.Size = new Size(186, 25);
            label1.TabIndex = 10;
            label1.Text = "Platos del Restaurante";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(750, 289);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.RowTemplate.Height = 33;
            dataGridView3.Size = new Size(638, 249);
            dataGridView3.TabIndex = 9;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(6, 289);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 62;
            dataGridView4.RowTemplate.Height = 33;
            dataGridView4.Size = new Size(575, 249);
            dataGridView4.TabIndex = 8;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(750, 618);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(638, 256);
            dataGridView2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 618);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(575, 256);
            dataGridView1.TabIndex = 6;
            // 
            // button_hacer_pedido
            // 
            button_hacer_pedido.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button_hacer_pedido.Location = new Point(1167, 27);
            button_hacer_pedido.Name = "button_hacer_pedido";
            button_hacer_pedido.Size = new Size(221, 158);
            button_hacer_pedido.TabIndex = 5;
            button_hacer_pedido.Text = "Hacer Pedido";
            button_hacer_pedido.UseVisualStyleBackColor = true;
            // 
            // label_cliente
            // 
            label_cliente.AutoSize = true;
            label_cliente.Location = new Point(6, 100);
            label_cliente.Name = "label_cliente";
            label_cliente.Size = new Size(74, 25);
            label_cliente.TabIndex = 0;
            label_cliente.Text = "Cliente: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 27);
            label2.Name = "label2";
            label2.Size = new Size(196, 25);
            label2.TabIndex = 2;
            label2.Text = "Ingrese su ID de cliente";
            // 
            // button_cliente_logout
            // 
            button_cliente_logout.Location = new Point(515, 33);
            button_cliente_logout.Name = "button_cliente_logout";
            button_cliente_logout.Size = new Size(230, 53);
            button_cliente_logout.TabIndex = 4;
            button_cliente_logout.Text = "Cerrar Sesión";
            button_cliente_logout.UseVisualStyleBackColor = true;
            button_cliente_logout.Click += button_cliente_logout_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1418, 904);
            Controls.Add(groupBox_login);
            Name = "FormPrincipal";
            Text = "RESTUNED Pedidos";
            groupBox_login.ResumeLayout(false);
            groupBox_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button_cliente_login;
        private TextBox textBox_cliente_id_login;
        private GroupBox groupBox_login;
        private Label label2;
        private Button button_cliente_logout;
        private Label label_cliente;
        private Button button_hacer_pedido;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Label label3;
        private ComboBox comboBox_lista_restaurantes;
        private Label label1;
        private DataGridView dataGridView3;
        private DataGridView dataGridView4;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private Label label8;
        private Label label7;
    }
}