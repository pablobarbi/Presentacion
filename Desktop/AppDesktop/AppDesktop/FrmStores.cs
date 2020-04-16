using AppDesktop.Dialog;
using AppDTO;
using AppService.Stores;
using System;
using System.Text;
using System.Windows.Forms;

namespace AppDesktop
{
    public partial class FrmStores : Form
    {
        public FrmStores()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToParent();
            LoadGrid();
            CtrlAllow(true);

        } 

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CtrlAllow(false);
            CleanTxt();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (ValidateCreate())
            {
                Save();
                CtrlAllow(true);
                CleanTxt();
                MessageBox.Show("Se agrego ó actualizo el registro correctamente.", "Mensage", MessageBoxButtons.OK);
            }

        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cancelo la operación.", "Mensage", MessageBoxButtons.OK);
            CtrlAllow(true);
            CleanTxt();

        }
         

        private void dgStore_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1)
                MessageBox.Show("Debe hacer click sobre la columna para seleccionar el registro", "Información", MessageBoxButtons.OK);


            if (dgStore.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                CtrlAllow(false);
                dgStore.CurrentRow.Selected = true;
                this.txtId.Text = dgStore.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                this.txtName.Text = dgStore.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                this.txtAddress.Text = dgStore.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtId.Text) || int.Parse(this.txtId.Text) < 0)
            {
                MessageBox.Show("Debe seleccionar el registro que desea eliminar.", "Validar", MessageBoxButtons.OK);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (ValidateCreate())
                {
                    Delete();
                    CtrlAllow(true);
                    CleanTxt();
                    MessageBox.Show("Se elimino correctamente el registgro.", "Mensage", MessageBoxButtons.OK);
                }
            }

        }
         
        #region Metodos Privados
        /// <summary>
        /// Metodo para limpiar los controles.
        /// </summary>
        private void CleanTxt()
        {
            this.txtId.Text = string.Empty;
            this.txtName.Text = string.Empty;
            this.txtAddress.Text = string.Empty;
        }
        /// <summary>
        /// Metodo para HGabilitar o Deshabilitar controles
        /// </summary>
        /// <param name="allow"></param>
        private void CtrlAllow(bool allow)
        {
            this.txtName.ReadOnly = allow;
            this.txtAddress.ReadOnly = allow;
            this.btnAceptar.Enabled = !allow;
            this.BtnCancelar.Enabled = !allow;
        }
        /// <summary>
        /// Metodo para agregar o actualizar un regitro
        /// </summary>
        private void Save()
        {
            var storesDto = new StoresDto()
            {
                Address = this.txtAddress.Text,
                Id = string.IsNullOrEmpty(this.txtId.Text) ? 0 : int.Parse(this.txtId.Text),
                Name = this.txtName.Text
            };
            StoresServices storesServices = new StoresServices();
            storesServices.Save(storesDto);
            LoadGrid();
        }
        /// <summary>
        /// Metodo para eliminar un registro
        /// </summary>

        private void Delete()
        {
            var storesDto = new StoresDto()
            {
                Address = this.txtAddress.Text,
                Id = int.Parse(this.txtId.Text),
                Name = this.txtName.Text
            };
            StoresServices storesServices = new StoresServices();
            storesServices.Delete(storesDto);
            LoadGrid();
        }
        /// <summary>
        /// Valida los datos cargados en el formulario
        /// </summary>
        /// <returns></returns>

        private bool ValidateCreate()
        {
            StringBuilder sb = new StringBuilder();
            bool isOK = true;
            if (string.IsNullOrEmpty(this.txtName.Text))
            {
                sb.Append("Name es requerido." + Environment.NewLine);
            }
            if (string.IsNullOrEmpty(this.txtAddress.Text))
            {
                sb.Append("Address es requerido.");
            }

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString(), "Validar", MessageBoxButtons.OK);
                isOK = false;
            }

            return isOK;
        }

        /// <summary>
        /// Metodo para cargar la grilla
        /// </summary>
        private void LoadGrid()
        {
            dgStore.DataSource = null;
            StoresServices storeService = new StoresServices();

            var result = storeService.GetAllAsync();

            //Set AutoGenerateColumns False
            dgStore.AutoGenerateColumns = false;

            //Set Columns Count
            dgStore.ColumnCount = 3;

            //Add Columns
            dgStore.Columns[0].Name = "Id";
            dgStore.Columns[0].HeaderText = "Id";
            dgStore.Columns[0].DataPropertyName = "Id";
            dgStore.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgStore.Columns[1].HeaderText = "Name";
            dgStore.Columns[1].Name = "Name";
            dgStore.Columns[1].DataPropertyName = "Name";
            dgStore.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgStore.Columns[2].Name = "Address";
            dgStore.Columns[2].HeaderText = "Address";
            dgStore.Columns[2].DataPropertyName = "Address";
            dgStore.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgStore.DataSource = result.stores;

        }
        #endregion

        
    }
}

