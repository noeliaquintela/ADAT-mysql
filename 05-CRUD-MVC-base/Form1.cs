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
            if (dgvEmployees.Rows.Count > 0) 
                dgv2form(0);            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dgv2form (int indice)
        {
            if (indice >= 0 && dgvEmployees.Rows.Count > indice)
            {
                var row = dgvEmployees.Rows[indice];
                //insertar los datos del dgvb en los campos (textbox)
                txtID.Text = row.Cells["EmployeeID"].Value.ToString();
                txtName.Text = row.Cells["FirstName"].Value.ToString();
                txtLastName.Text = row.Cells["LastName"].Value.ToString();
                dtpBirthDate.Value = Convert.ToDateTime(row.Cells["BirthDate"].Value);
            }


        }
        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv2form(e.RowIndex);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("ID no válido");
                return;
            }
            int id = int.Parse(txtID.Text);

            if (controladorEmp.Delete(id))
                MessageBox.Show("Borrado correctamente");
            else
                MessageBox.Show("No se ho podido borrar");
            CargarDatos();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee
            {
                FirstName = txtName.Text,
                LastName = txtLastName.Text,
                BirthDate = dtpBirthDate.Value
            };
            if (controladorEmp.Insert(emp))
                MessageBox.Show("Inserción correcta");
            else
                MessageBox.Show("No se ho podido insertar");

            CargarDatos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("ID no válido");
                return;
            }

            Employee emp = new Employee
            {
                EmployeeID = int.Parse(txtID.Text),
                FirstName = txtName.Text,
                LastName = txtLastName.Text,
                BirthDate = dtpBirthDate.Value
            };
            if (controladorEmp.Update(emp))
                MessageBox.Show("Modificación correcta");
            else
                MessageBox.Show("No se ho podido modificar");

            CargarDatos();
        }
    }
}
