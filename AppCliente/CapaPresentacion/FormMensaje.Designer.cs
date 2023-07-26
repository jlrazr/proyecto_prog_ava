namespace AppCliente.Forms
{
    partial class FormMensaje
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
            Label_mensaje = new Label();
            SuspendLayout();
            // 
            // Label_mensaje
            // 
            Label_mensaje.AutoSize = true;
            Label_mensaje.Location = new Point(12, 9);
            Label_mensaje.Name = "Label_mensaje";
            Label_mensaje.Size = new Size(77, 25);
            Label_mensaje.TabIndex = 0;
            Label_mensaje.Text = "Mensaje";
            // 
            // FormMensaje
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 164);
            Controls.Add(Label_mensaje);
            Name = "FormMensaje";
            Text = "Mensaje";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_mensaje;
    }
}