using BLL;
using Entity;
using Entity.Model;
using Mapper;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private IngresoBusiness ingresoBusiness = new IngresoBusiness();
        private EmpresaBusiness empresaBusiness = new EmpresaBusiness();
        private List<IngresoEntity> listaIngresosBorrador = new List<IngresoEntity>();




        private void btnCrearIngreso_Click(object sender, EventArgs e)
        {
            try
            {
                IngresoEntity ingreso = new IngresoEntity();
                {
                    ingreso.CodigoDeBarra = txtCodigoBarra.Text;
                    ingreso.NombreInsumo = txtNombreInsumo.Text;
                    ingreso.Descripcion = txtDescripcion.Text;
                    ingreso.Empresa = empresaBusiness.GetById((int)Convert.ToInt16(txtIDEmpresa.Text));
                    ingreso.Cantidad = Convert.ToInt16(txtCantidad.Text);
                    ingreso.NombreEncargadoIngreso = txtNombreEncargado.Text;


                };

                ingresoBusiness.GenerarIngreso(ingreso);
                ActualizarGrilla();
                MessageBox.Show("Ingreso creado con exito");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }




        private void ActualizarGrilla()
        {
            try
            {
                dgvListaIngresos.DataSource = null;
                dgvListaIngresos.DataSource = ingresoBusiness.GetAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarBorrador_Click(object sender, EventArgs e)
        {
            try
            {
                IngresoEntity ingresoBorrador = new IngresoEntity();
                {
                    ingresoBorrador.CodigoDeBarra  = txtCodigoBarra.Text;
                    ingresoBorrador.NombreInsumo = txtNombreInsumo.Text;
                    ingresoBorrador.Descripcion = txtDescripcion.Text;
                    ingresoBorrador.Empresa = empresaBusiness.GetById((int)Convert.ToInt16(txtIDEmpresa.Text));
                    ingresoBorrador.Cantidad  = Convert.ToInt16(txtCantidad.Text);
                    ingresoBorrador.NombreEncargadoIngreso  = txtNombreEncargado.Text;
                  

                };

                listaIngresosBorrador.Add(ingresoBorrador);
                ActualizarGrilla();
                MessageBox.Show("Ingreso agregado al borrador");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaIngresosBorrador.Count <= 0)
                {
                    throw new Exception("No hay en la lista");
                }
                ingresoBusiness.crearMultiplesAplicaciones(listaIngresosBorrador);
                ActualizarGrilla();
                MessageBox.Show("Se cargaron correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                IngresoEntity ingresoModificada = new IngresoEntity();
                {
                    ingresoModificada.IdIngreso = Convert.ToInt32(txtIdIngreso.Text);
                    ingresoModificada.Cantidad = Convert.ToInt16(txtCantModificar.Text);
                };

                ingresoBusiness.ModificarIngreso(ingresoModificada);
                ActualizarGrilla();
                MessageBox.Show("Se modificó el ingreso correctamente");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ingresoBusiness.EliminarIngreso(Convert.ToInt32(txtIdAEliminar.Text));
                ActualizarGrilla();
                MessageBox.Show("Se eliminó El ingreso correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }
    }
}
