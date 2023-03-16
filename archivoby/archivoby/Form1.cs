using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace archivoby
{
    public partial class Form1 : Form
    {
        private List<Datos> listaDatos = new List<Datos>();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = listaDatos;
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open("datos.bin", FileMode.Create)))
            {
                int edad = int.Parse(EDD.Text);
                writer.Write(NOM.Text);
                writer.Write(edad);

                foreach (Datos datos in listaDatos)
                {
                    NOM.Text = datos.Nombre;
                    edad = datos.Edad;
                    writer.Write(datos.Nombre);
                    writer.Write(datos.Edad);
                }
                NOM.Clear();
                EDD.Clear();
            }
        }

        private void cargar_Click(object sender, EventArgs e)
        {
            listaDatos.Clear();

            using (BinaryReader reader = new BinaryReader(File.Open("datos.bin", FileMode.Open)))
            {
                while (reader.PeekChar() > -1)
                {
                    string nombre = reader.ReadString();
                    int edad = reader.ReadInt32();

                    listaDatos.Add(new Datos(nombre, edad));
                }
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaDatos;

        }
    }
}
