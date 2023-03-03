namespace Sueldos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Sueldo = 0;
            txtResultEmpleado.Text = txtEmpleado.Text;
            txtResultLaborado.Text = udLaborado.Text;
            txtResultCategoria.Text = cmbCategoria.Text;

            if (cmbCategoria.Text.Equals("A"))
                Sueldo = 3000 + (30 * Convert.ToInt32(udLaborado.Text));
            else if (cmbCategoria.Text.Equals("B"))
                Sueldo = 2500 + (30 * Convert.ToInt32(udLaborado.Text));
            txtResultSueldo.Text = " " + Sueldo;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}