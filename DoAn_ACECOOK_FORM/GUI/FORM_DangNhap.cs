using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using System;
using System.Linq;
using BUS;
using DTO;

namespace GUI
{
    public partial class FORM_DangNhap : Form
    {
        private BUS_NhanVien bus_nhanvien = new BUS_NhanVien();

        private static Random random = new Random();

        public FORM_DangNhap()
        {
            InitializeComponent();
        }

        private void FORM_DangNhap_Load(object sender, EventArgs e)
        {
            txt_MatKhau.UseSystemPasswordChar = true;
        }

        private void pictureBox_AnHienMatKhau_Click(object sender, EventArgs e)
        {
            if (txt_MatKhau.UseSystemPasswordChar)
            {
                pictureBox_AnHienMatKhau.Image = Properties.Resources.hien;
                txt_MatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                pictureBox_AnHienMatKhau.Image = Properties.Resources.an;
                txt_MatKhau.UseSystemPasswordChar = true;
            }
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (txt_MatKhau.Text.Trim().Equals("") || txt_TenDangNhap.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Tên đăng nhập hoặc mật khẩu không được để trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DTO_NhanVien dto = bus_nhanvien.GetByID(txt_TenDangNhap.Text.Trim());
                if (dto != null)
                {
                    if (txt_MatKhau.Text.Trim().Equals(dto.MatKhau))
                    {
                        FORM_KhungTrang gui = new FORM_KhungTrang(txt_TenDangNhap.Text.Trim());
                        this.Hide();
                        gui.Show();
                        gui.FormClosing += Gui_FormClosing;
                    }
                    else
                    {
                        MessageBox.Show(this, "Sai mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Tên tài khoản không tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Gui_FormClosing(object? sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void SendEmail(string youremail)
        {
            try
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                string newPassword = new string(Enumerable.Repeat(chars, 5)
                    .Select(s => s[random.Next(s.Length)]).ToArray());

                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Your Name", "your_email@gmail.com"));
                message.To.Add(new MailboxAddress("Recipient Name", youremail)); // Fix email parameter

                message.Subject = "Khôi phục mật khẩu";
                message.Body = new TextPart("plain")
                {
                    Text = $"Mật khẩu mới của bạn là: {newPassword}"
                };

                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.your_email_provider.com", 587, false); // Set StartTls to false if not supported
                    client.Authenticate("your_email@gmail.com", "your_password");
                    client.Send(message);
                    client.Disconnect(true);
                }

                MessageBox.Show("Email sent successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}");
            }
        }



        private void btn_QuenMatKhau_Click(object sender, EventArgs e)
        {
            if (txt_TenDangNhap.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Tên đăng nhập không được để trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DTO_NhanVien dto = bus_nhanvien.GetByID(txt_TenDangNhap.Text.Trim());
                if (dto != null)
                {
                    SendEmail(dto.Email);
                    // MessageBox.Show(this, "Vui lòng kiểm tra Email để coi mật khẩu mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "Tên tài khoản không tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
