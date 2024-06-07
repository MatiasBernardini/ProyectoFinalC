namespace SistemaGestion
{
    partial class ProductoForm
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
            txtStock = new TextBox();
            txtIdUser = new TextBox();
            txtCosto = new TextBox();
            txtPrecioVenta = new TextBox();
            txtId = new TextBox();
            txtDescripcion = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtStock
            // 
            txtStock.Location = new Point(164, 261);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 29;
            // 
            // txtIdUser
            // 
            txtIdUser.Location = new Point(164, 320);
            txtIdUser.Name = "txtIdUser";
            txtIdUser.Size = new Size(100, 23);
            txtIdUser.TabIndex = 28;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(164, 147);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(100, 23);
            txtCosto.TabIndex = 27;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(164, 206);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(100, 23);
            txtPrecioVenta.TabIndex = 26;
            // 
            // txtId
            // 
            txtId.Location = new Point(164, 36);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 25;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(164, 89);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(16, 318);
            label6.Name = "label6";
            label6.Size = new Size(74, 25);
            label6.TabIndex = 23;
            label6.Text = "Id User";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(16, 259);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 22;
            label5.Text = "Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(16, 204);
            label4.Name = "label4";
            label4.Size = new Size(125, 25);
            label4.TabIndex = 21;
            label4.Text = "Precio Venta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(16, 145);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 20;
            label3.Text = "Costo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(16, 87);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 19;
            label2.Text = "Descripcion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(16, 31);
            label1.Name = "label1";
            label1.Size = new Size(29, 25);
            label1.TabIndex = 18;
            label1.Text = "Id";
            // 
            // button3
            // 
            button3.Location = new Point(200, 392);
            button3.Name = "button3";
            button3.Size = new Size(75, 27);
            button3.TabIndex = 17;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(107, 392);
            button2.Name = "button2";
            button2.Size = new Size(75, 27);
            button2.TabIndex = 16;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(10, 392);
            button1.Name = "button1";
            button1.Size = new Size(75, 27);
            button1.TabIndex = 15;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ProductoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 450);
            Controls.Add(txtStock);
            Controls.Add(txtIdUser);
            Controls.Add(txtCosto);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtId);
            Controls.Add(txtDescripcion);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ProductoForm";
            Text = "ProductoForm";
            Load += ProductoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStock;
        private TextBox txtIdUser;
        private TextBox txtCosto;
        private TextBox txtPrecioVenta;
        private TextBox txtId;
        private TextBox txtDescripcion;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}