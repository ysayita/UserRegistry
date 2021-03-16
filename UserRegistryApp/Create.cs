using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;
using UserDataContext.ViewModels;
using UserModels;

namespace UserRegistryApp
{
    public partial class Create : Form
    {
        Main master;
        public Create(Main mf)
        {
            InitializeComponent();
            master = mf;
        }

        private async void btn_create_Click(object sender, System.EventArgs e)
        {
            var model = new User
            {
                Name = txb_name.Text,
                Email = txb_email.Text,
                Gender = cmb_gender.Text,
                Status = cmb_status.Text
            };
            var results = new List<ValidationResult>();
            var success = Validator.TryValidateObject(model, new ValidationContext(model, null, null), results);
            if (success)
            {
                var result = await UserDataContext.Users.Instance.AddAsync(model);
                MessageBox.Show($"User creation is {(result ? "successful" : "unsuccessful")}");
                master.LoadUsersAsync();
                Close();
            }
            else
            {
                MessageBox.Show(string.Join("\n", results.Select(vr => vr.ErrorMessage)));
            }
        }
    }
}
