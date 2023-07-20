namespace AppServer.Forms
{
    partial class FormMostrarRestaurantes
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
            dataGridView_consul_restaruantes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_consul_restaruantes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(192, 25);
            label1.TabIndex = 0;
            label1.Text = "Consultar Restaurantes";
            // 
            // dataGridView_consul_restaruantes
            // 
            dataGridView_consul_restaruantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_consul_restaruantes.Location = new Point(12, 57);
            dataGridView_consul_restaruantes.Name = "dataGridView_consul_restaruantes";
            dataGridView_consul_restaruantes.RowHeadersWidth = 62;
            dataGridView_consul_restaruantes.RowTemplate.Height = 33;
            dataGridView_consul_restaruantes.Size = new Size(854, 526);
            dataGridView_consul_restaruantes.TabIndex = 1;
            // 
            // FormMostrarRestaurantes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 904);
            Controls.Add(dataGridView_consul_restaruantes);
            Controls.Add(label1);
            Name = "FormMostrarRestaurantes";
            Text = "Consultar Restaurantes";
            ((System.ComponentModel.ISupportInitialize)dataGridView_consul_restaruantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView_consul_restaruantes;
    }
}