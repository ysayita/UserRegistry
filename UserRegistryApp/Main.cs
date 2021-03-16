using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UserDataContext;
using UserDataContext.ViewModels;
using UserModels;

namespace UserRegistryApp
{
    public partial class Main : Form
    {
        UserQueryVM queryVM;
        public Main(UserQueryVM vm = null)
        {
            InitializeComponent();
            LoadUsersAsync(vm);
        }
        public async void LoadUsersAsync(UserQueryVM vm = null)
        {
            queryVM = vm;
            lbl_qpSummary.Text = BuildSearchParameterSummary(vm);
            IEnumerable<User> users = await Users.Instance.GetAllAsync(vm: vm);
            usersGridView.DataSource = users;
            usersGridView.AutoResizeColumns();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var searchForm = new Search(this, queryVM);
            searchForm.ShowDialog();
        }
        private string BuildSearchParameterSummary(UserQueryVM vm)
        {
            if (vm?.HasParameterFilled == true)
            {
                var queryParameters = new List<string>(4);

                if (!string.IsNullOrEmpty(vm?.name)) queryParameters.Add($"name={vm.name}");
                if (!string.IsNullOrEmpty(vm?.email)) queryParameters.Add($"email={vm.email}");
                if (!string.IsNullOrEmpty(vm?.gender)) queryParameters.Add($"gender={vm.gender}");
                if (!string.IsNullOrEmpty(vm?.status)) queryParameters.Add($"status={vm.status}");

                return "Active query parameters: " +
                    string.Join(", ", queryParameters.ToArray());
            }
            return string.Empty;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            var createForm = new Create(this);
            createForm.ShowDialog();
        }
    }
}
