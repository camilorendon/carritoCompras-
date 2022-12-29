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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string productoSelecionado = cboxProducto.SelectedItem.ToString();
            listCarritoDeCompras.Items.Add(productoSelecionado);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            /*
                pantalon 20
                camisa 35
                zapatos 24
             */
            double precioFinal = 0;
            int productosCargados = listCarritoDeCompras.Items.Count;
            for (int i = 0; i < productosCargados; i++)
            {
                string productoElegido = listCarritoDeCompras.Items[i].ToString();
                if (productoElegido == "pantalon")
                {
                    precioFinal += 20;
                }
                else if (productoElegido == "camisa")
                {
                 precioFinal += 35;
                }
                if (productoElegido == "zapatos")
                {
                    precioFinal += 24;
                }
            }
            if(txtCodigoDescuento.Text == "NAVIDAD")
            {
                precioFinal = precioFinal * 0.9;

            }
            MessageBox.Show("el precio final es: $" + precioFinal);
        }
    }
}