using AppDTO;
using AppService.Articles;
using AppService.Stores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDesktop
{
    public partial class FrmArticles : Form
    {
        public FrmArticles()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToParent();
            CtrlAllow(true);
            LoadGrid();
            LoadDropDownList();
        }

        private void txtTotalInShelf_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Helper.Helper.ValidateNumberOrDecimal(sender, e);
        }

        private void txtTotalInVault_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.Helper.ValidateNumberOrDecimal(sender, e);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.Helper.ValidateNumberOrDecimal(sender, e);
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CtrlAllow(false);
            CleanTxt();
            LoadDropDownList();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cancelo la operación.", "Mensage", MessageBoxButtons.OK);
            CtrlAllow(true);
            CleanTxt();
            LoadDropDownList();
        }

        private void dgArticles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1)
                MessageBox.Show("Debe hacer click sobre la columna para seleccionar el registro", "Información", MessageBoxButtons.OK);


            if (dgArticles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                CtrlAllow(false);
                dgArticles.CurrentRow.Selected = true;
                this.txtId.Text = dgArticles.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                this.txtName.Text = dgArticles.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                this.txtDescription.Text = dgArticles.Rows[e.RowIndex].Cells["Description"].FormattedValue.ToString();
                this.txtPrice.Text = dgArticles.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                this.txtTotalInShelf.Text = dgArticles.Rows[e.RowIndex].Cells["TotalInShelf"].FormattedValue.ToString();
                this.txtTotalInVault.Text = dgArticles.Rows[e.RowIndex].Cells["TotalInVault"].FormattedValue.ToString();
                var position = dgArticles.Rows[e.RowIndex].Cells["StoreId"].FormattedValue.ToString();
                LoadDropDownList(int.Parse(position));


            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtId.Text) || int.Parse(this.txtId.Text) < 0)
            {
                MessageBox.Show("Debe seleccionar el registro que desea eliminar.", "Validar", MessageBoxButtons.OK);
            }
            DialogResult dialogResult = MessageBox.Show("Desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (ValidateCreate())
                {
                    Delete();
                    CtrlAllow(true);
                    CleanTxt();
                }

                MessageBox.Show("Se elimino correctamente el registgro.", "Mensage", MessageBoxButtons.OK);
            }

        }


        #region Metodos Privados
        /// <summary>
        /// Metodo para limpiar los controles
        /// </summary>
        private void CleanTxt()
        {
            this.txtName.Text = string.Empty;
            this.txtPrice.Text = string.Empty;
            this.txtTotalInShelf.Text = string.Empty;
            this.txtTotalInVault.Text = string.Empty;
            this.txtDescription.Text = string.Empty;
        }
        /// <summary>
        /// Metodo para habilitar o deshabilitar un control
        /// </summary>
        /// <param name="allow">true o false dependiendo el caso</param>
        private void CtrlAllow(bool allow)
        {

            this.txtName.ReadOnly = allow;
            this.txtPrice.ReadOnly = allow;
            this.txtTotalInShelf.ReadOnly = allow;
            this.txtTotalInVault.ReadOnly = allow;
            this.txtDescription.ReadOnly = allow;


            this.btnAceptar.Enabled = !allow;
            this.btnCancelar.Enabled = !allow;
            this.cbStore.Enabled = !allow;
            this.btnEliminar.Enabled = !allow;

        }
        /// <summary>
        /// Metodo para Agregar o Actualizar un resgistro
        /// </summary>
        private void Save()
        {
            var articleDto = new ArticlesDto()
            {
                Id = 0,
                Name = this.txtName.Text,
                Description = this.txtDescription.Text,
                Price = decimal.Parse(this.txtPrice.Text),
                TotalInShelf = int.Parse(this.txtTotalInShelf.Text),
                TotalInVault = int.Parse(this.txtTotalInVault.Text),
                StoreId = int.Parse(cbStore.SelectedValue.ToString()),


            };
            ArticlesServices articleService = new ArticlesServices();
            articleService.Save(articleDto);
            LoadGrid();
        }
        /// <summary>
        /// Metodo para eliminar un registro
        /// </summary>
        private void Delete()
        {
            var articleDto = new ArticlesDto()
            {
                Id = int.Parse(this.txtId.Text),
                Name = this.txtName.Text,
                Description = this.txtDescription.Text,
                Price = decimal.Parse(this.txtPrice.Text),
                TotalInShelf = int.Parse(this.txtTotalInShelf.Text),
                TotalInVault = int.Parse(this.txtTotalInVault.Text),
                StoreId = int.Parse(cbStore.SelectedValue.ToString())
            };
            ArticlesServices articleService = new ArticlesServices();
            articleService.Delete(articleDto);
            LoadGrid();
        }
        /// <summary>
        /// Metodo que valida todos los campos que se necesitan para generar un registro
        /// </summary>
        /// <returns>Returna Verdadero o Falso dependiendo si se cumple o no con las condiciones</returns>

        private bool ValidateCreate()
        {
            StringBuilder sb = new StringBuilder();
            bool isOK = true;
            if (string.IsNullOrEmpty(this.txtName.Text))
            {
                sb.Append("Name es requerido." + Environment.NewLine);

            }
            if (string.IsNullOrEmpty(this.txtDescription.Text))
            {
                sb.Append("Description es requerido." + Environment.NewLine);
            }

            if (string.IsNullOrEmpty(this.txtPrice.Text))
            {
                sb.Append("Price es requerido." + Environment.NewLine);
            }

            if (string.IsNullOrEmpty(this.txtTotalInShelf.Text))
            {
                sb.Append("Total In Shelf es requerido." + Environment.NewLine);
            }
            if (string.IsNullOrEmpty(this.txtTotalInVault.Text))
            {
                sb.Append("Total In Vault es requerido." + Environment.NewLine);
            }
            if (int.Parse(cbStore.SelectedValue.ToString()) > 0)
            {
                sb.Append("Store es requerido." + Environment.NewLine);
            }

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString(), "Validar", MessageBoxButtons.OK);
                isOK = false;
            }

            return isOK;
        }
        /// <summary>
        /// Metodo para cargar el ComboBox, 
        /// </summary>
        /// <param name="position">Valor que toma la posicion en el combo, por default esta en SELECT</param>

        private void LoadDropDownList(int position = -1)
        {
            StoresServices storeService = new StoresServices();
            var result = storeService.GetAllAsync();

            var lstStore = result.stores.ToList();
            lstStore.Add(new StoresDto() { Address = string.Empty, Id = -1, Name = "Select Store" });



            cbStore.DataSource = lstStore;
            cbStore.DisplayMember = "Name";
            cbStore.ValueMember = "Id";


            cbStore.SelectedValue = position;
        }
        /// <summary>
        /// Metodo para cargar la grilla
        /// </summary>

        private void LoadGrid()
        {
            dgArticles.DataSource = null;

            ArticlesServices articlesManager = new ArticlesServices();

            var result = articlesManager.GetAll();

            //Set AutoGenerateColumns False
            dgArticles.AutoGenerateColumns = false;

            //Set Columns Count
            dgArticles.ColumnCount = 7;

            //Add Columns
            dgArticles.Columns[0].Name = "Id";
            dgArticles.Columns[0].HeaderText = "Id";
            dgArticles.Columns[0].DataPropertyName = "Id";
            dgArticles.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgArticles.Columns[1].HeaderText = "Name";
            dgArticles.Columns[1].Name = "Name";
            dgArticles.Columns[1].DataPropertyName = "Name";
            dgArticles.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgArticles.Columns[2].Name = "Description";
            dgArticles.Columns[2].HeaderText = "Description";
            dgArticles.Columns[2].DataPropertyName = "Description";
            dgArticles.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dgArticles.Columns[3].Name = "Price";
            dgArticles.Columns[3].HeaderText = "Price";
            dgArticles.Columns[3].DataPropertyName = "Price";
            dgArticles.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgArticles.Columns[4].Name = "TotalInShelf";
            dgArticles.Columns[4].HeaderText = "TotalInShelf";
            dgArticles.Columns[4].DataPropertyName = "TotalInShelf";
            dgArticles.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dgArticles.Columns[5].Name = "TotalInVault";
            dgArticles.Columns[5].HeaderText = "TotalInVault";
            dgArticles.Columns[5].DataPropertyName = "TotalInVault";
            dgArticles.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



            dgArticles.Columns[6].Name = "StoreId";
            dgArticles.Columns[6].HeaderText = "StoreId";
            dgArticles.Columns[6].DataPropertyName = "StoreId";
            dgArticles.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgArticles.Columns[6].Visible = false;

            dgArticles.DataSource = result.articles;
        }

        #endregion
    }
}
