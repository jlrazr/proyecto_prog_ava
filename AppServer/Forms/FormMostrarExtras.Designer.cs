namespace AppServidor.Forms
{
    partial class FormMostrarExtras
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
            dataGridView_consul_extras = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_consul_extras).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 0;
            label1.Text = "Consultar Extras";
            // 
            // dataGridView_consul_extras
            // 
            dataGridView_consul_extras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_consul_extras.Location = new Point(12, 50);
            dataGridView_consul_extras.Name = "dataGridView_consul_extras";
            dataGridView_consul_extras.RowHeadersWidth = 62;
            dataGridView_consul_extras.RowTemplate.Height = 33;
            dataGridView_consul_extras.Size = new Size(854, 842);
            dataGridView_consul_extras.TabIndex = 1;
            // 
            // FormMostrarExtra
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 904);
            Controls.Add(dataGridView_consul_extras);
            Controls.Add(label1);
            Name = "FormMostrarExtra";
            Text = "Consultar Extras";
            ((System.ComponentModel.ISupportInitialize)dataGridView_consul_extras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView_consul_extras;
    }
}