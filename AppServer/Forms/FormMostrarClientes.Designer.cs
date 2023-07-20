namespace AppServer.Forms
{
    partial class FormMostrarClientes
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
            dataGridView_consul_clientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_consul_clientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 0;
            label1.Text = "Consultar Clientes";
            // 
            // dataGridView_consul_clientes
            // 
            dataGridView_consul_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_consul_clientes.Location = new Point(12, 37);
            dataGridView_consul_clientes.Name = "dataGridView_consul_clientes";
            dataGridView_consul_clientes.RowHeadersWidth = 62;
            dataGridView_consul_clientes.RowTemplate.Height = 33;
            dataGridView_consul_clientes.Size = new Size(854, 855);
            dataGridView_consul_clientes.TabIndex = 1;
            // 
            // FormMostrarClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 904);
            Controls.Add(dataGridView_consul_clientes);
            Controls.Add(label1);
            Name = "FormMostrarClientes";
            Text = "Consultar Clientes";
            ((System.ComponentModel.ISupportInitialize)dataGridView_consul_clientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView_consul_clientes;
    }
}