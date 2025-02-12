using System.IO;
namespace Editor_De_Texto
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        bool archivoGuardado = false;
        string filepath;
        public void Guardar()
        {
            DialogResult Resultado;
            if (archivoGuardado == false)
            {
                Resultado = saveFileDialogEditor.ShowDialog();
                if (Resultado == DialogResult.OK)
                {
                    filepath = saveFileDialogEditor.FileName;
                    string texto = rtbEditor.Text;
                    try
                    {
                        File.WriteAllText(filepath, texto);
                        MessageBox.Show("Archivo Guardado correctamente");
                        archivoGuardado |= true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al Guardar el Arcivo " + ex.Message);
                    }
                }
            }
            else
            {
                try
                {
                    string texto = rtbEditor.Text;

                    File.WriteAllText(filepath, texto);
                    MessageBox.Show("Archivo Guardado correctamente");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al Guardar el Arcivo " + ex.Message);
                }
            }

        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = openFileDialogEditor.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                filepath = openFileDialogEditor.FileName;
                try
                {
                    string texto = File.ReadAllText(filepath);
                    rtbEditor.Text = texto;
                    archivoGuardado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el Arcivo " + ex.Message);
                }
            }

        }
        
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Resultado;
            if (archivoGuardado == false)
            {
                Resultado = saveFileDialogEditor.ShowDialog();
                if (Resultado == DialogResult.OK)
                {
                    filepath = saveFileDialogEditor.FileName;
                    string texto = rtbEditor.Text;
                    try
                    {
                        File.WriteAllText(filepath, texto);
                        MessageBox.Show("Archivo Guardado correctamente");
                        archivoGuardado |= true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al Guardar el Arcivo " + ex.Message);
                    }
                }
            }
            else
            {
                try
                {
                    string texto = rtbEditor.Text;

                    File.WriteAllText(filepath, texto);
                    MessageBox.Show("Archivo Guardado correctamente");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al Guardar el Arcivo " + ex.Message);
                }
            }

        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Resultado;
            Resultado = saveFileDialogEditor.ShowDialog();
            if (Resultado == DialogResult.OK)
            {
                filepath = saveFileDialogEditor.FileName;
                string texto = rtbEditor.Text;
                try
                {
                    File.WriteAllText(filepath, texto);
                    MessageBox.Show("Archivo Guardado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al Guardar el Arcivo " + ex.Message);
                }
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseas Guardar antes de crear un nuevo archivo?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                rtbEditor.Clear();
            }
            else if(res == DialogResult.Yes) 
            {
                Guardar();
                MessageBox.Show("Se guardaron los cambios");
                rtbEditor.Clear();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DialogResult res = MessageBox.Show("Deseas salir?", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                DialogResult reguardar = MessageBox.Show("Deseas Guardar los cambios antes de salir?","Sistema", MessageBoxButtons.OKCancel,MessageBoxIcon.Question );
                if(reguardar == DialogResult.OK)
                {
                    Guardar();
                    MessageBox.Show("Se guardaron los cambios");
                    this.Close();
                }
                else if(reguardar == DialogResult.Cancel)
                {
                    MessageBox.Show("No se guardaron los cambios");
                    this.Close();
                }
                
            }
          
        }
    }
}
