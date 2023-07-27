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
            label_cliente = new Label();
            label2 = new Label();
            button_cliente_logout = new Button();
            groupBox_pedido = new GroupBox();
            groupBox_login.SuspendLayout();
            SuspendLayout();
            // 
            // button_cliente_login
            // 
            button_cliente_login.Location = new Point(6, 92);
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
            groupBox_login.Controls.Add(label_cliente);
            groupBox_login.Controls.Add(label2);
            groupBox_login.Controls.Add(button_cliente_logout);
            groupBox_login.Controls.Add(button_cliente_login);
            groupBox_login.Controls.Add(textBox_cliente_id_login);
            groupBox_login.Location = new Point(12, 12);
            groupBox_login.Name = "groupBox_login";
            groupBox_login.Size = new Size(854, 239);
            groupBox_login.TabIndex = 3;
            groupBox_login.TabStop = false;
            // 
            // label_cliente
            // 
            label_cliente.AutoSize = true;
            label_cliente.Location = new Point(449, 27);
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
            button_cliente_logout.Location = new Point(6, 152);
            button_cliente_logout.Name = "button_cliente_logout";
            button_cliente_logout.Size = new Size(230, 53);
            button_cliente_logout.TabIndex = 4;
            button_cliente_logout.Text = "Cerrar Sesión";
            button_cliente_logout.UseVisualStyleBackColor = true;
            button_cliente_logout.Click += button_cliente_logout_Click;
            // 
            // groupBox_pedido
            // 
            groupBox_pedido.Location = new Point(12, 257);
            groupBox_pedido.Name = "groupBox_pedido";
            groupBox_pedido.Size = new Size(854, 635);
            groupBox_pedido.TabIndex = 5;
            groupBox_pedido.TabStop = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 904);
            Controls.Add(groupBox_pedido);
            Controls.Add(groupBox_login);
            Name = "FormPrincipal";
            Text = "RESTUNED Pedidos";
            groupBox_login.ResumeLayout(false);
            groupBox_login.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button_cliente_login;
        private TextBox textBox_cliente_id_login;
        private GroupBox groupBox_login;
        private Label label2;
        private Button button_cliente_logout;
        private GroupBox groupBox_pedido;
        private Label label_cliente;
    }
}