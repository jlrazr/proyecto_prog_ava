namespace AppCliente.CapaPresentacion
{
    partial class FormHistorialPedidos
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
            textBox_historial_id_pedido = new TextBox();
            label2 = new Label();
            dataGridView_historial_platos_pedido = new DataGridView();
            dataGridView_historial_extras_pedido = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            button_historial_consultar_porId = new Button();
            comboBox_historial_lista_pedidos = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            label_historial_nombre_cliente = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_historial_platos_pedido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_historial_extras_pedido).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(203, 25);
            label1.TabIndex = 0;
            label1.Text = "Consultar Pedido por ID";
            // 
            // textBox_historial_id_pedido
            // 
            textBox_historial_id_pedido.Location = new Point(57, 75);
            textBox_historial_id_pedido.Name = "textBox_historial_id_pedido";
            textBox_historial_id_pedido.Size = new Size(158, 31);
            textBox_historial_id_pedido.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(39, 25);
            label2.TabIndex = 2;
            label2.Text = "ID: ";
            // 
            // dataGridView_historial_platos_pedido
            // 
            dataGridView_historial_platos_pedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_historial_platos_pedido.Location = new Point(12, 204);
            dataGridView_historial_platos_pedido.Name = "dataGridView_historial_platos_pedido";
            dataGridView_historial_platos_pedido.RowHeadersWidth = 62;
            dataGridView_historial_platos_pedido.RowTemplate.Height = 33;
            dataGridView_historial_platos_pedido.Size = new Size(854, 241);
            dataGridView_historial_platos_pedido.TabIndex = 3;
            // 
            // dataGridView_historial_extras_pedido
            // 
            dataGridView_historial_extras_pedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_historial_extras_pedido.Location = new Point(12, 496);
            dataGridView_historial_extras_pedido.Name = "dataGridView_historial_extras_pedido";
            dataGridView_historial_extras_pedido.RowHeadersWidth = 62;
            dataGridView_historial_extras_pedido.RowTemplate.Height = 33;
            dataGridView_historial_extras_pedido.Size = new Size(854, 219);
            dataGridView_historial_extras_pedido.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 176);
            label3.Name = "label3";
            label3.Size = new Size(149, 25);
            label3.TabIndex = 5;
            label3.Text = "Platos del Pedido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 468);
            label4.Name = "label4";
            label4.Size = new Size(147, 25);
            label4.TabIndex = 6;
            label4.Text = "Extras del Pedido";
            // 
            // button_historial_consultar_porId
            // 
            button_historial_consultar_porId.Location = new Point(12, 112);
            button_historial_consultar_porId.Name = "button_historial_consultar_porId";
            button_historial_consultar_porId.Size = new Size(203, 34);
            button_historial_consultar_porId.TabIndex = 7;
            button_historial_consultar_porId.Text = "Consultar por ID";
            button_historial_consultar_porId.UseVisualStyleBackColor = true;
            button_historial_consultar_porId.Click += button_historial_consultar_porId_Click;
            // 
            // comboBox_historial_lista_pedidos
            // 
            comboBox_historial_lista_pedidos.FormattingEnabled = true;
            comboBox_historial_lista_pedidos.Location = new Point(475, 103);
            comboBox_historial_lista_pedidos.Name = "comboBox_historial_lista_pedidos";
            comboBox_historial_lista_pedidos.Size = new Size(373, 33);
            comboBox_historial_lista_pedidos.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(475, 9);
            label5.Name = "label5";
            label5.Size = new Size(156, 25);
            label5.TabIndex = 9;
            label5.Text = "Todos los Pedidos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(475, 75);
            label6.Name = "label6";
            label6.Size = new Size(373, 25);
            label6.TabIndex = 10;
            label6.Text = "Elija un pedido de la lista para ver sus detalles";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(350, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(10, 167);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // label_historial_nombre_cliente
            // 
            label_historial_nombre_cliente.AutoSize = true;
            label_historial_nombre_cliente.Location = new Point(12, 39);
            label_historial_nombre_cliente.Name = "label_historial_nombre_cliente";
            label_historial_nombre_cliente.Size = new Size(74, 25);
            label_historial_nombre_cliente.TabIndex = 12;
            label_historial_nombre_cliente.Text = "Cliente: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 757);
            label7.Name = "label7";
            label7.Size = new Size(313, 32);
            label7.TabIndex = 13;
            label7.Text = "Costo del Pedido: 0 Colones";
            // 
            // FormHistorialPedidos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 904);
            Controls.Add(label7);
            Controls.Add(label_historial_nombre_cliente);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox_historial_lista_pedidos);
            Controls.Add(button_historial_consultar_porId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView_historial_extras_pedido);
            Controls.Add(dataGridView_historial_platos_pedido);
            Controls.Add(label2);
            Controls.Add(textBox_historial_id_pedido);
            Controls.Add(label1);
            Name = "FormHistorialPedidos";
            Text = "Historial de Pedidos";
            Shown += FormHistorialPedidos_Shown;
            ((System.ComponentModel.ISupportInitialize)dataGridView_historial_platos_pedido).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_historial_extras_pedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_historial_id_pedido;
        private Label label2;
        private DataGridView dataGridView_historial_platos_pedido;
        private DataGridView dataGridView_historial_extras_pedido;
        private Label label3;
        private Label label4;
        private Button button_historial_consultar_porId;
        private ComboBox comboBox_historial_lista_pedidos;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private Label label_historial_nombre_cliente;
        private Label label7;
    }
}