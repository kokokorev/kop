using System;
using System.Windows.Forms;
using EmployeeBusinessLogic.BindingModel;
using EmployeeBusinessLogic.Enums;
using EmployeeBusinessLogic.Interface;
using Unity;

namespace EmployeeView
{
    public partial class CreateEmployeeForm : Form
    {
        [Dependency] public new IUnityContainer Container { get; set; }

        private readonly IEmployee employeeService;

        public CreateEmployeeForm(IEmployee employeeService)
        {
            InitializeComponent();
            this.employeeService = employeeService;
            controlSelectedComboBoxEnum.LoadEnum(typeof(Position));
            controlSelectedComboBoxEnumSubvision.LoadEnum(typeof(Subdivision));
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                employeeService.CreateOrUpdate(new EmployeeBindingModel
                {
                    Fio = fioTextBox.Text,
                    Position = (Position)controlSelectedComboBoxEnum.SelectedItem,
                    VacationStart = DateTime.Now,
                    Subdivision = (Subdivision)controlSelectedComboBoxEnumSubvision.SelectedItem,
                    WorkPhone = textBoxWorkForm.Text
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}