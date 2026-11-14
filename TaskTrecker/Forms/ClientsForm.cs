using System;
using System.Windows.Forms;
using Unity;
using TaskTrecker.Entities;
using TaskTrecker.Repositories;

namespace TaskTrecker.Forms
{
    public partial class ClientsForm : Form
    {
        private readonly IUnityContainer _container;
        private readonly IClientRepository _clientRepository;

        public ClientsForm(IUnityContainer container, IClientRepository clientRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _clientRepository = clientRepository ?? throw new ArgumentNullException(nameof(clientRepository));
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            dataGridViewClients.DataSource = null;
            dataGridViewClients.DataSource = _clientRepository.GetAll();
            if (dataGridViewClients.Columns["Id"] != null)
                dataGridViewClients.Columns["Id"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<ClientEditForm>().ShowDialog();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!TryGetIdFromSelectedRow(out int id)) return;
            try
            {
                var form = _container.Resolve<ClientEditForm>();
                form.Id = id;
                form.ShowDialog();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при изменении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!TryGetIdFromSelectedRow(out int id)) return;

            if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            try
            {
                _clientRepository.Delete(id);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при удалении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool TryGetIdFromSelectedRow(out int id)
        {
            id = 0;
            if (dataGridViewClients.SelectedRows.Count < 1)
            {
                MessageBox.Show("Нет выбранной записи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            id = Convert.ToInt32(dataGridViewClients.SelectedRows[0].Cells["Id"].Value);
            return true;
        }
    }
}