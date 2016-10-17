namespace JBF.EditorEstilado
{
    partial class frmBloc
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBloc));
            this.barraMenu = new System.Windows.Forms.MenuStrip();
            this.barraMenuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionMenuNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.opcionMenuAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.opcionMenuGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionMenuGuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.opcionMenuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.barraMenuEdicion = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionMenuDeshacer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.opcionMenuCortar = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionMenuCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionMenuPegar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.opcionMenuSeleccionarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.estiloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coloresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.negritaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursivaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraMenuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionMenuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.opcionMenuAcerca = new System.Windows.Forms.ToolStripMenuItem();
            this.abreArchivos = new System.Windows.Forms.OpenFileDialog();
            this.guardaArchivos = new System.Windows.Forms.SaveFileDialog();
            this.barraDeEstado = new System.Windows.Forms.StatusStrip();
            this.lblEstadisticas = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblModificacion = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtArchivo = new System.Windows.Forms.RichTextBox();
            this.menuContexual = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuContextualDeshacer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.menuContextualCortar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContextualCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContextualPegar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.menuContextualSeleccionarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.fuentes = new System.Windows.Forms.FontDialog();
            this.colores = new System.Windows.Forms.ColorDialog();
            this.ayudador = new System.Windows.Forms.HelpProvider();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.ajusteDeLíneaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraMenu.SuspendLayout();
            this.barraDeEstado.SuspendLayout();
            this.menuContexual.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraMenu
            // 
            this.barraMenu.AutoSize = false;
            this.barraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barraMenuArchivo,
            this.barraMenuEdicion,
            this.estiloToolStripMenuItem,
            this.barraMenuAyuda});
            this.barraMenu.Location = new System.Drawing.Point(0, 0);
            this.barraMenu.Name = "barraMenu";
            this.barraMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.barraMenu.Size = new System.Drawing.Size(594, 24);
            this.barraMenu.TabIndex = 1;
            this.barraMenu.Text = "menuStrip1";
            // 
            // barraMenuArchivo
            // 
            this.barraMenuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionMenuNuevo,
            this.toolStripSeparator3,
            this.opcionMenuAbrir,
            this.toolStripSeparator1,
            this.opcionMenuGuardar,
            this.opcionMenuGuardarComo,
            this.toolStripSeparator2,
            this.opcionMenuSalir});
            this.barraMenuArchivo.Name = "barraMenuArchivo";
            this.barraMenuArchivo.Size = new System.Drawing.Size(60, 20);
            this.barraMenuArchivo.Text = "&Archivo";
            // 
            // opcionMenuNuevo
            // 
            this.opcionMenuNuevo.Image = global::JBF.EditorEstilado.Properties.Resources.document_new;
            this.opcionMenuNuevo.Name = "opcionMenuNuevo";
            this.opcionMenuNuevo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.opcionMenuNuevo.Size = new System.Drawing.Size(158, 22);
            this.opcionMenuNuevo.Text = "&Nuevo";
            this.opcionMenuNuevo.Click += new System.EventHandler(this.opcionMenuNuevo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(155, 6);
            // 
            // opcionMenuAbrir
            // 
            this.opcionMenuAbrir.Image = global::JBF.EditorEstilado.Properties.Resources.document_open;
            this.opcionMenuAbrir.Name = "opcionMenuAbrir";
            this.opcionMenuAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.opcionMenuAbrir.Size = new System.Drawing.Size(158, 22);
            this.opcionMenuAbrir.Text = "&Abrir";
            this.opcionMenuAbrir.Click += new System.EventHandler(this.opcionMenuAbrir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // opcionMenuGuardar
            // 
            this.opcionMenuGuardar.Image = global::JBF.EditorEstilado.Properties.Resources.document_save;
            this.opcionMenuGuardar.Name = "opcionMenuGuardar";
            this.opcionMenuGuardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.opcionMenuGuardar.Size = new System.Drawing.Size(158, 22);
            this.opcionMenuGuardar.Text = "&Guardar";
            this.opcionMenuGuardar.Click += new System.EventHandler(this.opcionMenuGuardar_Click);
            // 
            // opcionMenuGuardarComo
            // 
            this.opcionMenuGuardarComo.Image = global::JBF.EditorEstilado.Properties.Resources.document_save_as;
            this.opcionMenuGuardarComo.Name = "opcionMenuGuardarComo";
            this.opcionMenuGuardarComo.Size = new System.Drawing.Size(158, 22);
            this.opcionMenuGuardarComo.Text = "Guardar c&omo";
            this.opcionMenuGuardarComo.Click += new System.EventHandler(this.opcionMenuGuardarComo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(155, 6);
            // 
            // opcionMenuSalir
            // 
            this.opcionMenuSalir.Image = global::JBF.EditorEstilado.Properties.Resources.document_quit;
            this.opcionMenuSalir.Name = "opcionMenuSalir";
            this.opcionMenuSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.opcionMenuSalir.Size = new System.Drawing.Size(158, 22);
            this.opcionMenuSalir.Text = "&Salir";
            this.opcionMenuSalir.Click += new System.EventHandler(this.opcionMenuSalir_Click);
            // 
            // barraMenuEdicion
            // 
            this.barraMenuEdicion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionMenuDeshacer,
            this.toolStripSeparator5,
            this.opcionMenuCortar,
            this.opcionMenuCopiar,
            this.opcionMenuPegar,
            this.toolStripSeparator6,
            this.opcionMenuSeleccionarTodo,
            this.toolStripSeparator9,
            this.ajusteDeLíneaToolStripMenuItem});
            this.barraMenuEdicion.Name = "barraMenuEdicion";
            this.barraMenuEdicion.Size = new System.Drawing.Size(58, 20);
            this.barraMenuEdicion.Text = "&Edición";
            // 
            // opcionMenuDeshacer
            // 
            this.opcionMenuDeshacer.Image = global::JBF.EditorEstilado.Properties.Resources.edit_undo;
            this.opcionMenuDeshacer.Name = "opcionMenuDeshacer";
            this.opcionMenuDeshacer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.opcionMenuDeshacer.Size = new System.Drawing.Size(202, 22);
            this.opcionMenuDeshacer.Text = "&Deshacer";
            this.opcionMenuDeshacer.Click += new System.EventHandler(this.opcionMenuDeshacer_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(199, 6);
            // 
            // opcionMenuCortar
            // 
            this.opcionMenuCortar.Image = global::JBF.EditorEstilado.Properties.Resources.edit_cut;
            this.opcionMenuCortar.Name = "opcionMenuCortar";
            this.opcionMenuCortar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.opcionMenuCortar.Size = new System.Drawing.Size(202, 22);
            this.opcionMenuCortar.Text = "&Cortar";
            this.opcionMenuCortar.Click += new System.EventHandler(this.opcionMenuCortar_Click);
            // 
            // opcionMenuCopiar
            // 
            this.opcionMenuCopiar.Image = global::JBF.EditorEstilado.Properties.Resources.edit_copy;
            this.opcionMenuCopiar.Name = "opcionMenuCopiar";
            this.opcionMenuCopiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.opcionMenuCopiar.Size = new System.Drawing.Size(202, 22);
            this.opcionMenuCopiar.Text = "C&opiar";
            this.opcionMenuCopiar.Click += new System.EventHandler(this.opcionMenuCopiar_Click);
            // 
            // opcionMenuPegar
            // 
            this.opcionMenuPegar.Image = global::JBF.EditorEstilado.Properties.Resources.edit_paste;
            this.opcionMenuPegar.Name = "opcionMenuPegar";
            this.opcionMenuPegar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.opcionMenuPegar.Size = new System.Drawing.Size(202, 22);
            this.opcionMenuPegar.Text = "&Pegar";
            this.opcionMenuPegar.Click += new System.EventHandler(this.opcionMenuPegar_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(199, 6);
            // 
            // opcionMenuSeleccionarTodo
            // 
            this.opcionMenuSeleccionarTodo.Image = global::JBF.EditorEstilado.Properties.Resources.edit_select_all;
            this.opcionMenuSeleccionarTodo.Name = "opcionMenuSeleccionarTodo";
            this.opcionMenuSeleccionarTodo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.opcionMenuSeleccionarTodo.Size = new System.Drawing.Size(202, 22);
            this.opcionMenuSeleccionarTodo.Text = "&Seleccionar todo";
            this.opcionMenuSeleccionarTodo.Click += new System.EventHandler(this.opcionMenuSeleccionarTodo_Click);
            // 
            // estiloToolStripMenuItem
            // 
            this.estiloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fuentesToolStripMenuItem,
            this.coloresToolStripMenuItem,
            this.toolStripMenuItem1,
            this.negritaToolStripMenuItem,
            this.cursivaToolStripMenuItem});
            this.estiloToolStripMenuItem.Name = "estiloToolStripMenuItem";
            this.estiloToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.estiloToolStripMenuItem.Text = "E&stilo";
            // 
            // fuentesToolStripMenuItem
            // 
            this.fuentesToolStripMenuItem.Image = global::JBF.EditorEstilado.Properties.Resources.font_x_generic;
            this.fuentesToolStripMenuItem.Name = "fuentesToolStripMenuItem";
            this.fuentesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.fuentesToolStripMenuItem.Text = "&Fuentes";
            this.fuentesToolStripMenuItem.Click += new System.EventHandler(this.fuentesToolStripMenuItem_Click);
            // 
            // coloresToolStripMenuItem
            // 
            this.coloresToolStripMenuItem.Image = global::JBF.EditorEstilado.Properties.Resources.colorwheel;
            this.coloresToolStripMenuItem.Name = "coloresToolStripMenuItem";
            this.coloresToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.coloresToolStripMenuItem.Text = "&Colores";
            this.coloresToolStripMenuItem.Click += new System.EventHandler(this.coloresToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(151, 6);
            // 
            // negritaToolStripMenuItem
            // 
            this.negritaToolStripMenuItem.Image = global::JBF.EditorEstilado.Properties.Resources.format_text_bold;
            this.negritaToolStripMenuItem.Name = "negritaToolStripMenuItem";
            this.negritaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.negritaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.negritaToolStripMenuItem.Text = "&Negrita";
            this.negritaToolStripMenuItem.Click += new System.EventHandler(this.negritaToolStripMenuItem_Click);
            // 
            // cursivaToolStripMenuItem
            // 
            this.cursivaToolStripMenuItem.Image = global::JBF.EditorEstilado.Properties.Resources.format_text_italic;
            this.cursivaToolStripMenuItem.Name = "cursivaToolStripMenuItem";
            this.cursivaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.cursivaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.cursivaToolStripMenuItem.Text = "C&ursiva";
            this.cursivaToolStripMenuItem.Click += new System.EventHandler(this.cursivaToolStripMenuItem_Click);
            // 
            // barraMenuAyuda
            // 
            this.barraMenuAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionMenuAyuda,
            this.toolStripSeparator4,
            this.opcionMenuAcerca});
            this.barraMenuAyuda.Name = "barraMenuAyuda";
            this.barraMenuAyuda.Size = new System.Drawing.Size(53, 20);
            this.barraMenuAyuda.Text = "Ay&uda";
            // 
            // opcionMenuAyuda
            // 
            this.opcionMenuAyuda.Image = global::JBF.EditorEstilado.Properties.Resources.help_browser;
            this.opcionMenuAyuda.Name = "opcionMenuAyuda";
            this.opcionMenuAyuda.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.opcionMenuAyuda.Size = new System.Drawing.Size(152, 22);
            this.opcionMenuAyuda.Text = "&Ayuda";
            this.opcionMenuAyuda.Click += new System.EventHandler(this.opcionMenuAyuda_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // opcionMenuAcerca
            // 
            this.opcionMenuAcerca.Name = "opcionMenuAcerca";
            this.opcionMenuAcerca.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.opcionMenuAcerca.Size = new System.Drawing.Size(152, 22);
            this.opcionMenuAcerca.Text = "A&cerca de";
            this.opcionMenuAcerca.Click += new System.EventHandler(this.opcionMenuAcerca_Click);
            // 
            // abreArchivos
            // 
            this.abreArchivos.Filter = "Archivos Estilados|*.rtf|Archivos de texto|*.txt|Archivos de galletas|*.cki|Todos" +
    " los archivos|*.*";
            // 
            // guardaArchivos
            // 
            this.guardaArchivos.FileName = "MiArchivo";
            this.guardaArchivos.Filter = "Archivos Estilados|*.rtf|Archivos de texto|*.txt|Archivos de galletas|*.cki|Todos" +
    " los archivos|*.*";
            // 
            // barraDeEstado
            // 
            this.barraDeEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstadisticas,
            this.lblModificacion});
            this.barraDeEstado.Location = new System.Drawing.Point(0, 393);
            this.barraDeEstado.Name = "barraDeEstado";
            this.barraDeEstado.Size = new System.Drawing.Size(594, 22);
            this.barraDeEstado.TabIndex = 2;
            this.barraDeEstado.Text = "statusStrip1";
            // 
            // lblEstadisticas
            // 
            this.lblEstadisticas.Name = "lblEstadisticas";
            this.lblEstadisticas.Size = new System.Drawing.Size(125, 17);
            this.lblEstadisticas.Text = "Carácteres: 0, Líneas: 0";
            // 
            // lblModificacion
            // 
            this.lblModificacion.Name = "lblModificacion";
            this.lblModificacion.Size = new System.Drawing.Size(74, 17);
            this.lblModificacion.Text = "| Modificado";
            this.lblModificacion.Visible = false;
            // 
            // txtArchivo
            // 
            this.txtArchivo.AcceptsTab = true;
            this.txtArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArchivo.ContextMenuStrip = this.menuContexual;
            this.txtArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArchivo.Location = new System.Drawing.Point(0, 24);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(594, 370);
            this.txtArchivo.TabIndex = 3;
            this.txtArchivo.Text = "";
            this.txtArchivo.TextChanged += new System.EventHandler(this.txtArchivo_TextChanged);
            // 
            // menuContexual
            // 
            this.menuContexual.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuContextualDeshacer,
            this.toolStripSeparator7,
            this.menuContextualCortar,
            this.menuContextualCopiar,
            this.menuContextualPegar,
            this.toolStripSeparator8,
            this.menuContextualSeleccionarTodo});
            this.menuContexual.Name = "menuContexual";
            this.menuContexual.Size = new System.Drawing.Size(203, 126);
            // 
            // menuContextualDeshacer
            // 
            this.menuContextualDeshacer.Image = global::JBF.EditorEstilado.Properties.Resources.edit_undo;
            this.menuContextualDeshacer.Name = "menuContextualDeshacer";
            this.menuContextualDeshacer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.menuContextualDeshacer.Size = new System.Drawing.Size(202, 22);
            this.menuContextualDeshacer.Text = "Deshacer";
            this.menuContextualDeshacer.Click += new System.EventHandler(this.opcionMenuDeshacer_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(199, 6);
            // 
            // menuContextualCortar
            // 
            this.menuContextualCortar.Image = global::JBF.EditorEstilado.Properties.Resources.edit_cut;
            this.menuContextualCortar.Name = "menuContextualCortar";
            this.menuContextualCortar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuContextualCortar.Size = new System.Drawing.Size(202, 22);
            this.menuContextualCortar.Text = "Cortar";
            this.menuContextualCortar.Click += new System.EventHandler(this.opcionMenuCortar_Click);
            // 
            // menuContextualCopiar
            // 
            this.menuContextualCopiar.Image = global::JBF.EditorEstilado.Properties.Resources.edit_copy;
            this.menuContextualCopiar.Name = "menuContextualCopiar";
            this.menuContextualCopiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuContextualCopiar.Size = new System.Drawing.Size(202, 22);
            this.menuContextualCopiar.Text = "Copiar";
            this.menuContextualCopiar.Click += new System.EventHandler(this.opcionMenuCopiar_Click);
            // 
            // menuContextualPegar
            // 
            this.menuContextualPegar.Image = global::JBF.EditorEstilado.Properties.Resources.edit_paste;
            this.menuContextualPegar.Name = "menuContextualPegar";
            this.menuContextualPegar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuContextualPegar.Size = new System.Drawing.Size(202, 22);
            this.menuContextualPegar.Text = "Pegar";
            this.menuContextualPegar.Click += new System.EventHandler(this.opcionMenuPegar_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(199, 6);
            // 
            // menuContextualSeleccionarTodo
            // 
            this.menuContextualSeleccionarTodo.Image = global::JBF.EditorEstilado.Properties.Resources.edit_select_all;
            this.menuContextualSeleccionarTodo.Name = "menuContextualSeleccionarTodo";
            this.menuContextualSeleccionarTodo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.menuContextualSeleccionarTodo.Size = new System.Drawing.Size(202, 22);
            this.menuContextualSeleccionarTodo.Text = "Seleccionar todo";
            this.menuContextualSeleccionarTodo.Click += new System.EventHandler(this.opcionMenuSeleccionarTodo_Click);
            // 
            // ayudador
            // 
            this.ayudador.HelpNamespace = ".\\EditorEstilado.chm";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(199, 6);
            // 
            // ajusteDeLíneaToolStripMenuItem
            // 
            this.ajusteDeLíneaToolStripMenuItem.Name = "ajusteDeLíneaToolStripMenuItem";
            this.ajusteDeLíneaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.ajusteDeLíneaToolStripMenuItem.Text = "Ajuste de línea";
            this.ajusteDeLíneaToolStripMenuItem.Click += new System.EventHandler(this.ajusteDeLíneaToolStripMenuItem_Click);
            // 
            // frmBloc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 415);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.barraDeEstado);
            this.Controls.Add(this.barraMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBloc";
            this.Text = "Editor Estilado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBloc_FormClosing);
            this.Load += new System.EventHandler(this.frmBloc_Load);
            this.barraMenu.ResumeLayout(false);
            this.barraMenu.PerformLayout();
            this.barraDeEstado.ResumeLayout(false);
            this.barraDeEstado.PerformLayout();
            this.menuContexual.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip barraMenu;
        private System.Windows.Forms.ToolStripMenuItem barraMenuArchivo;
        private System.Windows.Forms.ToolStripMenuItem opcionMenuAbrir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem opcionMenuGuardar;
        private System.Windows.Forms.ToolStripMenuItem opcionMenuGuardarComo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem opcionMenuSalir;
        private System.Windows.Forms.ToolStripMenuItem opcionMenuNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.OpenFileDialog abreArchivos;
        private System.Windows.Forms.SaveFileDialog guardaArchivos;
        private System.Windows.Forms.ToolStripMenuItem barraMenuAyuda;
        private System.Windows.Forms.ToolStripMenuItem opcionMenuAcerca;
        private System.Windows.Forms.ToolStripMenuItem opcionMenuAyuda;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem barraMenuEdicion;
        private System.Windows.Forms.ToolStripMenuItem opcionMenuDeshacer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem opcionMenuCortar;
        private System.Windows.Forms.ToolStripMenuItem opcionMenuCopiar;
        private System.Windows.Forms.ToolStripMenuItem opcionMenuPegar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem opcionMenuSeleccionarTodo;
        private System.Windows.Forms.StatusStrip barraDeEstado;
        private System.Windows.Forms.ToolStripStatusLabel lblEstadisticas;
        private System.Windows.Forms.ToolStripStatusLabel lblModificacion;
        private System.Windows.Forms.RichTextBox txtArchivo;
        private System.Windows.Forms.ToolStripMenuItem estiloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuentesToolStripMenuItem;
        private System.Windows.Forms.FontDialog fuentes;
        private System.Windows.Forms.ToolStripMenuItem coloresToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colores;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem negritaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursivaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip menuContexual;
        private System.Windows.Forms.ToolStripMenuItem menuContextualDeshacer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem menuContextualCortar;
        private System.Windows.Forms.ToolStripMenuItem menuContextualCopiar;
        private System.Windows.Forms.ToolStripMenuItem menuContextualPegar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem menuContextualSeleccionarTodo;
        private System.Windows.Forms.HelpProvider ayudador;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem ajusteDeLíneaToolStripMenuItem;
    }
}

