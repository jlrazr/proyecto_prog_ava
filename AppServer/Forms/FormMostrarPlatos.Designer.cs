namespace AppServidor.Forms
{
    partial class FormMostrarPlatos
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
            dataGridView_consul_platos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_consul_platos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 0;
            label1.Text = "Consultar Platos";
            // 
            // dataGridView_consul_platos
            // 
            dataGridView_consul_platos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_consul_platos.Location = new Point(12, 46);
            dataGridView_consul_platos.Name = "dataGridView_consul_platos";
            dataGridView_consul_platos.RowHeadersWidth = 62;
            dataGridView_consul_platos.RowTemplate.Height = 33;
            dataGridView_consul_platos.Size = new Size(854, 846);
            dataGridView_consul_platos.TabIndex = 1;
            // 
            // FormMostrarPlatos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 904);
            Controls.Add(dataGridView_consul_platos);
            Controls.Add(label1);
            Name = "FormMostrarPlatos";
            Text = "Consultar Platos";
            ((System.ComponentModel.ISupportInitialize)dataGridView_consul_platos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView_consul_platos;
    }
}