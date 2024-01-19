using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Limpieza_os390
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            listBoxFiles.Items.Clear();
            txtResultado.AppendText("Resultado"+Environment.NewLine);
        }

    


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listBoxFiles.Items.Clear();
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            //Obtenemos la lista de archivos
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            foreach (string archivo in archivos)
            {
                listBoxFiles.Items.Add(archivo);
            }
        
    }

        private void listBoxFiles_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
          
        }

        

        private void btn_procesar_Click(object sender, EventArgs e)
        {
            if (listBoxFiles.Items.Count == 0) {
                MessageBox.Show("No hay Elementos para procesar");
                return; }

            foreach (var item in listBoxFiles.Items)
            {
                AgregarLogs(LimpiarArchivo(item.ToString()));
            }

            MessageBox.Show("Accion finalizada");
            AgregarLogs("___Fin___");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void AgregarLogs(string estatus)
        {
            txtResultado.AppendText(estatus + Environment.NewLine);
        }


        private string LimpiarArchivo(string ruta)
        {
            try {

                var pattern = new Regex(@"\s+([A-Z]{2})\s+(\S+)\s+(.+?)\s+(\w+)\s+(\d+)\s+(\d+)\s+([0-9,.]+)\s+(\d+:\d+:\d+)");
                string[] cabeceras = { "Tipo", "Cuenta", "Nombre Cuenta", "Tipo OP", "Docto", "Autoriz", "Valor", "Hora" };

                using (StreamReader archivoEntrada = new StreamReader(ruta))
                using (StreamWriter archivoSalida = new StreamWriter(ruta + "R.txt"))
                {
                    archivoSalida.WriteLine(string.Join("|", cabeceras));
                    string linea;

                    while ((linea = archivoEntrada.ReadLine()) != null)
                    {
                        Match match = pattern.Match(linea);
                        if (match.Success)
                        {

                            string resultadoDeseado = string.Join("|", match.Groups.Cast<Group>().Skip(1).Select(g => g.Value));
                            archivoSalida.WriteLine(resultadoDeseado);
                        }
                    }

                }
                return  "_OK";


            }
            catch(Exception e) {
                return  "_Error";

            }

            
        }


    }
}
