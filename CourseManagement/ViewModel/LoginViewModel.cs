using CourseManagement.Common;
using CourseManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CourseManagement.ViewModel
{
    public class LoginViewModel
    {
        public LoginModel LoginModel { get; set; }

        public CommandBase CloseWindowCommand { get; set; }

        public LoginViewModel()
        {
            this.LoginModel = new LoginModel();

            this.LoginModel.UserName = "Shadowsong";
            this.LoginModel.Password = "shadowsong";

            this.CloseWindowCommand = new CommandBase()
            {
                DoExecute = new Action<object>((obj) =>
                {
                    ((Window)obj).Close();
                }),

                DoCanExecute = new Func<object, bool>((obj) =>
                {
                    return true;
                })
            };
        }
    }
}
