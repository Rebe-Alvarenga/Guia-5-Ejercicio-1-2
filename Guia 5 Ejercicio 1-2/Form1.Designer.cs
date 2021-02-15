
namespace Guia_5_Ejercicio_1_2
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
            this.appName_Label = new System.Windows.Forms.Label();
            this.name_Label = new System.Windows.Forms.Label();
            this.name_Box = new System.Windows.Forms.TextBox();
            this.salary_Box = new System.Windows.Forms.TextBox();
            this.salary_Label = new System.Windows.Forms.Label();
            this.position_Label = new System.Windows.Forms.Label();
            this.calculate_Button = new System.Windows.Forms.Button();
            this.position_Combo = new System.Windows.Forms.ComboBox();
            this.author_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // appName_Label
            // 
            this.appName_Label.AutoSize = true;
            this.appName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.appName_Label.Location = new System.Drawing.Point(12, 172);
            this.appName_Label.Name = "appName_Label";
            this.appName_Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.appName_Label.Size = new System.Drawing.Size(286, 31);
            this.appName_Label.TabIndex = 0;
            this.appName_Label.Text = "Calculador de Salarios";
            // 
            // name_Label
            // 
            this.name_Label.AutoSize = true;
            this.name_Label.Location = new System.Drawing.Point(15, 20);
            this.name_Label.Name = "name_Label";
            this.name_Label.Size = new System.Drawing.Size(111, 13);
            this.name_Label.TabIndex = 1;
            this.name_Label.Text = "Nombre del Empleado";
            this.name_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // name_Box
            // 
            this.name_Box.Location = new System.Drawing.Point(132, 17);
            this.name_Box.Name = "name_Box";
            this.name_Box.Size = new System.Drawing.Size(251, 20);
            this.name_Box.TabIndex = 2;
            this.name_Box.TextChanged += new System.EventHandler(this.name_Box_TextChanged);
            // 
            // salary_Box
            // 
            this.salary_Box.Location = new System.Drawing.Point(132, 55);
            this.salary_Box.Name = "salary_Box";
            this.salary_Box.Size = new System.Drawing.Size(105, 20);
            this.salary_Box.TabIndex = 4;
            this.salary_Box.TextChanged += new System.EventHandler(this.salary_Box_TextChanged);
            // 
            // salary_Label
            // 
            this.salary_Label.AutoSize = true;
            this.salary_Label.Location = new System.Drawing.Point(49, 58);
            this.salary_Label.Name = "salary_Label";
            this.salary_Label.Size = new System.Drawing.Size(77, 13);
            this.salary_Label.TabIndex = 3;
            this.salary_Label.Text = "Salario ($USD)";
            this.salary_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // position_Label
            // 
            this.position_Label.AutoSize = true;
            this.position_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.position_Label.Location = new System.Drawing.Point(44, 92);
            this.position_Label.Name = "position_Label";
            this.position_Label.Size = new System.Drawing.Size(82, 48);
            this.position_Label.TabIndex = 8;
            this.position_Label.Text = "Posicion\r\nLaboral";
            this.position_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // calculate_Button
            // 
            this.calculate_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.calculate_Button.Location = new System.Drawing.Point(246, 101);
            this.calculate_Button.Name = "calculate_Button";
            this.calculate_Button.Size = new System.Drawing.Size(142, 39);
            this.calculate_Button.TabIndex = 10;
            this.calculate_Button.Text = "Calcular Ahora";
            this.calculate_Button.UseVisualStyleBackColor = true;
            this.calculate_Button.Click += new System.EventHandler(this.calculate_Button_Click);
            // 
            // position_Combo
            // 
            this.position_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.position_Combo.FormattingEnabled = true;
            this.position_Combo.Items.AddRange(new object[] {
            "Gerente",
            "Subgerente",
            "Secretaria"});
            this.position_Combo.Location = new System.Drawing.Point(132, 109);
            this.position_Combo.Name = "position_Combo";
            this.position_Combo.Size = new System.Drawing.Size(105, 21);
            this.position_Combo.TabIndex = 11;
            this.position_Combo.SelectedIndexChanged += new System.EventHandler(this.position_Combo_SelectedIndexChanged);
            // 
            // author_Label
            // 
            this.author_Label.AutoSize = true;
            this.author_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.author_Label.Location = new System.Drawing.Point(15, 203);
            this.author_Label.Name = "author_Label";
            this.author_Label.Size = new System.Drawing.Size(214, 17);
            this.author_Label.TabIndex = 12;
            this.author_Label.Text = "Diseñado por Rebeca Alvarenga";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 225);
            this.Controls.Add(this.author_Label);
            this.Controls.Add(this.position_Combo);
            this.Controls.Add(this.calculate_Button);
            this.Controls.Add(this.position_Label);
            this.Controls.Add(this.salary_Box);
            this.Controls.Add(this.salary_Label);
            this.Controls.Add(this.name_Box);
            this.Controls.Add(this.name_Label);
            this.Controls.Add(this.appName_Label);
            this.Name = "Form1";
            this.Text = "Salarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appName_Label;
        private System.Windows.Forms.Label name_Label;
        private System.Windows.Forms.TextBox name_Box;
        private System.Windows.Forms.TextBox salary_Box;
        private System.Windows.Forms.Label salary_Label;
        private System.Windows.Forms.Label position_Label;
        private System.Windows.Forms.Button calculate_Button;
        private System.Windows.Forms.ComboBox position_Combo;
        private System.Windows.Forms.Label author_Label;
    }
}

