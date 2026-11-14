using TaskTrecker.Entities;
using TaskTrecker.Repositories;

namespace TaskTrecker.Forms
{
    public partial class EmployeeEditForm : Form
    {
        private readonly IEmployeeRepository _employeeRepository;
        private int? _employeeId;

        public int Id
        {
            set
            {
                var employee = _employeeRepository.GetById(value);
                if (employee == null) throw new Exception("Сотрудник не найден");
                textBoxFirstName.Text = employee.FirstName;
                textBoxLastName.Text = employee.LastName;
                _employeeId = value;
            }
        }

        public EmployeeEditForm(IEmployeeRepository employeeRepository)
        {
            InitializeComponent();
            _employeeRepository = employeeRepository;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxFirstName.Text))
                    throw new Exception("Введите имя!");
                if (string.IsNullOrWhiteSpace(textBoxLastName.Text))
                    throw new Exception("Введите фамилию!");

                var employee = Employee.CreateEntity(_employeeId ?? 0, textBoxFirstName.Text, textBoxLastName.Text);

                if (_employeeId.HasValue) _employeeRepository.Update(employee);
                else _employeeRepository.Add(employee);

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