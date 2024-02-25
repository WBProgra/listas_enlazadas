namespace WinFormsApp2
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
            nombre = new Label();
            edad = new Label();
            resultado = new Label();
            nombre_text = new TextBox();
            edad_text = new TextBox();
            ingresar = new Button();
            jove = new Button();
            viejo = new Button();
            data = new Label();
            data_Edad = new Label();
            SuspendLayout();
            // 
            // nombre
            // 
            nombre.AutoSize = true;
            nombre.Location = new Point(132, 61);
            nombre.Name = "nombre";
            nombre.Size = new Size(51, 15);
            nombre.TabIndex = 0;
            nombre.Text = "Nombre";
            // 
            // edad
            // 
            edad.AutoSize = true;
            edad.Location = new Point(132, 94);
            edad.Name = "edad";
            edad.Size = new Size(33, 15);
            edad.TabIndex = 0;
            edad.Text = "edad";
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Location = new Point(347, 376);
            resultado.Name = "resultado";
            resultado.Size = new Size(59, 15);
            resultado.TabIndex = 0;
            resultado.Text = "Resultado";
            // 
            // nombre_text
            // 
            nombre_text.Location = new Point(220, 61);
            nombre_text.Name = "nombre_text";
            nombre_text.Size = new Size(100, 23);
            nombre_text.TabIndex = 1;
            // 
            // edad_text
            // 
            edad_text.Location = new Point(220, 94);
            edad_text.Name = "edad_text";
            edad_text.Size = new Size(100, 23);
            edad_text.TabIndex = 1;
            // 
            // ingresar
            // 
            ingresar.Location = new Point(413, 85);
            ingresar.Name = "ingresar";
            ingresar.Size = new Size(75, 23);
            ingresar.TabIndex = 2;
            ingresar.Text = "Ingresar";
            ingresar.UseVisualStyleBackColor = true;
            ingresar.Click += ingresar_Click;
            // 
            // jove
            // 
            jove.Location = new Point(230, 272);
            jove.Name = "jove";
            jove.Size = new Size(75, 23);
            jove.TabIndex = 3;
            jove.Text = "Joven";
            jove.UseVisualStyleBackColor = true;
            jove.Click += jove_Click;
            // 
            // viejo
            // 
            viejo.Location = new Point(413, 272);
            viejo.Name = "viejo";
            viejo.Size = new Size(75, 23);
            viejo.TabIndex = 3;
            viejo.Text = "Viejo";
            viejo.UseVisualStyleBackColor = true;
            viejo.Click += viejo_Click;
            // 
            // data
            // 
            data.AutoSize = true;
            data.Location = new Point(347, 413);
            data.Name = "data";
            data.Size = new Size(0, 15);
            data.TabIndex = 4;
            // 
            // data_Edad
            // 
            data_Edad.AutoSize = true;
            data_Edad.Location = new Point(352, 424);
            data_Edad.Name = "data_Edad";
            data_Edad.Size = new Size(0, 15);
            data_Edad.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(data_Edad);
            Controls.Add(data);
            Controls.Add(viejo);
            Controls.Add(jove);
            Controls.Add(ingresar);
            Controls.Add(edad_text);
            Controls.Add(nombre_text);
            Controls.Add(resultado);
            Controls.Add(edad);
            Controls.Add(nombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nombre;
        private Label edad;
        private Label resultado;
        private TextBox nombre_text;
        private TextBox edad_text;
        private Button ingresar;
        private Button jove;
        private Button viejo;
        private Label data;
        private Label data_Edad;
    }
}
