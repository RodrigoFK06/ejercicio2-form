namespace ejercicio2_form
{
    partial class Form1
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
            label1 = new Label();
            label3 = new Label();
            txtPosicion = new TextBox();
            listBox1 = new ListBox();
            btnEliminar = new Button();
            btnCalcularMediaGeometrica = new Button();
            label2 = new Label();
            btnCalcularPromedio = new Button();
            label4 = new Label();
            label5 = new Label();
            btnValoresMenoresAlPromedio = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(356, 31);
            label1.Name = "label1";
            label1.Size = new Size(106, 30);
            label1.TabIndex = 0;
            label1.Text = "Ejercicio2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(23, 178);
            label3.Name = "label3";
            label3.Size = new Size(161, 21);
            label3.TabIndex = 7;
            label3.Text = "Posición a eliminar:";
            // 
            // txtPosicion
            // 
            txtPosicion.Location = new Point(195, 176);
            txtPosicion.Name = "txtPosicion";
            txtPosicion.Size = new Size(103, 23);
            txtPosicion.TabIndex = 9;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(356, 109);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(88, 19);
            listBox1.TabIndex = 19;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(333, 179);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnCalcularMediaGeometrica
            // 
            btnCalcularMediaGeometrica.Location = new Point(195, 233);
            btnCalcularMediaGeometrica.Name = "btnCalcularMediaGeometrica";
            btnCalcularMediaGeometrica.Size = new Size(121, 23);
            btnCalcularMediaGeometrica.TabIndex = 21;
            btnCalcularMediaGeometrica.Text = "Calcular Media";
            btnCalcularMediaGeometrica.UseVisualStyleBackColor = true;
            btnCalcularMediaGeometrica.Click += btnCalcularMediaGeometrica_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 235);
            label2.Name = "label2";
            label2.Size = new Size(153, 21);
            label2.TabIndex = 22;
            label2.Text = "Media geométrica:";
            // 
            // btnCalcularPromedio
            // 
            btnCalcularPromedio.Location = new Point(195, 283);
            btnCalcularPromedio.Name = "btnCalcularPromedio";
            btnCalcularPromedio.Size = new Size(121, 23);
            btnCalcularPromedio.TabIndex = 23;
            btnCalcularPromedio.Text = "Calcular Promedio";
            btnCalcularPromedio.UseVisualStyleBackColor = true;
            btnCalcularPromedio.Click += btnCalcularPromedio_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(23, 283);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 24;
            label4.Text = "Promedio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(23, 341);
            label5.Name = "label5";
            label5.Size = new Size(237, 21);
            label5.TabIndex = 25;
            label5.Text = "Valores menores al promedio:";
            // 
            // btnValoresMenoresAlPromedio
            // 
            btnValoresMenoresAlPromedio.Location = new Point(287, 339);
            btnValoresMenoresAlPromedio.Name = "btnValoresMenoresAlPromedio";
            btnValoresMenoresAlPromedio.Size = new Size(121, 23);
            btnValoresMenoresAlPromedio.TabIndex = 26;
            btnValoresMenoresAlPromedio.Text = "Valores";
            btnValoresMenoresAlPromedio.UseVisualStyleBackColor = true;
            btnValoresMenoresAlPromedio.Click += btnValoresMenoresAlPromedio_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnValoresMenoresAlPromedio);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnCalcularPromedio);
            Controls.Add(label2);
            Controls.Add(btnCalcularMediaGeometrica);
            Controls.Add(btnEliminar);
            Controls.Add(listBox1);
            Controls.Add(txtPosicion);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox txtPosicion;
        private ListBox listBox1;
        private Button btnEliminar;
        private Button btnCalcularMediaGeometrica;
        private Label label2;
        private Button btnCalcularPromedio;
        private Label label4;
        private Label label5;
        private Button btnValoresMenoresAlPromedio;
    }
}