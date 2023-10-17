
using BusinessLogic.Library;
using BusinessLogic.Library.Extentions;
using Domain.Model;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TicketApplication.Authentication;
using TicketApplication.Extentions;

namespace TicketApplication.Forms
{
    public partial class LoginForm : Form
    {
        #region CodeRound
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        #endregion

        int y = 500;
        Timer T1 = new Timer();
        private UserService _userService;
        private RoleService _roleService;
        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            _userService = new UserService();
            _roleService = new RoleService();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //StartTimer1();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var res = _userService.IsExit(UsernameTxt.Text, PasswordTxt.Text);
                LoginMsg.Text = res.Message;
                if (res.Success)
                {
                    StartTimer1();
                }
                else
                {
                    //UsernameTxt.Text = "";
                    PasswordTxt.Text = "";
                    PasswordTxt.Focus();
                }
            }
            catch
            {
                LoginMsg.Text = "مجدد تلاش کنید";
                throw;
            }
        }
        private void SignInBtn_Click(object sender, EventArgs e)
        {
            SignInPanel.Visible = true;
            LoginPanel.Visible = false;
            ClearTextBoxes(this.Controls);
        }

        private void SaveNewUserBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Sign_Name.Text) || string.IsNullOrWhiteSpace(Sign_Name.Text))
            {
                SignInMsg.Text = $"نام معتبر وارد کنید";
                Sign_Name.Focus();
            }
            else if (string.IsNullOrEmpty(Sign_Family.Text) || string.IsNullOrWhiteSpace(Sign_Family.Text))
            {
                SignInMsg.Text = $"فامیل معتبر وارد کنید";
                Sign_Family.Focus();
            }
            else if (string.IsNullOrEmpty(Sign_Phone.Text) || string.IsNullOrWhiteSpace(Sign_Phone.Text))
            {
                SignInMsg.Text = $"تلفن معتبر وارد کنید";
                Sign_Phone.Focus();
            }
            else if (string.IsNullOrEmpty(Sign_Email.Text) || string.IsNullOrWhiteSpace(Sign_Email.Text))
            {
                SignInMsg.Text = $"ایمیل معتبر وارد کنید";
                Sign_Email.Focus();
            }
            else if (string.IsNullOrEmpty(Sign_Username.Text) || string.IsNullOrWhiteSpace(Sign_Username.Text) || Sign_Username.Text.Count() < 6 || Sign_Username.Text.Trim() == "")
            {
                SignInMsg.Text = $"نام کاربری معتبر وارد کنید حداقل 8 کارکتر باشد";
                Sign_Username.Focus();
            }
            else if (string.IsNullOrEmpty(Sign_Pass.Text) || string.IsNullOrWhiteSpace(Sign_Pass.Text) || Sign_Pass.Text.Count() < 8 || Sign_Pass.Text.Trim() == "")
            {
                SignInMsg.Text = $"رمز باید حرف,عدد و حداقل 8 کارکتر باشد ";
                Sign_Pass.Focus();
            }
            else if (Sign_Pass.Text != Sign_RePass.Text)
            {
                SignInMsg.Text = $"رمز ها همخوانی ندارد";
                Sign_Pass.Text = null; Sign_RePass.Text = null;
                Sign_Pass.Focus();
            }
            else
            {
                User entity = new User();
                entity.Name = Sign_Name.Text;
                entity.Family = Sign_Family.Text;
                entity.DisplayName = $"{entity.Name} {entity.Family}";
                entity.Phone = Sign_Phone.Text;
                entity.Email = Sign_Email.Text.ToLower();
                entity.Username = Sign_Username.Text.Trim().ToLower();
                entity.Password = PasswordHasher.HashPassword(Sign_Pass.Text);
                entity.Salt = CryptoPassword.GeneratePassword(Sign_Pass.Text).Salt;
                entity.Hash = CryptoPassword.GeneratePassword(Sign_Pass.Text).Hash;
                var res =_userService.IsMatchAny(entity);

                if (res.Success)
                {
                    _userService.InsertWithRole(entity, _roleService.GetById(3));
                    SignInMsg.Text = res.Message;
                    CloseSignInPanel();
                }
                else
                {
                    SignInMsg.Text = res.Message;
                }
            }

        }


        private void ShowLoginPanelBtn_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = true;
            SignInPanel.Visible = false;
            ClearTextBoxes(this.Controls);

        }

        private void ForgotPass_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = false;
            RecoverPanel.Visible = true;
            ClearTextBoxes(this.Controls);
        }

        private void RCV_CheckBtn_Click(object sender, EventArgs e)
        {
            var userModel = new User
            {
                Name= RCV_Name.Text,
                Family=RCV_Family.Text,
                Phone= RCV_Phone.Text,
                Email= RCV_Email.Text.ToLower(),
                Username = RCV_Username.Text.ToLower(),
                Password = RCV_Pass.Text,
                UpdateBy = AppUser.UserID,
                UpdateDate = DateTime.Now
            };
            if (RCV_CheckBtn.Text == "بررسی اطلاعات")
            {

                var res = _userService.Recovery(userModel);
                if (res.Success)
                {
                    RCV_LBL_Pass1.Visible = true;
                    RCV_LBL_Pass2.Visible = true;
                    RCV_Pass.Visible = true;
                    RCV_RePas.Visible = true;
                    RCV_CheckBtn.Text = "ذخیره اطلاعات";
                    RecoverMsg.Text = $"کاربر {userModel.Name} {userModel.Family} رمز جدید و درست وارد کنید";
                }
                else
                {
                    RecoverMsg.Text = "اطلاعات مورد نظر درست نمیباشد";
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(RCV_Pass.Text.Trim())  &&  !string.IsNullOrWhiteSpace(RCV_RePas.Text.Trim()) && RCV_RePas.Text.Trim().Count() >= 8)
                {
                    if (RCV_Pass.Text == RCV_RePas.Text)
                    {
                        _userService.UpdateRecoveryPass(userModel);
                        RCV_CheckBtn.Text = "بررسی اطلاعات";
                        RCV_LBL_Pass1.Visible = false;
                        RCV_LBL_Pass2.Visible = false;
                        RCV_Pass.Visible = false;
                        RCV_RePas.Visible = false;
                        RecoverMsg.Text = "با موفقیت ویرایش شد";
                        ClearTextBoxes(this.Controls);
                    }
                    else
                    {
                        RecoverMsg.Text = "رمز همخوانی ندارد";
                    }
                }
                else
                {
                    RecoverMsg.Text = "رمز معتبر نیست";
                }
            }

        }

        private void BackToLoginPanel_Click(object sender, EventArgs e)
        {
            RecoverPanel.Visible = false;
            LoginPanel.Visible = true;
            ClearTextBoxes(this.Controls);
        }

        //  Create Timer
        private void LoginTimer(object sender, EventArgs e)
        {
            CloseLoginPanel();
        }
        private void SignInTimer(object sender, EventArgs e)
        {
            CloseSignInPanel();
        }
        //  Set Timer
        private void StartTimer1()
        {
            T1.Enabled = true;
            T1.Interval = 10;
            T1.Tick += LoginTimer;
            T1.Start();
        }
        private void StartTimer2()
        {
            T1.Enabled = true;
            T1.Interval = 10;
            T1.Tick += SignInTimer;
            T1.Start();
        }
        //  Close Panel
        private void CloseSignInPanel()
        {
            while (SignInPanel.Location.Y > -400)
            {
                y = y - 10;
                SignInPanel.Location = new Point(535, y);
                this.Location = new Point(this.Location.X, y);
                //this.Controls["MainPanel"].Location = new Point(411, y2);

            }
            T1.Stop();
            SetCurrentUserData(Sign_Username.Text);
            this.Close();
        }
        private void CloseLoginPanel()
        {
            while (this.Location.Y > -400)
            {
                y = y - 10;
                //LoginPanel.Location = new Point(535, y);
                this.Location = new Point(this.Location.X, y);
            }
            T1.Stop();

            SetCurrentUserData(UsernameTxt.Text);
            this.Hide();
        }

        private void Sign_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void SetCurrentUserData(string username)
        {
            var user = _userService.GetByUserName(username);
            AppUser.Username = user.Data.Username.ToUpper();
            AppUser.UserID = user.Data.ID;
            AppUser.UserRoleID = user.Data.UserRoles.FirstOrDefault(x => x.UserID == user.Data.ID).ID;
            AppUser.RoleID = user.Data.UserRoles.FirstOrDefault(x => x.UserID == user.Data.ID).Role.ID;
        }

        public void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            FormExtentions.ClearTextBoxes(ctrlCollection);
        }

        private void RCV_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
