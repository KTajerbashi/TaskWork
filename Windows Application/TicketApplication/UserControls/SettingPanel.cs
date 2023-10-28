using BusinessLogic.Library.Extentions;
using Domain.Library.KeyValues;
using Domain.Model;
using Infrastrucure.Library.DatabaseService;
using Infrastrucure.Library.Repository.RoleService;
using Infrastrucure.Library.Repository.UserService;
using System;
using System.Linq;
using System.Windows.Forms;
using TicketApplication.Authentication;
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
            RoleQueries roleQueries = new RoleQueries();
            PrivilegeQueries privilegeQueries = new PrivilegeQueries();
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
            else if (tab == 1)
            {
                if (type == 0)
                {
                    DataGridRoles.DataSource = baseQuery.Execute(roleQueries.ShowAll(Paging.Order(Paging.Page, 20)));
                    PageRoleLbl.Text = $"تعداد رکورد {DataGridRoles.Rows.Count} | صفحه {Paging.Page + 1}";
                }
                else if (type == 1)
                {
                    DataGridRoles.DataSource = baseQuery.Execute(roleQueries.ShowAllActives(Paging.Order(Paging.Page, 20)));
                    PageRoleLbl.Text = $"تعداد رکورد {DataGridRoles.Rows.Count} | صفحه {Paging.Page + 1}";
                }
                else if (type == 2)
                {
                    DataGridRoles.DataSource = baseQuery.Execute(roleQueries.ShowAllDisActives(Paging.Order(Paging.Page, 20)));
                    PageRoleLbl.Text = $"تعداد رکورد {DataGridRoles.Rows.Count} | صفحه {Paging.Page + 1}";
                }
                else
                {
                    DataGridRoles.DataSource = baseQuery.Execute(roleQueries.SearchData(SearchRoleTxt.Text));
                    PageRoleLbl.Text = $"تعداد رکورد {DataGridRoles.Rows.Count} | صفحه {Paging.Page + 1}";
                }
            }
            else if (tab == 2)
            {
                if (type == 0)
                {
                    DataGridPrivilege.DataSource = baseQuery.Execute(privilegeQueries.ShowAll(Paging.Order(Paging.Page, 20)));
                    PagingPriLbl.Text = $"تعداد رکورد {DataGridPrivilege.Rows.Count} | صفحه {Paging.Page + 1}";
                }
                else
                {
                    DataGridPrivilege.DataSource = baseQuery.Execute(privilegeQueries.SearchData(SearchPriTxt.Text));
                    PagingPriLbl.Text = $"تعداد رکورد {DataGridPrivilege.Rows.Count} | صفحه {Paging.Page + 1}";
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
                        FillRoleCombo();
                        break;
                    }
                case 1: //  Role
                    {
                        ShowDataGridView(1, 0);
                        break;
                    }
                case 2: //  Privilege
                    {
                        ShowDataGridView(2, 0);
                        FillRolePrivilegeCombo();
                        FillPanelPrivilegeCombo();
                        break;
                    }
            }
        }

        #region User
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
                        SaveUserBtn.Text = "ذخیره";
                        ID = 0;
                        FormExtentions.ClearTextBoxes(this.Controls);
                    }
                    else
                    {
                        var RId =((ComboboxItem < long >)RoleIdUserCombo.SelectedItem).Value == 0 ? 3 : ((ComboboxItem < long >)RoleIdUserCombo.SelectedItem).Value;
                        _userService.InsertWithRole(user, await _roleService.GetById(RId));
                        ShowDataGridView(0, 0);
                        MessageLbl.Text = "کاربر با موفقیت ذخیره شده است ...";
                        SaveUserBtn.Text = "ذخیره";
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
        #endregion

        #region Role
        private async void SaveRoleBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TitleRoleTxt.Text) || string.IsNullOrWhiteSpace(TitleRoleTxt.Text) || TitleRoleTxt.Text.Count() < 3)
            {
                MsgRoleLbl.Text = "عنوان نقش معتبر نیست ...";
            }
            else if (string.IsNullOrEmpty(KeyRoleTxt.Text) || string.IsNullOrWhiteSpace(KeyRoleTxt.Text) || KeyRoleTxt.Text.Count() < 4)
            {
                MsgRoleLbl.Text = "کلید معتبر نیست ...";
            }
            else if (string.IsNullOrEmpty(DescRoleTxt.Text) || string.IsNullOrWhiteSpace(DescRoleTxt.Text) || DescRoleTxt.Text.Count() < 15)
            {
                MsgRoleLbl.Text = "توضیحات کامل نیست ...";
            }
            else
            {
                RoleService roleService = new RoleService();
                Role role = new Role()
                {
                    CreateDate = DateTime.Now,
                    Title = TitleRoleTxt.Text,
                    Key = KeyRoleTxt.Text,
                    Description = DescRoleTxt.Text,
                    IsActive=true,
                    IsDeleted=false,
                };
                if (ID > 0) //  Update
                {
                    role.UpdateBy = AppUser.UserRoleID;
                    role.UpdateDate = DateTime.Now;
                    await roleService.Update(role);
                    SaveRoleBtn.Text = "ذخیره";
                }
                else // Save
                {
                    await roleService.Insert(role);
                }
                await roleService.SaveAsync();
                ID = 0;
                ShowDataGridView(1, 0);
                FormExtentions.ClearTextBoxes(this.Controls);
            }

        }

        private void SearchRolesBtn_Click(object sender, EventArgs e)
        {
            ShowDataGridView(1, 1);
        }

        private void PrevRoleBtn_Click(object sender, EventArgs e)
        {
            Paging.Prev();
            ShowDataGridView(1, 0);
        }

        private void NextRoleBtn_Click(object sender, EventArgs e)
        {
            Paging.Next(20, DataGridRoles.Rows.Count);
            ShowDataGridView(1, 0);
        }

        private async void ویرایشToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                RoleService _roleService = new RoleService();
                var model = await _roleService.GetById(ID);
                TitleRoleTxt.Text = model.Title;
                KeyRoleTxt.Text = model.Key;
                DescRoleTxt.Text = model.Description;
                CheckIsActiveRole.Checked = model.IsActive;
                SaveRoleBtn.Text = "ویرایش";
            }
        }

        private async void تغییروضعیتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RoleService _roleService = new RoleService();
            var model = await _roleService.GetById(ID);
            model.IsActive = model.IsActive ? false : true;
            await _roleService.SaveAsync();
            ShowDataGridView(1, 0);
        }

        private async void حذفToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            RoleService _roleService = new RoleService();
            var model = await _roleService.GetById(ID);
            model.IsDeleted = true;
            await _roleService.SaveAsync();
            ShowDataGridView(1, 0);
        }

        private void DataGridRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt64(DataGridRoles.Rows[DataGridUsers.CurrentRow.Index].Cells["آیدی"].Value);
        }

        private void DataGridRoles_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                RoleContextMenu.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void نمایشغیرفعالهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDataGridView(1, 2);
        }

        private void نمایشفعالهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDataGridView(1, 1);
        }
        #endregion

        #region ComboBox Fill
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

        private void FillRolePrivilegeCombo()
        {
            RoleService _roleService = new RoleService();
            RolePrivilegeCombo.Items.Clear();
            RolePrivilegeCombo.Items.Add(new ComboboxItem<long>()
            {
                Text = "--- انتخاب نقش ---",
                Value = 0
            });
            var roles = _roleService.ReadKeyValue();
            for (int i = 0; i < roles.Data.Count; i++)
            {
                RolePrivilegeCombo.Items.Add(roles.Data[i]);
            }
            if (RolePrivilegeCombo.Tag != null)
            {
                var index = 0;
                var id = RolePrivilegeCombo.Tag;
                foreach (var i in RolePrivilegeCombo.Items)
                {
                    var t = (ComboboxItem<long>)i;
                    if (t.Value == Convert.ToByte(id))
                    {
                        RolePrivilegeCombo.SelectedIndex = index;
                    }
                    index++;
                }
            }
            else
            {
                RolePrivilegeCombo.SelectedIndex = 0;
            }
        }

        private void FillPanelPrivilegeCombo()
        {
            PanelPrivilegeCombo.Items.Clear();
            PanelPrivilegeCombo.Items.Add(new ComboboxItem<int>
            {
                Text = "--- انتخاب کنید ---",
                Value = 0
            });
            PanelPrivilegeCombo.SelectedIndex = 0;
            var res = this.ParentForm.Controls["AsidePanel"].Controls;
            int tag = 1;
            foreach (var i in res)
            {
                if (i.GetType().Name == "Button")
                {
                    var txt = ((Button)i).Text;
                    var comItem = new ComboboxItem<int>
                    {
                        Text= txt,
                        Value = tag
                    };
                    tag++;
                    PanelPrivilegeCombo.Items.Add(comItem);
                }
            }

        }

        #endregion

        private async void SavePriBtn_Click(object sender, EventArgs e)
        {
            RoleService roleService = new RoleService();
            PrivilegeServices privilegeServices = new PrivilegeServices();
            Privilege privilege = new Privilege()
            {
                CreateDate = DateTime.Now,
                Description = "",
                Title = "",
                IsActive = true,
                IsDeleted = false,
                Read = ReadPriCheck.Checked,
                Write = WritePriCheck.Checked,
                Update = UpdatePriCheck.Checked,
                Delete = DeletePriCheck.Checked,
                Panel = ((ComboboxItem<int>)PanelPrivilegeCombo.SelectedItem).Text
            };
            await privilegeServices.InsertAsync(privilege);

            var role = await roleService.GetById(((ComboboxItem<long>)RolePrivilegeCombo.SelectedItem).Value);
            role.PrivilegeID = privilege.ID;
            await roleService.Update(role);
            ShowDataGridView(2, 0);
            FormExtentions.ClearTextBoxes(this.Controls);
        }
    }
}
