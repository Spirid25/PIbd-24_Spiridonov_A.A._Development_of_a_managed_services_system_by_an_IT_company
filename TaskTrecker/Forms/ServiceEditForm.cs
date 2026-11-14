using System;
using System.Windows.Forms;
using TaskTrecker.Entities;
using TaskTrecker.Enums;
using TaskTrecker.Repositories;

namespace TaskTrecker.Forms
{
    public partial class ServiceEditForm : Form
    {
        private readonly IServiceRepository _serviceRepository;
        private int? _serviceId;

        public int Id
        {
            set
            {
                var service = _serviceRepository.GetById(value);
                if (service == null) throw new Exception("Услуга не найдена");
                numericUpDownPrice.Value = service.Price;
                comboBoxCategory.SelectedItem = service.Category;
                _serviceId = value;
            }
        }

        public ServiceEditForm(IServiceRepository serviceRepository)
        {
            InitializeComponent();
            _serviceRepository = serviceRepository;
            comboBoxCategory.DataSource = Enum.GetValues(typeof(ServiceType));
            comboBoxCategory.SelectedIndex = 0;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCategory.SelectedIndex < 0)
                    throw new Exception("Выберите тип услуги!");
                if (numericUpDownPrice.Value <= 0)
                    throw new Exception("Цена должна быть больше нуля!");

                var service = Service.CreateEntity(
                    _serviceId ?? 0,
                    numericUpDownPrice.Value,
                    (ServiceType)comboBoxCategory.SelectedItem);

                if (_serviceId.HasValue) _serviceRepository.Update(service);
                else _serviceRepository.Add(service);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();
    }
}