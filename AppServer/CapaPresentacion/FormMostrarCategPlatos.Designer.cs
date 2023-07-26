namespace AppServidor.Forms
{
    partial class FormMostrarCategPlatos
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
            dataGridView_consul_categ = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_consul_categ).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(254, 25);
            label1.TabIndex = 0;
            label1.Text = "Consultar Categorías de Platos";
            // 
            // dataGridView_consul_categ
            // 
            dataGridView_consul_categ.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_consul_categ.Location = new Point(12, 50);
            dataGridView_consul_categ.Name = "dataGridView_consul_categ";
            dataGridView_consul_categ.RowHeadersWidth = 62;
            dataGridView_consul_categ.RowTemplate.Height = 33;
            dataGridView_consul_categ.Size = new Size(854, 842);
            dataGridView_consul_categ.TabIndex = 1;
            // 
            // FormMostrarCategPlatos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 904);
            Controls.Add(dataGridView_consul_categ);
            Controls.Add(label1);
            Name = "FormMostrarCategPlatos";
            Text = "Consultar Categorías de Platos";
            ((System.ComponentModel.ISupportInitialize)dataGridView_consul_categ).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView_consul_categ;
    }
}