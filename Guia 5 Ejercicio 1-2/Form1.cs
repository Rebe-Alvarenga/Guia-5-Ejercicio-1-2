using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_5_Ejercicio_1_2
{
    public partial class Form1 : Form
    {
        string name, salary_string, position = "Gerente";
        double salary, discount, total;

        private void calculate_Button_Click(object sender, EventArgs e)
        {
            if (position == "Gerente")
            {
                discount = salary * 0.2;
                total = salary - discount;
            } 
            else if (position == "Subgerente")
            {
                discount = salary * 0.15;
                total = salary - discount;
            }
            else if (position == "Secretaria")
            {
                discount = salary * 0.05;
                total = salary - discount;
            }

            string message_Text1 = "Nombre del empleado: " + name + "\nSalario base ingresado: USD$ " + salary;
            string message_Text2 = "\nDescuento: USD$ " + discount + "\nSalario neto: USD$ " + total;
            MessageBox.Show(message_Text1 + message_Text2, "Informacion sobre salario de empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void position_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            position = position_Combo.Text;
        }

        private void salary_Box_TextChanged(object sender, EventArgs e)
        {
            salary_string = salary_Box.Text;
            try
            {
                salary = double.Parse(salary_string);
            }
            catch
            {
                MessageBox.Show("Solo se admiten valores numericos con decimales", "Ocurrio un error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void author_Label_Click(object sender, EventArgs e)
        {

        }

        private void name_Box_TextChanged(object sender, EventArgs e)
        {
            name = name_Box.Text;
        }
    }
}
