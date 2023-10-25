using BusinessLogic.Library.Extentions;
using Domain.Library.KeyValues;
using Domain.Model;
using Infrastrucure.Library.DatabaseService;
using Infrastrucure.Library.Repository.RoleService;
using Infrastrucure.Library.Repository.UserService;
using System;
using System.Linq;
using System.Windows.Forms;
using TicketApplication.Common;
using TicketApplication.Extentions;

namespace TicketApplication.UserControls
{
    public partial class SettingPanel : UserControl
    {
        private Paging Paging;
        private long ID = 0;
        public SettingPanel()
        {
            Paging = new Paging();
            InitializeComponent();
        }
        private void ShowDataGridView(int tab, int type)
        {
            UserQueries userQueries = new UserQueries();
            IBaseQuery baseQuery = new BaseQuery();
            if (tab == 0)
            {
                if (type == 0)
                {
                    DataGridUsers.DataSource = baseQuery.Execute(userQueries.ShowAll(Paging.Order(Paging.Page, 20)));
                    CountLBL.Text = $"تعداد رکورد {DataGridUsers.Rows.Count} | صفحه {Paging.Page + 1}";
                }
                else
                {
                    DataGridUsers.DataSource = baseQuery.Execute(userQueries.SearchResult(SearchTxtUsers.Text));
                    CountLBL.Text = $"تعداد رکورد {DataGridUsers.Rows.Count} | صفحه {Paging.Page + 1}";
                }
            }
        }
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tabIndex = TabControl.SelectedIndex;
            switch (tabIndex)
            {
                case 0: //  Users
                    {
                        ShowDataGridView(0, 0);
                        break;
                    }
                case 1: //  Role
                    {
                        break;
                    }
                case 2: //  Privilege
                    {
                        break;
                    }
                case 3: // Setting
                    {
                        break;
                    }
            }
        }

        private void PreBtn_Click(object sender, EventArgs e)
        {
            Paging.Prev();
            ShowDataGridView(0, 0);
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            Paging.Next(20, DataGridUsers.Rows.Count);
            ShowDataGridView(0, 0);
        }

        private async void SaveUserBtn_Click(object sender, EventArgs e)
        {
            UserService _userService = new UserService();
            RoleService _roleService = new RoleService();
            if (string.IsNullOrEmpty(NameUserTxt.Text) || string.IsNullOrWhiteSpace(NameUserTxt.Text) || NameUserTxt.Text.Count() < 4)
            {
                MessageLbl.Text = "نام کاربر معتبر نیست ...";
            }
            else if (string.IsNullOrEmpty(FamilyUserTxt.Text) || string.IsNullOrWhiteSpace(FamilyUserTxt.Text) || FamilyUserTxt.Text.Count() < 4)
            {
                MessageLbl.Text = "فامیل کاربر معتبر نیست ...";
            }
            else if (string.IsNullOrEmpty(PhoneUserTxt.Text) || string.IsNullOrWhiteSpace(PhoneUserTxt.Text) || PhoneUserTxt.Text.Count() < 11)
            {
                MessageLbl.Text = "تلفن کاربر معتبر نیست ...";
            }
            else if (string.IsNullOrEmpty(EmailUserTxt.Text) || string.IsNullOrWhiteSpace(EmailUserTxt.Text) || EmailUserTxt.Text.Count() < 5)
            {
                MessageLbl.Text = "ایمیل کاربر معتبر نیست ...";
            }
            else if (string.IsNullOrEmpty(UsernameUserTxt.Text) || string.IsNullOrWhiteSpace(UsernameUserTxt.Text) || UsernameUserTxt.Text.Count() < 5)
            {
                MessageLbl.Text = "نام کاربری معتبر نیست ...";
            }
            else if (string.IsNullOrEmpty(PasswordUserTxt.Text) || string.IsNullOrWhiteSpace(PasswordUserTxt.Text) || PasswordUserTxt.Text.Count() < 6)
            {
                MessageLbl.Text = "رمز کاربر معتبر نیست ...";
            }
            else if (PasswordUserTxt.Text != RePasswordUserTxt.Text)
            {
                MessageLbl.Text = "رمز کاربر همخوانی ندارد ...";
            }
            else if (string.IsNullOrEmpty(AddressUserTxt.Text) || string.IsNullOrWhiteSpace(AddressUserTxt.Text) || AddressUserTxt.Text.Count() < 5)
            {
                MessageLbl.Text = "آدرس خالی یا کمتر از 5 حرف است و معتبر نیست ...";
            }
            else if (string.IsNullOrEmpty(TitleUserTxt.Text) || string.IsNullOrWhiteSpace(TitleUserTxt.Text) || TitleUserTxt.Text.Count() < 5)
            {
                MessageLbl.Text = "عنوان کاربر معتبر نیست ...";
            }
            else if (string.IsNullOrEmpty(DescUserTxt.Text) || string.IsNullOrWhiteSpace(DescUserTxt.Text) || DescUserTxt.Text.Count() < 5)
            {
                MessageLbl.Text = "توضیحات خالی است ...";
            }
            else
            {
                User user = new User
                {
                    Name = NameUserTxt.Text,
                    Family = FamilyUserTxt.Text,
                    DisplayName = $"{NameUserTxt.Text} {FamilyUserTxt.Text}",
                    Address = AddressUserTxt.Text,
                    CreateDate=DateTime.Now,
                    Email= EmailUserTxt.Text,
                    Phone = PhoneUserTxt.Text,
                    Username = UsernameUserTxt.Text,
                    Title = TitleUserTxt.Text,
                    Description = DescUserTxt.Text,
                    IsActive = IsActiveUserCheck.Checked,
                    Password = PasswordHasher.HashPassword(PasswordUserTxt.Text),
                    Salt = CryptoPassword.GeneratePassword(PasswordUserTxt.Text).Salt,
                    Hash = CryptoPassword.GeneratePassword(PasswordUserTxt.Text).Hash,
                };

                var res =_userService.IsMatchAny(user);
                if (res.Success)
                {
                    if (ID > 0)
                    {
                        var RId =((ComboboxItem < long >)RoleIdUserCombo.SelectedItem).Value == 0 ? 3 : ((ComboboxItem < long >)RoleIdUserCombo.SelectedItem).Value;
                        await _userService.Update(user);
                        ShowDataGridView(0, 0);
                        MessageLbl.Text = "کاربر با موفقیت ذخیره شده است ...";
                        SaveUserBtn.Text = "ثبت";
                        ID = 0;
                        FormExtentions.ClearTextBoxes(this.Controls);
                    }
                    else
                    {
                        var RId =((ComboboxItem < long >)RoleIdUserCombo.SelectedItem).Value == 0 ? 3 : ((ComboboxItem < long >)RoleIdUserCombo.SelectedItem).Value;
                        _userService.InsertWithRole(user, await _roleService.GetById(RId));
                        ShowDataGridView(0, 0);
                        MessageLbl.Text = "کاربر با موفقیت ذخیره شده است ...";
                        SaveUserBtn.Text = "ثبت";
                        ID = 0;
                        FormExtentions.ClearTextBoxes(this.Controls);
                    }
                }
                else
                {
                    MessageLbl.Text = "اطلاعات کاربر تکراری است اطلاعات جدید وارد کنید نام کاربری جدید ایمیل جدید تلفن جدید ...";
                }
            }

        }

        private void SettingPanel_Load(object sender, EventArgs e)
        {
            ShowDataGridView(0, 0);
            FillRoleCombo();
        }
        //  RoleId Combo Config
        private void FillRoleCombo()
        {
            RoleService _roleService = new RoleService();
            RoleIdUserCombo.Items.Clear();
            RoleIdUserCombo.Items.Add(new ComboboxItem<long>()
            {
                Text = "--- انتخاب نقش ---",
                Value = 0
            });
            var roles = _roleService.ReadKeyValue();
            for (int i = 0; i < roles.Data.Count; i++)
            {
                RoleIdUserCombo.Items.Add(roles.Data[i]);
            }
            if (RoleIdUserCombo.Tag != null)
            {
                var index = 0;
                var id = RoleIdUserCombo.Tag;
                foreach (var i in RoleIdUserCombo.Items)
                {
                    var t = (ComboboxItem<long>)i;
                    if (t.Value == Convert.ToByte(id))
                    {
                        RoleIdUserCombo.SelectedIndex = index;
                    }
                    index++;
                }
            }
            else
            {
                RoleIdUserCombo.SelectedIndex = 0;
            }
        }

        private void PhoneUserTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void SearchBtnUsers_Click(object sender, EventArgs e)
        {
            ShowDataGridView(0, 1);
        }

        private async void ویرایشToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                UserService _userService = new UserService();
                var model = await _userService.GetById(ID);
                NameUserTxt.Text = model.Name;
                FamilyUserTxt.Text = model.Family;
                PhoneUserTxt.Text = model.Phone;
                EmailUserTxt.Text = model.Email;
                UsernameUserTxt.Text = model.Username;
                AddressUserTxt.Text = model.Address;
                TitleUserTxt.Text = model.Title;
                DescUserTxt.Text = model.Description;
                IsActiveUserCheck.Checked = model.IsActive;
                SaveUserBtn.Text = "ویرایش";
            }
        }

        private async void تغییروضعیتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                UserService _userService = new UserService();
                var model = await _userService.GetById(ID);
                model.IsActive = model.IsActive ? false : true;
                await _userService.SaveAsync();
                ID = 0;
            }

        }

        private async void حذفToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                UserService _userService = new UserService();
                var model = await _userService.GetById(ID);
                model.IsDeleted = true;
                await _userService.SaveAsync();
                ID = 0;
            }
        }

        private void DataGridUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt64(DataGridUsers.Rows[DataGridUsers.CurrentRow.Index].Cells["آیدی"].Value);
        }

        private void DataGridUsers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }
    }
}
