using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsControlLibrary.Models;
using EmployeeBusinessLogic.Interface;
using Unity;
using EmployeeDatabase;
using NonVisualComponents;
using System.Linq;
using EmployeeBusinessLogic.ViewModel;
using EmployeeBusinessLogic.BindingModel;
using NonVisualComponents.Kokorev;

namespace EmployeeView
{
    public partial class MainForm : Form
    {
        [Dependency] public new IUnityContainer Container { get; set; }

        private readonly IEmployee employeeService;

        public MainForm(IEmployee employeeService)
        {
            InitializeComponent();
            this.employeeService = employeeService;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void backupSaveButton_Click(object sender, EventArgs e)
        {
            var employees = employeeService.Read(null);
            using (var dialog = new SaveFileDialog { Filter = "" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    componentBackupXml.CreateXmlBackup(employees.ToArray(), dialog.FileName);
                    LoadData();
                }
            }
        }

        private void createEmployeeButton_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<CreateEmployeeForm>();
            form.ShowDialog();
            LoadData();
        }

        private void LoadData()
        {
            var employees = employeeService.Read(null);
            var treeInfo = new DataTreeNodeConfig();
            var nodeNames = new Queue<string>();
            nodeNames.Enqueue("Position");
            nodeNames.Enqueue("Fio");
            treeInfo.NodeNames = nodeNames;
            controlDataTreeTable.LoadTreeInfo(treeInfo);
            controlDataTreeTable.AddTable(employees);

            var columns = new List<DataTableColumnConfig>();
            columns.Add(new DataTableColumnConfig() { ColumnHeader = "Id", PropertyName = "Id", Visible = false });
            columns.Add(new DataTableColumnConfig() { ColumnHeader = "Fio", PropertyName = "Fio", Visible = true });
            columns.Add(new DataTableColumnConfig() { ColumnHeader = "Vacation Start", PropertyName = "VacationStart", Visible = false });
            columns.Add(new DataTableColumnConfig() { ColumnHeader = "Position", PropertyName = "Position", Visible = false });
            columns.Add(new DataTableColumnConfig() { ColumnHeader = "Subdivision", PropertyName = "Subdivision", Visible = true });
            columns.Add(new DataTableColumnConfig() { ColumnHeader = "Work phone", PropertyName = "WorkPhone", Visible = true });
            controlDataTableTable.LoadColumns(columns);
            controlDataTableTable.AddTable(employees);
        }

        /// <summary>
        /// создание таблицы со всеми сотрудниками и их должностями
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWordPosition_Click(object sender, EventArgs e)
        {
            var employees = employeeService.Read(null);
            try
            {
                ComponentWord comp = new ComponentWord();
                using (var context = new Database())
                {
                    using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
                    {
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            comp.Save(dialog.FileName, employees, new List<string> { "Fio", "Position" });
                            MessageBox.Show("Сохранение прошло успешно");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось сохранить отчет " + ex.Message);
            }
        }

        /// <summary>
        /// создание гистограммы с количеством отпусков в каждом месяце
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWordVacation_Click(object sender, EventArgs e)
        {
            try
            {
                ComponentWordHistogram comp = new ComponentWordHistogram();
                using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
                {
                    using (var context = new Database())
                    {
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            List<DiagramModel> list = new List<DiagramModel>();
                            var employees = context.Employees
                                .GroupBy(p => p.VacationStart.Value.Month)
                                .Select(p => new { p.Key, Count = p.Count() })
                                .ToDictionary(p => p.Key, p => p.Count);

                            foreach (var employee in employees)
                            {
                                list.Add(new DiagramModel
                                {
                                    Count = employee.Key,
                                    Month = employee.Value
                                });
                            }

                            comp.CreateDiagram(list, "Employees", dialog.FileName);
                            MessageBox.Show("Сохранение прошло успешно");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось сохранить диаграмму\n" + ex.Message);
            }
        }

        private void buttonLoadFromBackup_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dialog = new OpenFileDialog { Filter = ".zip|*.zip" })
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        var employees = componentLoadXml.LoadXml<EmployeeViewModel>(dialog.FileName);
                        foreach (var employee in employees)
                        {
                            employeeService.CreateOrUpdate(new EmployeeBindingModel
                            {
                                Fio = employee.Fio,
                                VacationStart = employee.VacationStart,
                                Position = employee.Position,
                                Subdivision = employee.Subdivision,
                                WorkPhone = employee.WorkPhone
                            });
                        }

                        MessageBox.Show("Сохранение прошло успешно");
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось получить данные\n" + ex.Message);
            }
        }

        private void buttonExcelReportPhone_Click(object sender, EventArgs e)
        {
            var employees = employeeService.Read(null);
            try
            {
                ComponentExcelReport comp = new ComponentExcelReport();
                using (var context = new Database())
                {
                    using (var dialog = new SaveFileDialog { Filter = "xlsx|*.xlsx" })
                    {
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            List<ExcelReportModel> list = new List<ExcelReportModel>();

                            foreach (var employee in employees)
                            {
                                list.Add(new ExcelReportModel
                                {
                                    Fio = employee.Fio,
                                    WorkPhone = employee.WorkPhone
                                });
                            }

                            comp.CreateExcelReport(dialog.FileName, true, list);
                            MessageBox.Show("Сохранение прошло успешно");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось сохранить отчет " + ex.Message);
            }
        }

        private void buttonExcelSubvision_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog fd = new SaveFileDialog { Filter = "xlsx|*.xlsx" })
                {
                    if (fd.ShowDialog() == DialogResult.OK)
                    {
                        componentDiagramExcel.CreateDiagram(fd.FileName, employeeService.Read(null));
                        MessageBox.Show("Диаграмма создана", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}