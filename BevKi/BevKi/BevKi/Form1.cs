using System;
using System.Windows.Forms.DataVisualization.Charting;

namespace BevKi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateCashFlow();
        }

        private void AddValues(DateTime date, string desc, decimal value, string type)
        {
            Invoke(new Action(() =>
            {
                cashFlows.Rows.Add(type, date, desc, value);
            }));
        }
        private void AddValueToDatabase(object sender)
        {
            Button? button = sender as Button;

            var MongoDBHelper = new MongoDBHelper();
            if (button?.Name == "btnIncome")
            {
                AddValues(DateTime.Now, tbDesc.Text, tbValue.Value, "Income");
                MongoDBHelper.AddCashFlowData(tbDesc.Text, tbValue.Value, "Income");
            }
            else if (button?.Name == "btnExpense")
            {
                AddValues(DateTime.Now, tbDesc.Text, tbValue.Value * -1, "Expense");
                MongoDBHelper.AddCashFlowData(tbDesc.Text, tbValue.Value * -1, "Expense");
            }
            tbValue.Value = 1;
            tbDesc.Text = "";
        }

        private void btnClick(object sender, EventArgs e)
        {
            if (tbDesc.Text != "")
            {
                AddValueToDatabase(sender);
                UpdateChart();
            }
        }

        private void UpdateCashFlow()
        { 
            var mongoHelper = new MongoDBHelper();
            List<CashFlowData> cashFlowsList = mongoHelper.GetCashFlowData();
            
            for (int i = 0; i < cashFlowsList.Count; i++)
            {
                cashFlows.Rows.Add(cashFlowsList[i].Type, cashFlowsList[i].Date, cashFlowsList[i].Description, cashFlowsList[i].Value);
            }
            UpdateChart();
            label3.Text = $"Your balance : {(mongoHelper.SumOfValues("Income") - mongoHelper.SumOfValues("Expense")).ToString("C2")}";
        }

        private void UpdateChart()
        {
            var mongoHelper = new MongoDBHelper();
            chart1.Series.Clear();
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Cash Flow Data");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;

            series.Points.AddXY("Exp.", mongoHelper.SumOfValues("Expense"));
            series.Points.AddXY("Inc.", mongoHelper.SumOfValues("Income"));

            chart1.Series.Add(series);
            label3.Text = $"Your balance : {mongoHelper.SumOfValues("Income") - mongoHelper.SumOfValues("Expense")}";
        }
    }
}
