namespace SistemaGestion
{
    partial class VentaForm
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
            txtUsuario = new TextBox();
            txtId = new TextBox();
            txtComentarios = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(165, 144);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 53;
            // 
            // txtId
            // 
            txtId.Location = new Point(165, 36);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 51;
            // 
            // txtComentarios
            // 
            txtComentarios.Location = new Point(147, 89);
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(129, 23);
            txtComentarios.TabIndex = 50;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(17, 142);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 48;
            label3.Text = "IdUsuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(17, 87);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 47;
            label2.Text = "Comentarios";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(17, 31);
            label1.Name = "label1";
            label1.Size = new Size(29, 25);
            label1.TabIndex = 46;
            label1.Text = "Id";
            // 
            // button3
            // 
            button3.Location = new Point(201, 392);
            button3.Name = "button3";
            button3.Size = new Size(75, 27);
            button3.TabIndex = 45;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(108, 392);
            button2.Name = "button2";
            button2.Size = new Size(75, 27);
            button2.TabIndex = 44;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(11, 392);
            button1.Name = "button1";
            button1.Size = new Size(75, 27);
            button1.TabIndex = 43;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // VentaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 450);
            Controls.Add(txtUsuario);
            Controls.Add(txtId);
            Controls.Add(txtComentarios);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "VentaForm";
            Text = "VentaForm";
            Load += VentaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtId;
        private TextBox txtComentarios;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}