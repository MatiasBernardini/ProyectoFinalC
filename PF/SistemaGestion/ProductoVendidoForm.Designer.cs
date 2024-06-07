namespace SistemaGestion
{
    partial class ProductoVendidoForm
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
            txtIdProducto = new TextBox();
            txtIdVenta = new TextBox();
            txtId = new TextBox();
            txtStock = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(172, 147);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(100, 23);
            txtIdProducto.TabIndex = 42;
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(172, 206);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(100, 23);
            txtIdVenta.TabIndex = 41;
            // 
            // txtId
            // 
            txtId.Location = new Point(172, 36);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 40;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(172, 89);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(24, 204);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 36;
            label4.Text = "IdVenta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(24, 145);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 35;
            label3.Text = "IdProducto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(24, 87);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 34;
            label2.Text = "Stock";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(24, 31);
            label1.Name = "label1";
            label1.Size = new Size(29, 25);
            label1.TabIndex = 33;
            label1.Text = "Id";
            // 
            // button3
            // 
            button3.Location = new Point(208, 392);
            button3.Name = "button3";
            button3.Size = new Size(75, 27);
            button3.TabIndex = 32;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(115, 392);
            button2.Name = "button2";
            button2.Size = new Size(75, 27);
            button2.TabIndex = 31;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(18, 392);
            button1.Name = "button1";
            button1.Size = new Size(75, 27);
            button1.TabIndex = 30;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ProductoVendidoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 450);
            Controls.Add(txtIdProducto);
            Controls.Add(txtIdVenta);
            Controls.Add(txtId);
            Controls.Add(txtStock);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ProductoVendidoForm";
            Text = "ProductoVendidoForm";
            Load += ProductoVendidoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtIdProducto;
        private TextBox txtIdVenta;
        private TextBox txtId;
        private TextBox txtStock;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}