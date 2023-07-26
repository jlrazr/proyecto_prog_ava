namespace AppServidor.Forms
{
    partial class FormMostrarPlatoRestaurante
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
            comboBox_consul_restaurantes = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            dataGridView_consul_PlatoRest = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_consul_PlatoRest).BeginInit();
            SuspendLayout();
            // 
            // comboBox_consul_restaurantes
            // 
            comboBox_consul_restaurantes.FormattingEnabled = true;
            comboBox_consul_restaurantes.Location = new Point(12, 56);
            comboBox_consul_restaurantes.Name = "comboBox_consul_restaurantes";
            comboBox_consul_restaurantes.Size = new Size(495, 33);
            comboBox_consul_restaurantes.TabIndex = 0;
            comboBox_consul_restaurantes.SelectedIndexChanged += comboBox_consul_restaurantes_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(209, 25);
            label1.TabIndex = 1;
            label1.Text = "Seleccione el Restaurante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 213);
            label2.Name = "label2";
            label2.Size = new Size(292, 25);
            label2.TabIndex = 2;
            label2.Text = "Asignación de Platos al Restaurante";
            // 
            // dataGridView_consul_PlatoRest
            // 
            dataGridView_consul_PlatoRest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_consul_PlatoRest.Location = new Point(12, 256);
            dataGridView_consul_PlatoRest.Name = "dataGridView_consul_PlatoRest";
            dataGridView_consul_PlatoRest.RowHeadersWidth = 62;
            dataGridView_consul_PlatoRest.RowTemplate.Height = 33;
            dataGridView_consul_PlatoRest.Size = new Size(854, 636);
            dataGridView_consul_PlatoRest.TabIndex = 3;
            // 
            // FormMostrarPlatoRestaurante
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 904);
            Controls.Add(dataGridView_consul_PlatoRest);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox_consul_restaurantes);
            Name = "FormMostrarPlatoRestaurante";
            Text = "Consultar Asignación Plato Restaurante";
            ((System.ComponentModel.ISupportInitialize)dataGridView_consul_PlatoRest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_consul_restaurantes;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView_consul_PlatoRest;
    }
}