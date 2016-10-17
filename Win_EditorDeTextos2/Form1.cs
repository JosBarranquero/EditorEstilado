/*---------------------------------------------------------------------------------------
 *    Nombre: Editor Estilado
 *     Autor: José Antonio Barranquero
 *   Versión: 1.1.5
 *     Fecha: 3/3/2016 - 9/5/2016
 *Comentario: Editor de textos
 *-----------------------------------------------------------------------------------*/

using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
//-----------------------------------
using System.IO;

namespace JBF.EditorEstilado
{
    public partial class frmBloc : Form
    {
        #region Campos
        string ruta = null;
        string nombrePrograma = "Editor Estilado";
        bool txtCambiado = false;   // Booleano para saber si se ha realizado algún cambio al texto
        FileStream flujo = null;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor vacío, comienza el programa con un archivo nuevo
        /// </summary>
        public frmBloc()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor sobrecargado, que iniciará el programa con el archivo de la ruta
        /// </summary>
        /// <param name="ruta">Ruta del archivo a cargar</param>
        public frmBloc(string ruta)
        {
            this.ruta = ruta;
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void frmBloc_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void frmBloc_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult salida;
            if (txtCambiado)
            {
                salida = MessageBox.Show("¿Quieres guardar el archivo antes de salir?\nLos cambios no guardados se perderán", "Antes de salir...", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (salida == DialogResult.Cancel)
                    e.Cancel = true;
                if (salida == DialogResult.Yes)
                    opcionMenuGuardar_Click(sender, e);
            }
        }

        private void txtArchivo_TextChanged(object sender, EventArgs e)
        {
            txtCambiado = true;     // Se ha cambiado el contenido del texto
            lblEstadisticas.Text = "Carácteres: " + txtArchivo.Text.Length + ",  Líneas: " + txtArchivo.Lines.Count();
            lblModificacion.Visible = true;
        }
        #endregion

        #region Menus
        #region MenuArchivo
        private void opcionMenuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void opcionMenuNuevo_Click(object sender, EventArgs e)
        {
            if (txtCambiado)
            {
                if (MessageBox.Show("Los cambios no guardados se perderán.\n¿Deseas continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    Nuevo();
            }
            else
                Nuevo();
        }

        private void opcionMenuAbrir_Click(object sender, EventArgs e)
        {
            if (txtCambiado)
            {
                if (MessageBox.Show("Los cambios no guardados se perderán.\n¿Deseas continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    if (abreArchivos.ShowDialog() == DialogResult.OK)
                    {
                        ruta = abreArchivos.FileName;
                        Cargar();
                    }
            }
            else
            {
                if (abreArchivos.ShowDialog() == DialogResult.OK)
                {
                    ruta = abreArchivos.FileName;
                    Cargar();
                }
            }
        }

        private void opcionMenuGuardar_Click(object sender, EventArgs e)
        {
            if (ruta == null)
                opcionMenuGuardarComo_Click(sender, e);
            else
                Guardar();
        }

        private void opcionMenuGuardarComo_Click(object sender, EventArgs e)
        {
            if (guardaArchivos.ShowDialog() == DialogResult.OK)
            {
                ruta = guardaArchivos.FileName;
                Guardar();
            }
        }
        #endregion

        #region MenuAyuda
        private void opcionMenuAcerca_Click(object sender, EventArgs e)
        {
            AboutBox1 acerca = new AboutBox1();
            acerca.ShowDialog();
        }

        private void opcionMenuAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, ayudador.HelpNamespace);
        }
        #endregion

        #region MenuEstilo
        private void fuentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fuentes.Font = txtArchivo.SelectionFont;
            if (fuentes.ShowDialog() == DialogResult.OK)
            {
                txtArchivo.SelectionFont = fuentes.Font;
                negritaToolStripMenuItem.Checked = false;
                cursivaToolStripMenuItem.Checked = false;
            }
        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colores.Color = txtArchivo.SelectionColor;
            if (colores.ShowDialog() == DialogResult.OK)
            {
                txtArchivo.SelectionColor = colores.Color;
                negritaToolStripMenuItem.Checked = false;
                cursivaToolStripMenuItem.Checked = false;
            }
        }

        private void negritaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                negritaToolStripMenuItem.Checked = !negritaToolStripMenuItem.Checked;
                Estilo();
            }
            catch
            {
                return;
            }
        }

        private void cursivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                cursivaToolStripMenuItem.Checked = !cursivaToolStripMenuItem.Checked;
                Estilo();
            }
            catch
            {
                return;
            }
        }
        #endregion

        #region MenuEdicion
        private void opcionMenuDeshacer_Click(object sender, EventArgs e)
        {
            try
            {
                txtArchivo.Undo();
            }
            catch
            {
                return;
            }
        }

        private void opcionMenuCortar_Click(object sender, EventArgs e)
        {
            try
            {
                txtArchivo.Cut();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void opcionMenuPegar_Click(object sender, EventArgs e)
        {
            try
            {
                txtArchivo.Paste();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void opcionMenuCopiar_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txtArchivo.SelectedText);
            }
            catch
            {
                return;
            }
        }

        private void opcionMenuSeleccionarTodo_Click(object sender, EventArgs e)
        {
            txtArchivo.SelectAll();
        }

        private void ajusteDeLíneaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtArchivo.WordWrap = !txtArchivo.WordWrap;
        }
        #endregion
        #endregion

        #region Metodos
        #region MetodoCargar
        /// <summary>
        /// Carga el archivo del campo ruta
        /// </summary>
        /// <param name="r">Ruta, aunque no se usa</param>
        private void Cargar()
        {
            if (ruta != null)
            {
                try
                {
                    flujo = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                    txtArchivo.Clear();

                    if (Path.GetExtension(ruta) != ".rtf")
                    {
                        txtArchivo.LoadFile(flujo, RichTextBoxStreamType.PlainText);
                    }
                    else
                    {
                        txtArchivo.LoadFile(flujo, RichTextBoxStreamType.RichText);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    flujo.Close();
                    txtCambiado = false;    // El texto está intacto, ya que está recíén cargado
                    lblModificacion.Visible = false;
                    negritaToolStripMenuItem.Checked = false;
                    cursivaToolStripMenuItem.Checked = false;
                    this.Text = Path.GetFileName(ruta) + " - " + nombrePrograma;
                }
            }
        }
        #endregion

        #region MetodoNuevo
        /// <summary>
        /// Borra el campo de la ruta y vacia el área de escritura para poder crear un nuevo archivo
        /// </summary>
        private void Nuevo()
        {
            ruta = null;
            txtArchivo.Clear();
            txtCambiado = false;
            lblModificacion.Visible = false;
            cursivaToolStripMenuItem.Checked = false;
            negritaToolStripMenuItem.Checked = false;
            this.Text = nombrePrograma;
        }
        #endregion

        #region MetodoGuardar
        /// <summary>
        /// Guarda el archivo en la ruta especificada en el campo
        /// </summary>
        private void Guardar()
        {
            try
            {
                flujo = new FileStream(ruta, FileMode.Create, FileAccess.Write);
                if (Path.GetExtension(ruta) != ".rtf")
                {
                    txtArchivo.SaveFile(flujo, RichTextBoxStreamType.PlainText);
                }
                else
                {
                    txtArchivo.SaveFile(flujo, RichTextBoxStreamType.RichText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                flujo.Close();
                txtCambiado = false;    // Se acaba de guardar, así que el texto está intacto de nuevo
                lblModificacion.Visible = false;
                this.Text = Path.GetFileName(ruta) + " - " + nombrePrograma;
            }
        }
        #endregion

        #region MetodoEstilar
        /// <summary>
        /// Método encargado de aplicar los estilos a la fuente
        /// </summary>
        private void Estilo()
        {
            if (negritaToolStripMenuItem.Checked && cursivaToolStripMenuItem.Checked)   //las dos opciones puestas
                txtArchivo.SelectionFont = new Font(txtArchivo.SelectionFont, FontStyle.Bold | FontStyle.Italic);
            else if (negritaToolStripMenuItem.Checked && !cursivaToolStripMenuItem.Checked)     //Negrita
                txtArchivo.SelectionFont = new Font(txtArchivo.SelectionFont, FontStyle.Bold);
            else if (!negritaToolStripMenuItem.Checked && !cursivaToolStripMenuItem.Checked)    //las dos opciones quitadas
                txtArchivo.SelectionFont = new Font(txtArchivo.SelectionFont, FontStyle.Regular);
            else if (!negritaToolStripMenuItem.Checked && cursivaToolStripMenuItem.Checked)     //Cursiva
                txtArchivo.SelectionFont = new Font(txtArchivo.SelectionFont, FontStyle.Italic);
        }
        #endregion
        #endregion
    }
}
