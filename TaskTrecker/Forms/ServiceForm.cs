using System;
using System.Windows.Forms;
using Unity;
using TaskTrecker.Repositories;

namespace TaskTrecker.Forms
{
    public partial class ServiceForm : Form
    {
        private readonly IUnityContainer _container;
        private readonly IServiceRepository _serviceRepository;

        public ServiceForm(IUnityContainer container, IServiceRepository serviceRepository)
        {
            InitializeComponent();
            _container = container;
            _serviceRepository = serviceRepository;
        }

        private void ServicesForm_Load(object sender, EventArgs e)
        {
            try { LoadData(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при загрузке"); }
        }

        private void LoadData()
        {
            dataGridViewData.DataSource = null;
            dataGridViewData.DataSource = _serviceRepository.GetAll();

            if (dataGridViewData.Columns["Id"] != null)
                dataGridViewData.Columns["Id"].Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var form = _container.Resolve<ServiceEditForm>();
                if (form.ShowDialog() == DialogResult.OK) LoadData();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при добавлении"); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (!TryGetIdFromSelectedRow(out int id)) return;
            try
            {
                var form = _container.Resolve<ServiceEditForm>();
                form.Id = id;
                if (form.ShowDialog() == DialogResult.OK) LoadData();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при редактировании"); }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!TryGetIdFromSelectedRow(out int id)) return;
            if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            try { _serviceRepository.Delete(id); LoadData(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при удалении"); }
        }

        private bool TryGetIdFromSelectedRow(out int id)
        {
            id = 0;
            if (dataGridViewData.SelectedRows.Count < 1)
            {
                MessageBox.Show("Нет выбранной записи", "Ошибка");
                return false;
            }
            id = Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells["Id"].Value);
            return true;
        }
    }
}