using System.Windows.Forms.VisualStyles;
using TaskTrecker.Enums;
using TaskTrecker.Entities;
using TaskTrecker.Repositories;
namespace TaskTrecker.Forms;
public partial class ContractEditForm : Form
{
    private readonly IContractRepository _contractRepository;

    public ContractEditForm(
        IContractRepository contractRepository,
        IClientRepository clientRepository,
        IEmployeeRepository employeeRepository)
    {
        InitializeComponent();
        _contractRepository = contractRepository;

        comboBoxClient.DataSource = clientRepository.GetAll().ToList();
        comboBoxClient.DisplayMember = "FirstName";
        comboBoxClient.ValueMember = "Id";

        comboBoxEmployee.DataSource = employeeRepository.GetAll().ToList();
        comboBoxEmployee.DisplayMember = "LastName";
        comboBoxEmployee.ValueMember = "Id";

        comboBoxStatus.DataSource = Enum.GetValues(typeof(ContractStatus));
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (comboBoxClient.SelectedIndex < 0) throw new Exception("Выберите клиента!");
            if (comboBoxEmployee.SelectedIndex < 0) throw new Exception("Выберите сотрудника!");

            var contract = Contract.CreateEntity(
                0,
                (int)comboBoxClient.SelectedValue,
                (int)comboBoxEmployee.SelectedValue,
                (ContractStatus)comboBoxStatus.SelectedItem);

            _contractRepository.Add(contract);
            DialogResult = DialogResult.OK;
            Close();
        }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка"); }
    }

    private void buttonCancel_Click(object sender, EventArgs e) => Close();
}