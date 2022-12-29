namespace CarritoCompras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboxProducto.Items.Add("pantalon");
            cboxProducto.Items.Add("camisa");
            cboxProducto.Items.Add("zapatos");
        }
    }
}