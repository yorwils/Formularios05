using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxEjercicios.Items.Add(5 > 5);
            cbxEjercicios.Items.Add("lunes");
            cbxEjercicios.Items.Add("Martes");
            cbxEjercicios.Items.Add("Miercoles");
            cbxEjercicios.Items.Add("Jueves");
            cbxEjercicios.Items.Add("Viernes");
            cbxEjercicios.Items.Add(5+5);

        }

        private void cbxEjercicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxEjercicios.Items.Remove("lunes");
            cbxEjercicios.Items.RemoveAt(5 + 5);
            if (cbxEjercicios.SelectedItem != null)

            {
                MessageBox.Show(cbxEjercicios.SelectedItem.ToString());

            }

            if (cbxEjercicios.SelectedIndex!= -1)

            {
                MessageBox.Show(cbxEjercicios.SelectedItem.ToString());

            }
        }
    }
}
