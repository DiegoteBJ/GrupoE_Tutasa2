namespace GrupoE_Tutasa.EmitirFactura
{
    public partial class EmitirFacturaForm : Form
    {
        private EmisionFacturaModelo modelo = new();
        public EmitirFacturaForm()
        {
            InitializeComponent();
        }

        private void EmitirFacturaForm_Load(object sender, EventArgs e)
        {
            /*Todavia el formulario no esta visible. Hay que cargar los datos del modelo
              para que se muestren en el formulario*/

        }
    }
}
