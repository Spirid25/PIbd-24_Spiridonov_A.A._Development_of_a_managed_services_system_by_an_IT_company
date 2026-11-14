using TaskTrecker.Entities;
using TaskTrecker.Repositories;

namespace TaskTrecker.Forms
{
    public partial class ClientEditForm : Form
    {
        private readonly IClientRepository _clientRepository;
        private int? _clientId;

        public int Id
        {
            set
            {
                try
                {
                    var client = _clientRepository.GetById(value);
                    if (client == null)
                        throw new InvalidOperationException("Клиент не найден");

                    textBoxName.Text = client.Name;
                    textBoxInn.Text = client.Inn;
                    _clientId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public ClientEditForm(IClientRepository clientRepository)
        {
            InitializeComponent();
            _clientRepository = clientRepository ?? throw new ArgumentNullException(nameof(clientRepository));

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxInn.Text))
                    throw new Exception("Имеются незаполненные поля");

                if (_clientId.HasValue)
                {
                    var client = Client.CreateEntity(_clientId.Value, textBoxName.Text, textBoxInn.Text);
                    _clientRepository.Update(client);
                }
                else
                {
                    var client = Client.CreateEntity(0, textBoxName.Text, textBoxInn.Text);
                    _clientRepository.Add(client);
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();
    }
}