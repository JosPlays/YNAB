using System.Windows.Forms;
using YNAB.Api;
using YNAB.Client;

namespace YNAB.Statistics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Configure API key authorization: bearer
            Configuration.ApiKey.Add("Authorization", "YOUR_API_KEY_HERE");
            // Setup prefix (e.g. Bearer) for API key
            Configuration.ApiKeyPrefix.Add("Authorization", "Bearer");

            BudgetsApi budgetApi = new BudgetsApi();
            var budgets = budgetApi.GetBudgets();

        }
    }
}
