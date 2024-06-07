namespace SistemaGestion
{
    partial class VentasForm
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
            button2 = new Button();
            comboBox1 = new ComboBox();
            button1 = new Button();
            dgvVentas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(539, 57);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 15;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += this.button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(106, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += this.comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(620, 57);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(106, 102);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowTemplate.Height = 25;
            dgvVentas.Size = new Size(589, 291);
            dgvVentas.TabIndex = 12;
            dgvVentas.CellClick += dgvVentas_CellClick;
            // 
            // VentasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(dgvVentas);
            Name = "VentasForm";
            Text = "VentasForm";
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private ComboBox comboBox1;
        private Button button1;
        private DataGridView dgvVentas;
    }
}