using TaskTrecker.Forms;
using TaskTrecker.Repositories;
using Unity;
namespace TaskTrecker.Forms;
public partial class ContractForm : Form
{
    private readonly IUnityContainer _container;
    private readonly IContractRepository _contractRepository;

    public ContractForm(IUnityContainer container, IContractRepository contractRepository)
    {
        InitializeComponent();
        _container = container;
        _contractRepository = contractRepository;
    }

    private void ContractsForm_Load(object sender, EventArgs e) => LoadData();

    private void LoadData()
    {
        dataGridViewData.DataSource = null;
        dataGridViewData.DataSource = _contractRepository.GetAll();
        if (dataGridViewData.Columns["Id"] != null) dataGridViewData.Columns["Id"].Visible = false;
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        try
        {
            var form = _container.Resolve<ContractEditForm>();
            if (form.ShowDialog() == DialogResult.OK) LoadData();
        }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка"); }
    }
}