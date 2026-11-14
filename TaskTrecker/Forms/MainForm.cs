using Unity;
using TaskTrecker.Forms;
namespace TaskTrecker;

public partial class MainForm : Form
{
    private readonly IUnityContainer _container;

    public MainForm(IUnityContainer container)
    {
        InitializeComponent();
        _container = container;
    }

    private void справочникиToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }
    private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<ClientsForm>().ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<EmployeesForm>().ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<ServiceForm>().ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void договорыToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<ContractForm>().ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void операцииToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }
}