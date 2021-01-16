using EmployeeBusinessLogic.ViewModel;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace NonVisualComponents
{
    public partial class ComponentDiagramExcel : Component
    {
        public ComponentDiagramExcel()
        {
            InitializeComponent();
        }

        public ComponentDiagramExcel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void CreateDiagram(string fileName, List<EmployeeViewModel> students)
        {
            Application excel_report = new Application { SheetsInNewWorkbook = 1 };
            // добавить книгу
            Workbook workBook = excel_report.Workbooks.Add(Type.Missing);
            // получаем первый лист документа
            Worksheet worksheet = (Worksheet)excel_report.Worksheets.get_Item(1);
            ChartObjects chartObjs = (ChartObjects)worksheet.ChartObjects();
            var groups = students.GroupBy(x => x.Subdivision);
            int row = 0;
            foreach (var group in groups)
            {
                row++;
                // записываем отдел в 1 столбце
                worksheet.Cells[row, 1] = group.Key.ToString();
                // записываем количество сотрудников
                worksheet.Cells[row, 2] = group.Count();
            }
            ChartObjects xlCharts = (ChartObjects)worksheet.ChartObjects(Type.Missing);
            ChartObject myChart = xlCharts.Add(110, 0, 350, 250);
            Chart chart = myChart.Chart;
            SeriesCollection seriesCollection = (SeriesCollection)chart.SeriesCollection(Type.Missing);
            Series series = seriesCollection.NewSeries();
            series.XValues = worksheet.get_Range("A1", "A" + row);
            series.Values = worksheet.get_Range("B1", "B" + row);
            chart.ChartType = XlChartType.xlPie;
            excel_report.Application.ActiveWorkbook.SaveAs(fileName, Type.Missing,
               Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlNoChange,
               Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        }
    }
}