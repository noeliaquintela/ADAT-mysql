using _05_CRUD_MVC_base.Controllers;
using _05_CRUD_MVC_base.Models;


namespace _05_CRUD_MVC_base
{
    public partial class Form1 : Form
    {
        private readonly EmployeeController controladorEmp = new EmployeeController();
        public Form1()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            dgvEmployees.DataSource = null;
            dgvEmployees.DataSource = controladorEmp.GetAll();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvEmployees.Rows.Count > e.RowIndex)
            {
                var row = dgvEmployees.Rows[e.RowIndex];
                //insertar los datos del dgvb en los campos (textbox)
                txtID.Text = row.Cells["EmployeeID"].Value.ToString();
                //TODO: completar
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text)) {
                MessageBox.Show("ID no válido");
                return;
            }
            int id = int.Parse(txtID.Text);

            if (controladorEmp.Delete(id))
                MessageBox.Show("Borrado correctamente");
            else
                MessageBox.Show("No se ho podido borrar");

        }
    }
}
