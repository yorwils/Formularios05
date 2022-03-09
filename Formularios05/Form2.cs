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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string[] programas = { "Computacion", "Contabilidad", "Cocina" };
            for (int i = 0; i < programas.Length; i++)
            {
                cbxPrograma.Items.Add(programas[i]);
            }
        }

        private void cbxPrograma_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cbxPrograma.SelectedIndex + " " + cbxPrograma.SelectedItem);
            String[] cursoComputacion = { "excel", "windows", "paginas web" };
            if (cbxPrograma.SelectedIndex==0)
            {
                for (int i = 0; i < cursoComputacion.Length; i++)
                {
                    cbxCurso.Items.Add(cursoComputacion[i]);
                }
            }
            string[] cursoContabilidad = { "gestion de costo ", "gestion de logica", "control interno" };
            if (cbxPrograma.SelectedIndex==1)
            {
                for (int j = 0; j < cursoContabilidad.Length; j++)
                {
                    cbxCurso.Items.Add(cursoContabilidad[j]);
                }
            }
            string[] cursoCocina = { "gastronimia", "bartender", "panaderia" };
            if (cbxPrograma.SelectedIndex==2)
            {
                for (int k = 0; k < cursoCocina.Length; k++)
                {
                    cbxCurso.Items.Add(cursoCocina[k]);
                }
            }
        }
    }
}
