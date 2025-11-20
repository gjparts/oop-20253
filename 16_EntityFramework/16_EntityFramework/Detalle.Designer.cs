namespace _16_EntityFramework
{
    partial class Detalle
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
            Cancelar = new Button();
            Aceptar = new Button();
            label1 = new Label();
            Codigo = new TextBox();
            Nombre = new TextBox();
            label2 = new Label();
            Costo = new TextBox();
            label3 = new Label();
            PrecioVenta = new TextBox();
            label4 = new Label();
            Existencias = new TextBox();
            label5 = new Label();
            Comentarios = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // Cancelar
            // 
            Cancelar.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cancelar.Location = new Point(632, 375);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(156, 63);
            Cancelar.TabIndex = 0;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            Cancelar.Click += Cancelar_Click;
            // 
            // Aceptar
            // 
            Aceptar.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Aceptar.Location = new Point(470, 375);
            Aceptar.Name = "Aceptar";
            Aceptar.Size = new Size(156, 63);
            Aceptar.TabIndex = 1;
            Aceptar.Text = "Aceptar";
            Aceptar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(96, 32);
            label1.TabIndex = 2;
            label1.Text = "Código:";
            // 
            // Codigo
            // 
            Codigo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Codigo.Location = new Point(203, 6);
            Codigo.MaxLength = 30;
            Codigo.Name = "Codigo";
            Codigo.Size = new Size(277, 39);
            Codigo.TabIndex = 3;
            // 
            // Nombre
            // 
            Nombre.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Nombre.Location = new Point(203, 51);
            Nombre.MaxLength = 255;
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(585, 39);
            Nombre.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(107, 32);
            label2.TabIndex = 4;
            label2.Text = "Nombre:";
            // 
            // Costo
            // 
            Costo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Costo.Location = new Point(203, 96);
            Costo.Name = "Costo";
            Costo.Size = new Size(238, 39);
            Costo.TabIndex = 7;
            Costo.Text = "0.00";
            Costo.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 99);
            label3.Name = "label3";
            label3.Size = new Size(80, 32);
            label3.TabIndex = 6;
            label3.Text = "Costo:";
            // 
            // PrecioVenta
            // 
            PrecioVenta.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrecioVenta.Location = new Point(203, 141);
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.Size = new Size(238, 39);
            PrecioVenta.TabIndex = 9;
            PrecioVenta.Text = "0.00";
            PrecioVenta.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 144);
            label4.Name = "label4";
            label4.Size = new Size(185, 32);
            label4.TabIndex = 8;
            label4.Text = "Precio de Venta:";
            // 
            // Existencias
            // 
            Existencias.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Existencias.Location = new Point(203, 186);
            Existencias.Name = "Existencias";
            Existencias.Size = new Size(238, 39);
            Existencias.TabIndex = 11;
            Existencias.Text = "0.00";
            Existencias.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 189);
            label5.Name = "label5";
            label5.Size = new Size(132, 32);
            label5.TabIndex = 10;
            label5.Text = "Existencias:";
            // 
            // Comentarios
            // 
            Comentarios.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Comentarios.Location = new Point(203, 231);
            Comentarios.Multiline = true;
            Comentarios.Name = "Comentarios";
            Comentarios.Size = new Size(585, 138);
            Comentarios.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 234);
            label6.Name = "label6";
            label6.Size = new Size(154, 32);
            label6.TabIndex = 12;
            label6.Text = "Comentarios:";
            // 
            // Detalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(Comentarios);
            Controls.Add(label6);
            Controls.Add(Existencias);
            Controls.Add(label5);
            Controls.Add(PrecioVenta);
            Controls.Add(label4);
            Controls.Add(Costo);
            Controls.Add(label3);
            Controls.Add(Nombre);
            Controls.Add(label2);
            Controls.Add(Codigo);
            Controls.Add(label1);
            Controls.Add(Aceptar);
            Controls.Add(Cancelar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Detalle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cancelar;
        private Button Aceptar;
        private Label label1;
        private TextBox Codigo;
        private TextBox Nombre;
        private Label label2;
        private TextBox Costo;
        private Label label3;
        private TextBox PrecioVenta;
        private Label label4;
        private TextBox Existencias;
        private Label label5;
        private TextBox Comentarios;
        private Label label6;
    }
}