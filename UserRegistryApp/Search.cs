using System.Windows.Forms;
using UserDataContext.ViewModels;

namespace UserRegistryApp
{
    public partial class Search : Form
    {
        UserQueryVM queryVM;
        Main master;
        public Search(Main mf, UserQueryVM vm = null)
        {
            InitializeComponent();
            queryVM = vm;
            master = mf;
            if (vm != null && vm.HasParameterFilled)
            {
                txb_name.Text = vm.name;
                txb_email.Text = vm.email;
                cmb_gender.Text = vm.gender;
                cmb_status.Text = vm.status;
            }
        }

        private void btn_search_Click(object sender, System.EventArgs e)
        {
            queryVM = new UserQueryVM
            {
                name = txb_name.Text.Trim(),
                email = txb_email.Text.Trim(),
                gender = cmb_gender.Text,
                status = cmb_status.Text
            };
            master.LoadUsersAsync(queryVM);
            Close();
        }
    }
}
