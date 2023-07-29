namespace AppCliente
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
            label_precio_total = new Label();
            label8 = new Label();
            label7 = new Label();
            button_anadir_extras = new Button();
            button_anadir_platos = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            comboBox_lista_restaurantes = new ComboBox();
            label1 = new Label();
            dataGridView_platos_elegidos = new DataGridView();
            dataGridView_platos_disponibles = new DataGridView();
            dataGridView_extras_elegidas = new DataGridView();
            dataGridView_extras_disponibles = new DataGridView();
            button_hacer_pedido = new Button();
            label_cliente = new Label();
            label2 = new Label();
            button_cliente_logout = new Button();
            groupBox_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_platos_elegidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_platos_disponibles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_extras_elegidas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_extras_disponibles).BeginInit();
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
            groupBox_login.Controls.Add(label_precio_total);
            groupBox_login.Controls.Add(label8);
            groupBox_login.Controls.Add(label7);
            groupBox_login.Controls.Add(button_anadir_extras);
            groupBox_login.Controls.Add(button_anadir_platos);
            groupBox_login.Controls.Add(label6);
            groupBox_login.Controls.Add(label5);
            groupBox_login.Controls.Add(label4);
            groupBox_login.Controls.Add(label3);
            groupBox_login.Controls.Add(comboBox_lista_restaurantes);
            groupBox_login.Controls.Add(label1);
            groupBox_login.Controls.Add(dataGridView_platos_elegidos);
            groupBox_login.Controls.Add(dataGridView_platos_disponibles);
            groupBox_login.Controls.Add(dataGridView_extras_elegidas);
            groupBox_login.Controls.Add(dataGridView_extras_disponibles);
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
            // label_precio_total
            // 
            label_precio_total.AutoSize = true;
            label_precio_total.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label_precio_total.Location = new Point(976, 27);
            label_precio_total.Name = "label_precio_total";
            label_precio_total.Size = new Size(297, 30);
            label_precio_total.TabIndex = 22;
            label_precio_total.Text = "Costo del Pedido: 0 colones";
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
            // button_anadir_extras
            // 
            button_anadir_extras.Location = new Point(587, 618);
            button_anadir_extras.Name = "button_anadir_extras";
            button_anadir_extras.Size = new Size(126, 249);
            button_anadir_extras.TabIndex = 19;
            button_anadir_extras.Text = "Elegir Extras";
            button_anadir_extras.UseVisualStyleBackColor = true;
            button_anadir_extras.Click += button_anadir_extras_Click;
            // 
            // button_anadir_platos
            // 
            button_anadir_platos.Location = new Point(587, 289);
            button_anadir_platos.Name = "button_anadir_platos";
            button_anadir_platos.Size = new Size(126, 249);
            button_anadir_platos.TabIndex = 18;
            button_anadir_platos.Text = "Elegir Platos";
            button_anadir_platos.UseVisualStyleBackColor = true;
            button_anadir_platos.Click += button_anadir_platos_Click;
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
            comboBox_lista_restaurantes.SelectedIndexChanged += comboBox_lista_restaurantes_SelectedIndexChanged;
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
            // dataGridView_platos_elegidos
            // 
            dataGridView_platos_elegidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_platos_elegidos.Location = new Point(750, 289);
            dataGridView_platos_elegidos.Name = "dataGridView_platos_elegidos";
            dataGridView_platos_elegidos.RowHeadersWidth = 62;
            dataGridView_platos_elegidos.RowTemplate.Height = 33;
            dataGridView_platos_elegidos.Size = new Size(638, 249);
            dataGridView_platos_elegidos.TabIndex = 9;
            // 
            // dataGridView_platos_disponibles
            // 
            dataGridView_platos_disponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_platos_disponibles.Location = new Point(6, 289);
            dataGridView_platos_disponibles.Name = "dataGridView_platos_disponibles";
            dataGridView_platos_disponibles.RowHeadersWidth = 62;
            dataGridView_platos_disponibles.RowTemplate.Height = 33;
            dataGridView_platos_disponibles.Size = new Size(575, 249);
            dataGridView_platos_disponibles.TabIndex = 8;
            // 
            // dataGridView_extras_elegidas
            // 
            dataGridView_extras_elegidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_extras_elegidas.Location = new Point(750, 618);
            dataGridView_extras_elegidas.Name = "dataGridView_extras_elegidas";
            dataGridView_extras_elegidas.RowHeadersWidth = 62;
            dataGridView_extras_elegidas.RowTemplate.Height = 33;
            dataGridView_extras_elegidas.Size = new Size(638, 256);
            dataGridView_extras_elegidas.TabIndex = 7;
            // 
            // dataGridView_extras_disponibles
            // 
            dataGridView_extras_disponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_extras_disponibles.Location = new Point(6, 618);
            dataGridView_extras_disponibles.Name = "dataGridView_extras_disponibles";
            dataGridView_extras_disponibles.RowHeadersWidth = 62;
            dataGridView_extras_disponibles.RowTemplate.Height = 33;
            dataGridView_extras_disponibles.Size = new Size(575, 256);
            dataGridView_extras_disponibles.TabIndex = 6;
            // 
            // button_hacer_pedido
            // 
            button_hacer_pedido.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button_hacer_pedido.Location = new Point(1013, 73);
            button_hacer_pedido.Name = "button_hacer_pedido";
            button_hacer_pedido.Size = new Size(283, 112);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView_platos_elegidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_platos_disponibles).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_extras_elegidas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_extras_disponibles).EndInit();
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
        private DataGridView dataGridView_extras_elegidas;
        private DataGridView dataGridView_extras_disponibles;
        private Label label3;
        private ComboBox comboBox_lista_restaurantes;
        private Label label1;
        private DataGridView dataGridView_platos_elegidos;
        private DataGridView dataGridView_platos_disponibles;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button_anadir_platos;
        private Button button_anadir_extras;
        private Label label8;
        private Label label7;
        private Label label_precio_total;
    }
}