using System;
using System.Collections.Generic;
using System.Windows.Forms;
using YNAB.Api;
using YNAB.Client;
using YNAB.Model;
using YNAB.Statistics.Models;

namespace YNAB.Statistics
{
    public partial class Form1 : Form
    {
        private BudgetSummary _selectedBudget;

        public Form1()
        {
            InitializeComponent();

            // Configure API key authorization: bearer
            Configuration.ApiKey.Add("Authorization", "YOUR_API_KEY_HERE");
            // Setup prefix (e.g. Bearer) for API key
            Configuration.ApiKeyPrefix.Add("Authorization", "Bearer");

            BudgetsApi budgetApi = new BudgetsApi();
            var budgets = budgetApi.GetBudgets();

            _selectedBudget = budgets.Data.Budgets[0];

            this.Text = $"YNAB Statistics - {_selectedBudget.Name}";
        }

        private void btnSpendByPayee_Click(object sender, System.EventArgs e)
        {
            var payeesApi = new PayeesApi();
            var payees = payeesApi.GetPayees(_selectedBudget.Id);

            List<PaidPerPayeeModel> models = new List<PaidPerPayeeModel>();
            TransactionsApi transactionApi = new TransactionsApi();

            foreach (var payee in payees.Data.Payees)
            {
                PaidPerPayeeModel newModel = new PaidPerPayeeModel();
                var transactions = transactionApi.GetTransactionsByPayee(_selectedBudget.Id, payee.Id, null, string.Empty);
                newModel.Name = payee.Name;
                foreach (var transaction in transactions.Data.Transactions)
                {
                    double transAsDecimal = Convert.ToDouble(transaction.Amount) / 1000;
                    if (transaction.Amount != null) newModel.TotalSpend += transAsDecimal;
                }

                models.Add(newModel);
            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"test.csv"))
            {
                file.WriteLine($"\"Name\";\"Total Spend\"");
                foreach (var model in models)
                {
                    if (model.TotalSpend >= 0 || model.Name.StartsWith("Transfer :"))
                    {
                        continue;
                    }

                    file.WriteLine($"\"{model.Name}\";\"{model.TotalSpend}\"");
                }
            }
        }
    }
}
