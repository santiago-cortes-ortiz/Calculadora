namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1txt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1txt = new System.Windows.Forms.TextBox();
            this.textBox2txt = new System.Windows.Forms.TextBox();
            this.button1btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.error2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.error3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button6salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1txt
            // 
            this.label1txt.AutoSize = true;
            this.label1txt.Location = new System.Drawing.Point(106, 122);
            this.label1txt.Name = "label1txt";
            this.label1txt.Size = new System.Drawing.Size(99, 25);
            this.label1txt.TabIndex = 0;
            this.label1txt.Text = "Numero1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero2";
            // 
            // textBox1txt
            // 
            this.textBox1txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1txt.Location = new System.Drawing.Point(256, 115);
            this.textBox1txt.Name = "textBox1txt";
            this.textBox1txt.Size = new System.Drawing.Size(100, 35);
            this.textBox1txt.TabIndex = 2;
            // 
            // textBox2txt
            // 
            this.textBox2txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2txt.Location = new System.Drawing.Point(256, 169);
            this.textBox2txt.Name = "textBox2txt";
            this.textBox2txt.Size = new System.Drawing.Size(100, 35);
            this.textBox2txt.TabIndex = 3;
            // 
            // button1btn
            // 
            this.button1btn.Location = new System.Drawing.Point(245, 244);
            this.button1btn.Name = "button1btn";
            this.button1btn.Size = new System.Drawing.Size(129, 63);
            this.button1btn.TabIndex = 4;
            this.button1btn.Text = "Guardar Datos";
            this.button1btn.UseVisualStyleBackColor = true;
            this.button1btn.Click += new System.EventHandler(this.button1btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resultado";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(256, 363);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 38);
            this.textBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(484, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 51);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sumar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 51);
            this.label3.TabIndex = 8;
            this.label3.Text = "CALCULADORA";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(594, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 51);
            this.button2.TabIndex = 9;
            this.button2.Text = "Resta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(484, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 58);
            this.button3.TabIndex = 10;
            this.button3.Text = "Multiplicacion";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(594, 216);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 58);
            this.button4.TabIndex = 11;
            this.button4.Text = "Division";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(541, 280);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 48);
            this.button5.TabIndex = 12;
            this.button5.Text = "Limpiar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // error2
            // 
            this.error2.ContainerControl = this;
            // 
            // error3
            // 
            this.error3.ContainerControl = this;
            // 
            // button6salir
            // 
            this.button6salir.Location = new System.Drawing.Point(541, 366);
            this.button6salir.Name = "button6salir";
            this.button6salir.Size = new System.Drawing.Size(94, 47);
            this.button6salir.TabIndex = 13;
            this.button6salir.Text = "SALIR";
            this.button6salir.UseVisualStyleBackColor = true;
            this.button6salir.Click += new System.EventHandler(this.button6salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6salir);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1btn);
            this.Controls.Add(this.textBox2txt);
            this.Controls.Add(this.textBox1txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label1txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1txt;
        private System.Windows.Forms.TextBox textBox2txt;
        private System.Windows.Forms.Button button1btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ErrorProvider error1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ErrorProvider error2;
        private System.Windows.Forms.ErrorProvider error3;
        private System.Windows.Forms.Button button6salir;
    }
}

