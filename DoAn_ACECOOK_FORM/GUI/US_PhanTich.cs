using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using ClosedXML.Excel;
using DTO;
using System.Runtime.InteropServices;
using Aspose.Words;
using Aspose.Words.Drawing;
using Aspose.Words.Tables;
using DevExpress.Charts.Native;
using DevExpress.XtraDiagram.Base;
using System.Windows.Media;
using Microsoft.Identity.Client;

namespace GUI
{
    public partial class US_PhanTich : UserControl
    {
        BUS_OLAP_MDX bus_olap;
        BUS_KhuVuc bus_khuvuc;
        BUS_ChiNhanh bus_chinhanh;

        public US_PhanTich()
        {
            InitializeComponent();
            bus_olap = new BUS_OLAP_MDX();
            bus_khuvuc = new BUS_KhuVuc();
            bus_chinhanh = new BUS_ChiNhanh();
        }

        private void loadKhuVuc()
        {
            List<DTO_KhuVuc> listKhuVuc = new List<DTO_KhuVuc>();
            listKhuVuc.Add(new DTO_KhuVuc { MaKhuVuc = "All", TenKhuVuc = "Tất cả khu vực" });

            listKhuVuc.AddRange(bus_khuvuc.GetAll());

            cbo_KhuVuc.DataSource = listKhuVuc;
            cbo_KhuVuc.DisplayMember = "TenKhuVuc";
            cbo_KhuVuc.ValueMember = "MaKhuVuc";

            cbo_KhuVuc.Text = "Hãy chọn khu vực";
            cbo_ChiNhanh.Text = "Hãy chọn khu vực";
            cbo_KhuVuc.Enabled = false;
            cbo_ChiNhanh.Enabled = false;

            lbl_ChieuKhuVuc.Text = "null";

            //lbl_ChieuKhuVuc.Text = cbo_KhuVuc.SelectedValue.ToString();
        }


        //private void ExportToWord(DataGridView dataGridView, string filePath)
        //{
        //    try
        //    {
        //        // Tạo một document mới
        //        var doc = new Document();
        //        var builder = new DocumentBuilder(doc);

        //        // Thêm tiêu đề
        //        builder.ParagraphFormat.Alignment = ParagraphAlignment.Center;
        //        builder.Font.Bold = true;
        //        builder.Font.Size = 14;
        //        builder.Writeln("Dữ liệu từ DataGridView");

        //        // Thêm dữ liệu
        //        foreach (DataGridViewRow row in dataGridView.Rows)
        //        {
        //            if (!row.IsNewRow) // Bỏ qua dòng mới
        //            {
        //                foreach (DataGridViewCell cell in row.Cells)
        //                {
        //                    builder.Write(cell.Value?.ToString() ?? "");
        //                    builder.Write("\t"); // Thêm tab để cách các ô
        //                }
        //                builder.Writeln(); // Xuống dòng
        //            }
        //        }

        //        // Lưu document vào file
        //        doc.Save(filePath);
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show("Lỗi khi xuất dữ liệu sang Word: " + e.Message);
        //    }
        //}

        private void ExportToWord(DataGridView dataGridView, string filePath)
        {
            try
            {
                // Tạo một document mới
                var doc = new Document();
                var builder = new DocumentBuilder(doc);

                // Thêm tiêu đề
                builder.ParagraphFormat.Alignment = ParagraphAlignment.Center;
                builder.Font.Bold = true;
                builder.Font.Size = 14;
                builder.Writeln("Dữ liệu từ DataGridView");

                // Thêm tên cột
                builder.ParagraphFormat.Alignment = ParagraphAlignment.Left;
                builder.Font.Bold = true;
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    builder.Write(column.HeaderText);
                    builder.Write("\t");
                }
                builder.Writeln();

                // Thêm dữ liệu
                builder.ParagraphFormat.Alignment = ParagraphAlignment.Left;
                builder.Font.Bold = false;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.IsNewRow) // Bỏ qua dòng mới
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            builder.Write(cell.Value?.ToString() ?? "");
                            builder.Write("\t");
                        }
                        builder.Writeln();
                    }
                }

                // Lưu document vào file
                doc.Save(filePath);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi khi xuất dữ liệu sang Word: " + e.Message);
            }
        }


        //private void ExportToWord(DataGridView dataGridView, string filePath)
        //{
        //    try
        //    {
        //        // Tạo một document mới
        //        var doc = new Document();
        //        var builder = new DocumentBuilder(doc);

        //        // Thêm tiêu đề
        //        builder.ParagraphFormat.Alignment = ParagraphAlignment.Center;
        //        builder.Font.Bold = true;
        //        builder.Font.Size = 14;
        //        builder.Writeln("Dữ liệu từ DataGridView");

        //        // Tạo bảng
        //        Table table = builder.StartTable();
        //        table.Alignment = TableAlignment.Left;

        //        // Thêm tên cột
        //        foreach (DataGridViewColumn column in dataGridView.Columns)
        //        {
        //            builder.InsertCell();
        //            builder.ParagraphFormat.Alignment = ParagraphAlignment.Center;
        //            builder.Write(column.HeaderText);
        //        }
        //        builder.EndRow();

        //        // Thêm dữ liệu
        //        foreach (DataGridViewRow row in dataGridView.Rows)
        //        {
        //            if (!row.IsNewRow) // Bỏ qua dòng mới
        //            {
        //                foreach (DataGridViewCell cell in row.Cells)
        //                {
        //                    builder.InsertCell();
        //                    builder.Write(cell.Value?.ToString() ?? "");
        //                }
        //                builder.EndRow();
        //            }
        //        }

        //        // Lưu document vào file
        //        doc.Save(filePath);
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show("Lỗi khi xuất dữ liệu sang Word: " + e.Message);
        //    }
        //}

        private void ExportToExcel(DataGridView dataGridView, string filePath)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.AddWorksheet("Sheet1");

                    // Ghi tiêu đề cột
                    for (int i = 0; i < dataGridView.ColumnCount; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = dataGridView.Columns[i].HeaderText;
                    }

                    // Ghi dữ liệu từ DataGridView
                    for (int i = 0; i < dataGridView.RowCount; i++)
                    {
                        for (int j = 0; j < dataGridView.ColumnCount; j++)
                        {
                            if (dataGridView.Rows[i].Cells[j].Value != null)
                            {
                                worksheet.Cell(i + 2, j + 1).Value = dataGridView.Rows[i].Cells[j].Value.ToString();
                            }
                            else
                            {
                                worksheet.Cell(i + 2, j + 1).Value = string.Empty;
                            }
                        }
                    }

                    workbook.SaveAs(filePath);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi khi thực hiện truy vấn MDX: " + e.Message);
            }

        }

        private void US_PhanTich_Load(object sender, EventArgs e)
        {
            Image myImage = Properties.Resources.word;
            Bitmap resizedImage = new Bitmap(myImage, new Size(30, 30));
            btn_XuatWord.Image = resizedImage;

            Image myImage2 = Properties.Resources.excel;
            Bitmap resizedImage2 = new Bitmap(myImage2, new Size(30, 30));
            btn_XuatExcel.Image = resizedImage2;

            Image myImage3 = Properties.Resources.action;
            Bitmap resizedImage3 = new Bitmap(myImage3, new Size(30, 30));
            btn_PhanTich.Image = resizedImage3;

            loadKhuVuc();
            lbl_TuNam.Text = "null";
            lbl_DenNam.Text = "null";
            dateTimePicker_TuNam.Enabled = false;
            dateTimePicker_DenNam.Enabled = false;
        }

        private void btn_LamMoiChucNang_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();

            InitializeComponent();

            US_PhanTich_Load(sender, e);
        }

        private void btn_XuatExcel_Click(object sender, EventArgs e)
        {
            string excelFilePath = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.DefaultExt = ".xlsx";
            saveFileDialog.FileName = "MyACECOOKExcelFile";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                excelFilePath = saveFileDialog.FileName;
                ExportToExcel(dataGridView_DuLieuDaPhanTich, excelFilePath);
                MessageBox.Show("Dữ liệu đã được xuất ra file Excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_XuatWord_Click(object sender, EventArgs e)
        {
            string wordFilePath = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Word Documents (.docx)|*.docx";
            saveFileDialog.DefaultExt = ".docx";
            saveFileDialog.FileName = "MyACECOOKWordFile.docx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                wordFilePath = saveFileDialog.FileName;
                ExportToWord(dataGridView_DuLieuDaPhanTich, wordFilePath);
                MessageBox.Show("Dữ liệu đã được xuất ra file Word.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbo_ChiNhanh_MouseClick(object sender, MouseEventArgs e)
        {
            if (cbo_KhuVuc.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn Khu vực trước khi chọn Chi Nhánh.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cbo_ChiNhanh.ForeColor = System.Drawing.Color.Black;
            }
        }

        //  Phân tích chiều theo từng loại
        //private void LoadData_KhuVuc_ChiNhanh_DuLieu(string chieukhuvuc, string chieudulieu)
        //{
        //    try
        //    {
        //        string tungay = lbl_TuNgay.Text;
        //        string denngay = lbl_DenNgay.Text;

        //        if (chieukhuvuc != "null" && chieudulieu != "null")
        //        {
        //            string mdxQuery = "SELECT NON EMPTY { [Measures].[" + chieudulieu + "] } ON COLUMNS, " +
        //                              "NON EMPTY { ([Dim Chi Nhanh].[Ten Khu Vuc].[Ten Khu Vuc].members ) } " +
        //                              "DIMENSION PROPERTIES MEMBER_CAPTION ON ROWS " +
        //                              "FROM [DB ACECOOK DDS] " +
        //                              "WHERE ([Dim Thoi Gian].[Nam].&[" + tungay + "] : " +
        //                              "[Dim Thoi Gian].[Nam].&[" + denngay + "]);";

        //            if (chieukhuvuc != "All")
        //            {
        //                mdxQuery = "SELECT NON EMPTY { [Measures].[" + chieudulieu + "] } ON COLUMNS, " +
        //                            "NON EMPTY { ([Dim Chi Nhanh].[Ten Khu Vuc].[Ten Khu Vuc].members * " +
        //                            "[Dim Chi Nhanh].[Ten Chi Nhanh].[Ten Chi Nhanh].members )} " +
        //                            "DIMENSION PROPERTIES MEMBER_CAPTION ON ROWS " +
        //                            "FROM [DB ACECOOK DDS] " +
        //                            "WHERE ([Dim Chi Nhanh].[Ma Khu Vuc].&[" + chieukhuvuc + "]) * " +
        //                            "([Dim Thoi Gian].[Nam].&[" + tungay + "] : " +
        //                            "[Dim Thoi Gian].[Nam].&[" + denngay + "]);";

        //                if (lbl_ChieuChiNhanh.Text != "All" && lbl_ChieuChiNhanh.Text != "null")
        //                {
        //                    mdxQuery = "SELECT NON EMPTY { [Measures].[" + chieudulieu + "] } ON COLUMNS, " +
        //                            "NON EMPTY { ([Dim Chi Nhanh].[Ten Khu Vuc].[Ten Khu Vuc].members * " +
        //                            "[Dim Chi Nhanh].[Ten Chi Nhanh].[Ten Chi Nhanh].members )} " +
        //                            "DIMENSION PROPERTIES MEMBER_CAPTION ON ROWS " +
        //                            "FROM [DB ACECOOK DDS] " +
        //                            "WHERE ([Dim Chi Nhanh].[Ma Chi Nhanh].&[" + lbl_ChieuChiNhanh.Text + "]) * " +
        //                            "([Dim Thoi Gian].[Nam].&[" + tungay + "] : " +
        //                            "[Dim Thoi Gian].[Nam].&[" + denngay + "]);";
        //                }
        //            }

        //            dataGridView_DuLieuDaPhanTich.DataSource = bus_olap.GetMDXData(mdxQuery);

        //            if (dataGridView_DuLieuDaPhanTich.Rows.Count > 0)
        //            {
        //                if (dataGridView_DuLieuDaPhanTich.Columns.Count == 2)
        //                {
        //                    dataGridView_DuLieuDaPhanTich.Columns[0].HeaderText = "Ten Khu Vuc";
        //                    dataGridView_DuLieuDaPhanTich.Columns[1].HeaderText = chieudulieu;
        //                }
        //                if (dataGridView_DuLieuDaPhanTich.Columns.Count == 3)
        //                {
        //                    dataGridView_DuLieuDaPhanTich.Columns[0].HeaderText = "Ten Khu Vuc";
        //                    dataGridView_DuLieuDaPhanTich.Columns[1].HeaderText = "Ten Chi Nhanh";
        //                    dataGridView_DuLieuDaPhanTich.Columns[2].HeaderText = chieudulieu;
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show("Lỗi khi thực hiện truy vấn MDX: " + e.Message);
        //    }

        //}

        private void LoadData_KhuVuc_ChiNhanh_DuLieu_ThoiGian(string chieukhuvuc, string chieudulieu, string chieuthoigian)
        {
            try
            {
                string tungay = lbl_TuNam.Text;
                string denngay = lbl_DenNam.Text;

                string themchieuThoiGian = "";
                if (lbl_ChieuThoiGian.Text == "Nam")
                {
                    themchieuThoiGian = "[Dim Thoi Gian].[Nam].[Nam].members";
                }
                if (lbl_ChieuThoiGian.Text == "Quy")
                {
                    themchieuThoiGian = "[Dim Thoi Gian].[Nam].[Nam].members * [Dim Thoi Gian].[Quy].[Quy].members";
                }
                if (lbl_ChieuThoiGian.Text == "Thang")
                {
                    themchieuThoiGian = "[Dim Thoi Gian].[Nam].[Nam].members * [Dim Thoi Gian].[Thang].[Thang].members";
                }

                if (chieukhuvuc != "null" && chieudulieu != "null")
                {
                    string mdxQuery = "SELECT NON EMPTY { [Measures].[" + chieudulieu + "] } ON COLUMNS, " +
                                      "NON EMPTY { ([Dim Chi Nhanh].[Ten Khu Vuc].[Ten Khu Vuc].members * " +
                                      themchieuThoiGian + ") } " +
                                      "DIMENSION PROPERTIES MEMBER_CAPTION ON ROWS " +
                                      "FROM [DB ACECOOK DDS] " +
                                      "WHERE ([Dim Thoi Gian].[Nam].&[" + tungay + "] : " +
                                      "[Dim Thoi Gian].[Nam].&[" + denngay + "]);";

                    if (chieukhuvuc != "All")
                    {
                        mdxQuery = "SELECT NON EMPTY { [Measures].[" + chieudulieu + "] } ON COLUMNS, " +
                                    "NON EMPTY { ([Dim Chi Nhanh].[Ten Khu Vuc].[Ten Khu Vuc].members * " +
                                    "[Dim Chi Nhanh].[Ten Chi Nhanh].[Ten Chi Nhanh].members *" +
                                    themchieuThoiGian + ")} " +
                                    "DIMENSION PROPERTIES MEMBER_CAPTION ON ROWS " +
                                    "FROM [DB ACECOOK DDS] " +
                                    "WHERE ([Dim Chi Nhanh].[Ma Khu Vuc].&[" + chieukhuvuc + "]) * " +
                                    "([Dim Thoi Gian].[Nam].&[" + tungay + "] : " +
                                    "[Dim Thoi Gian].[Nam].&[" + denngay + "]);";

                        if (lbl_ChieuChiNhanh.Text != "All" && lbl_ChieuChiNhanh.Text != "null")
                        {
                            mdxQuery = "SELECT NON EMPTY { [Measures].[" + chieudulieu + "] } ON COLUMNS, " +
                                    "NON EMPTY { ([Dim Chi Nhanh].[Ten Khu Vuc].[Ten Khu Vuc].members * " +
                                    "[Dim Chi Nhanh].[Ten Chi Nhanh].[Ten Chi Nhanh].members *" +
                                    themchieuThoiGian + ")} " +
                                    "DIMENSION PROPERTIES MEMBER_CAPTION ON ROWS " +
                                    "FROM [DB ACECOOK DDS] " +
                                    "WHERE ([Dim Chi Nhanh].[Ma Chi Nhanh].&[" + lbl_ChieuChiNhanh.Text + "]) * " +
                                    "([Dim Thoi Gian].[Nam].&[" + tungay + "] : " +
                                    "[Dim Thoi Gian].[Nam].&[" + denngay + "]);";
                        }
                    }

                    dataGridView_DuLieuDaPhanTich.DataSource = bus_olap.GetMDXData(mdxQuery);

                    if (dataGridView_DuLieuDaPhanTich.Rows.Count > 0)
                    {
                        if (lbl_ChieuThoiGian.Text == "Nam" && lbl_ChieuKhuVuc.Text == "All")
                        {
                            dataGridView_DuLieuDaPhanTich.Columns[0].HeaderText = "Ten Khu Vuc";
                            dataGridView_DuLieuDaPhanTich.Columns[1].HeaderText = "Nam";
                            dataGridView_DuLieuDaPhanTich.Columns[2].HeaderText = chieudulieu;
                        }
                        if (lbl_ChieuThoiGian.Text == "Quy" || lbl_ChieuThoiGian.Text == "Thang" && lbl_ChieuKhuVuc.Text == "All")
                        {
                            dataGridView_DuLieuDaPhanTich.Columns[0].HeaderText = "Ten Khu Vuc";
                            dataGridView_DuLieuDaPhanTich.Columns[1].HeaderText = "Nam";
                            dataGridView_DuLieuDaPhanTich.Columns[2].HeaderText = lbl_ChieuThoiGian.Text;
                            dataGridView_DuLieuDaPhanTich.Columns[3].HeaderText = chieudulieu;
                        }
                        if (chieukhuvuc != "All" && lbl_ChieuThoiGian.Text == "Nam")
                        {
                            dataGridView_DuLieuDaPhanTich.Columns[0].HeaderText = "Ten Khu Vuc";
                            dataGridView_DuLieuDaPhanTich.Columns[1].HeaderText = "Ten Chi Nhanh";
                            dataGridView_DuLieuDaPhanTich.Columns[2].HeaderText = lbl_ChieuThoiGian.Text;
                            dataGridView_DuLieuDaPhanTich.Columns[3].HeaderText = chieudulieu;
                        }
                        if (chieukhuvuc != "All" && lbl_ChieuThoiGian.Text == "Quy" || lbl_ChieuThoiGian.Text == "Thang")
                        {
                            dataGridView_DuLieuDaPhanTich.Columns[0].HeaderText = "Ten Khu Vuc";
                            dataGridView_DuLieuDaPhanTich.Columns[1].HeaderText = "Ten Chi Nhanh";
                            dataGridView_DuLieuDaPhanTich.Columns[2].HeaderText = "Nam";
                            dataGridView_DuLieuDaPhanTich.Columns[3].HeaderText = chieuthoigian;
                            dataGridView_DuLieuDaPhanTich.Columns[4].HeaderText = chieudulieu;
                        }

                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi khi thực hiện truy vấn MDX: " + e.Message);
            }
        }

        private void LoadData_KhuVuc_ChiNhanh_DuLieu_SanPham(string chieukhuvuc, string chieudulieu, string chieusanpham)
        {
            try
            {
                string tungay = lbl_TuNam.Text;
                string denngay = lbl_DenNam.Text;

                string themchieu = "[Dim San Pham].[Ten San Pham].[Ten San Pham].members";

                if (chieukhuvuc != "null" && chieudulieu != "null")
                {
                    string mdxQuery = "SELECT NON EMPTY { [Measures].[" + chieudulieu + "] } ON COLUMNS, " +
                                      "NON EMPTY { ([Dim Chi Nhanh].[Ten Khu Vuc].[Ten Khu Vuc].members * " +
                                      themchieu + ") } " +
                                      "DIMENSION PROPERTIES MEMBER_CAPTION ON ROWS " +
                                      "FROM [DB ACECOOK DDS] " +
                                      "WHERE ([Dim Thoi Gian].[Nam].&[" + tungay + "] : " +
                                      "[Dim Thoi Gian].[Nam].&[" + denngay + "]);";

                    if (chieukhuvuc != "All")
                    {
                        mdxQuery = "SELECT NON EMPTY { [Measures].[" + chieudulieu + "] } ON COLUMNS, " +
                                    "NON EMPTY { ([Dim Chi Nhanh].[Ten Khu Vuc].[Ten Khu Vuc].members * " +
                                    "[Dim Chi Nhanh].[Ten Chi Nhanh].[Ten Chi Nhanh].members *" +
                                    themchieu + ")} " +
                                    "DIMENSION PROPERTIES MEMBER_CAPTION ON ROWS " +
                                    "FROM [DB ACECOOK DDS] " +
                                    "WHERE ([Dim Chi Nhanh].[Ma Khu Vuc].&[" + chieukhuvuc + "]) * " +
                                    "([Dim Thoi Gian].[Nam].&[" + tungay + "] : " +
                                    "[Dim Thoi Gian].[Nam].&[" + denngay + "]);";

                        if (lbl_ChieuChiNhanh.Text != "All" && lbl_ChieuChiNhanh.Text != "null")
                        {
                            mdxQuery = "SELECT NON EMPTY { [Measures].[" + chieudulieu + "] } ON COLUMNS, " +
                                    "NON EMPTY { ([Dim Chi Nhanh].[Ten Khu Vuc].[Ten Khu Vuc].members * " +
                                    "[Dim Chi Nhanh].[Ten Chi Nhanh].[Ten Chi Nhanh].members *" +
                                    themchieu + ")} " +
                                    "DIMENSION PROPERTIES MEMBER_CAPTION ON ROWS " +
                                    "FROM [DB ACECOOK DDS] " +
                                    "WHERE ([Dim Chi Nhanh].[Ma Chi Nhanh].&[" + lbl_ChieuChiNhanh.Text + "]) * " +
                                    "([Dim Thoi Gian].[Nam].&[" + tungay + "] : " +
                                    "[Dim Thoi Gian].[Nam].&[" + denngay + "]);";
                        }
                    }

                    dataGridView_DuLieuDaPhanTich.DataSource = bus_olap.GetMDXData(mdxQuery);

                    if (dataGridView_DuLieuDaPhanTich.Rows.Count > 0)
                    {
                        if (lbl_ChieuKhuVuc.Text == "All")
                        {
                            dataGridView_DuLieuDaPhanTich.Columns[0].HeaderText = "Ten Khu Vuc";
                            dataGridView_DuLieuDaPhanTich.Columns[1].HeaderText = lbl_ChieuSanPham.Text;
                            dataGridView_DuLieuDaPhanTich.Columns[2].HeaderText = chieudulieu;
                        }
                        if (chieukhuvuc != "All")
                        {
                            dataGridView_DuLieuDaPhanTich.Columns[0].HeaderText = "Ten Khu Vuc";
                            dataGridView_DuLieuDaPhanTich.Columns[1].HeaderText = "Ten Chi Nhanh";
                            dataGridView_DuLieuDaPhanTich.Columns[2].HeaderText = lbl_ChieuSanPham.Text;
                            dataGridView_DuLieuDaPhanTich.Columns[3].HeaderText = chieudulieu;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi khi thực hiện truy vấn MDX: " + e.Message);
            }
        }

        private void LoadData_KhuVuc_ChiNhanh_DuLieu_KhachHang(string chieukhuvuc, string chieudulieu, string chieukhachhang)
        {
            try
            {
                string tungay = lbl_TuNam.Text;
                string denngay = lbl_DenNam.Text;

                string themchieu = "";
                if (chieukhachhang == "Tuoi")
                {
                    themchieu = "[Dim Khach Hang].[Tuoi].[Tuoi].members";
                }
                if (chieukhachhang == "Ten Loai Khach Hang")
                {
                    themchieu = "[Dim Khach Hang].[Ten Loai Khach Hang].[Ten Loai Khach Hang].members";
                }

                if (chieukhuvuc != "null" && chieudulieu != "null")
                {
                    string mdxQuery = "SELECT NON EMPTY { [Measures].[" + chieudulieu + "] } ON COLUMNS, " +
                                      "NON EMPTY { ([Dim Chi Nhanh].[Ten Khu Vuc].[Ten Khu Vuc].members * " +
                                      themchieu + ") } " +
                                      "DIMENSION PROPERTIES MEMBER_CAPTION ON ROWS " +
                                      "FROM [DB ACECOOK DDS] " +
                                      "WHERE ([Dim Thoi Gian].[Nam].&[" + tungay + "] : " +
                                      "[Dim Thoi Gian].[Nam].&[" + denngay + "]);";

                    if (chieukhuvuc != "All")
                    {
                        mdxQuery = "SELECT NON EMPTY { [Measures].[" + chieudulieu + "] } ON COLUMNS, " +
                                    "NON EMPTY { ([Dim Chi Nhanh].[Ten Khu Vuc].[Ten Khu Vuc].members * " +
                                    "[Dim Chi Nhanh].[Ten Chi Nhanh].[Ten Chi Nhanh].members *" +
                                    themchieu + ")} " +
                                    "DIMENSION PROPERTIES MEMBER_CAPTION ON ROWS " +
                                    "FROM [DB ACECOOK DDS] " +
                                    "WHERE ([Dim Chi Nhanh].[Ma Khu Vuc].&[" + chieukhuvuc + "]) * " +
                                    "([Dim Thoi Gian].[Nam].&[" + tungay + "] : " +
                                    "[Dim Thoi Gian].[Nam].&[" + denngay + "]);";

                        if (lbl_ChieuChiNhanh.Text != "All" && lbl_ChieuChiNhanh.Text != "null")
                        {
                            mdxQuery = "SELECT NON EMPTY { [Measures].[" + chieudulieu + "] } ON COLUMNS, " +
                                    "NON EMPTY { ([Dim Chi Nhanh].[Ten Khu Vuc].[Ten Khu Vuc].members * " +
                                    "[Dim Chi Nhanh].[Ten Chi Nhanh].[Ten Chi Nhanh].members *" +
                                    themchieu + ")} " +
                                    "DIMENSION PROPERTIES MEMBER_CAPTION ON ROWS " +
                                    "FROM [DB ACECOOK DDS] " +
                                    "WHERE ([Dim Chi Nhanh].[Ma Chi Nhanh].&[" + lbl_ChieuChiNhanh.Text + "]) * " +
                                    "([Dim Thoi Gian].[Nam].&[" + tungay + "] : " +
                                    "[Dim Thoi Gian].[Nam].&[" + denngay + "]);";
                        }
                    }

                    dataGridView_DuLieuDaPhanTich.DataSource = bus_olap.GetMDXData(mdxQuery);

                    if (dataGridView_DuLieuDaPhanTich.Rows.Count > 0)
                    {
                        if (lbl_ChieuKhuVuc.Text == "All")
                        {
                            dataGridView_DuLieuDaPhanTich.Columns[0].HeaderText = "Ten Khu Vuc";
                            dataGridView_DuLieuDaPhanTich.Columns[1].HeaderText = lbl_ChieuKhachHang.Text;
                            dataGridView_DuLieuDaPhanTich.Columns[2].HeaderText = chieudulieu;
                        }
                        if (chieukhuvuc != "All")
                        {
                            dataGridView_DuLieuDaPhanTich.Columns[0].HeaderText = "Ten Khu Vuc";
                            dataGridView_DuLieuDaPhanTich.Columns[1].HeaderText = "Ten Chi Nhanh";
                            dataGridView_DuLieuDaPhanTich.Columns[2].HeaderText = lbl_ChieuKhachHang.Text;
                            dataGridView_DuLieuDaPhanTich.Columns[3].HeaderText = chieudulieu;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi khi thực hiện truy vấn MDX: " + e.Message);
            }
        }

        private void LoadData_KhuVuc_ChiNhanh_DuLieu_SanPham_ThoiGian(string chieukhuvuc, string chieudulieu, string chieusanpham, string chieuthoigian)
        {
            try
            {
                string tungay = lbl_TuNam.Text;
                string denngay = lbl_DenNam.Text;

                string themchieu = "";
                if (lbl_ChieuThoiGian.Text == "Nam")
                {
                    themchieu = "[Dim Thoi Gian].[Nam].[Nam].members * [Dim San Pham].[Ten San Pham].[Ten San Pham].members";
                }
                if (lbl_ChieuThoiGian.Text == "Quy")
                {
                    themchieu = "[Dim Thoi Gian].[Nam].[Nam].members * [Dim Thoi Gian].[Quy].[Quy].members * [Dim San Pham].[Ten San Pham].[Ten San Pham].members";
                }
                if (lbl_ChieuThoiGian.Text == "Thang")
                {
                    themchieu = "[Dim Thoi Gian].[Nam].[Nam].members * [Dim Thoi Gian].[Thang].[Thang].members * [Dim San Pham].[Ten San Pham].[Ten San Pham].members";
                }

                if (chieukhuvuc != "null" && chieudulieu != "null")
                {
                    string mdxQuery = "SELECT NON EMPTY { [Measures].[" + chieudulieu + "] } ON COLUMNS, " +
                                      "NON EMPTY { ([Dim Chi Nhanh].[Ten Khu Vuc].[Ten Khu Vuc].members * " +
                                      themchieu + ") } " +
                                      "DIMENSION PROPERTIES MEMBER_CAPTION ON ROWS " +
                                      "FROM [DB ACECOOK DDS] " +
                                      "WHERE ([Dim Thoi Gian].[Nam].&[" + tungay + "] : " +
                                      "[Dim Thoi Gian].[Nam].&[" + denngay + "]);";

                    if (chieukhuvuc != "All")
                    {
                        mdxQuery = "SELECT NON EMPTY { [Measures].[" + chieudulieu + "] } ON COLUMNS, " +
                                    "NON EMPTY { ([Dim Chi Nhanh].[Ten Khu Vuc].[Ten Khu Vuc].members * " +
                                    "[Dim Chi Nhanh].[Ten Chi Nhanh].[Ten Chi Nhanh].members *" +
                                    themchieu + ")} " +
                                    "DIMENSION PROPERTIES MEMBER_CAPTION ON ROWS " +
                                    "FROM [DB ACECOOK DDS] " +
                                    "WHERE ([Dim Chi Nhanh].[Ma Khu Vuc].&[" + chieukhuvuc + "]) * " +
                                    "([Dim Thoi Gian].[Nam].&[" + tungay + "] : " +
                                    "[Dim Thoi Gian].[Nam].&[" + denngay + "]);";

                        if (lbl_ChieuChiNhanh.Text != "All" && lbl_ChieuChiNhanh.Text != "null")
                        {
                            mdxQuery = "SELECT NON EMPTY { [Measures].[" + chieudulieu + "] } ON COLUMNS, " +
                                    "NON EMPTY { ([Dim Chi Nhanh].[Ten Khu Vuc].[Ten Khu Vuc].members * " +
                                    "[Dim Chi Nhanh].[Ten Chi Nhanh].[Ten Chi Nhanh].members *" +
                                    themchieu + ")} " +
                                    "DIMENSION PROPERTIES MEMBER_CAPTION ON ROWS " +
                                    "FROM [DB ACECOOK DDS] " +
                                    "WHERE ([Dim Chi Nhanh].[Ma Chi Nhanh].&[" + lbl_ChieuChiNhanh.Text + "]) * " +
                                    "([Dim Thoi Gian].[Nam].&[" + tungay + "] : " +
                                    "[Dim Thoi Gian].[Nam].&[" + denngay + "]);";
                        }
                    }

                    dataGridView_DuLieuDaPhanTich.DataSource = bus_olap.GetMDXData(mdxQuery);

                    if (dataGridView_DuLieuDaPhanTich.Rows.Count > 0)
                    {
                        if (lbl_ChieuThoiGian.Text == "Nam" && lbl_ChieuKhuVuc.Text == "All")
                        {
                            dataGridView_DuLieuDaPhanTich.Columns[0].HeaderText = "Ten Khu Vuc";
                            dataGridView_DuLieuDaPhanTich.Columns[1].HeaderText = "Nam";
                            dataGridView_DuLieuDaPhanTich.Columns[2].HeaderText = chieusanpham;
                            dataGridView_DuLieuDaPhanTich.Columns[3].HeaderText = chieudulieu;
                        }
                        if (lbl_ChieuThoiGian.Text == "Quy" || lbl_ChieuThoiGian.Text == "Thang" && lbl_ChieuKhuVuc.Text == "All")
                        {
                            dataGridView_DuLieuDaPhanTich.Columns[0].HeaderText = "Ten Khu Vuc";
                            dataGridView_DuLieuDaPhanTich.Columns[1].HeaderText = "Nam";
                            dataGridView_DuLieuDaPhanTich.Columns[2].HeaderText = lbl_ChieuThoiGian.Text;
                            dataGridView_DuLieuDaPhanTich.Columns[3].HeaderText = chieusanpham;
                            dataGridView_DuLieuDaPhanTich.Columns[4].HeaderText = chieudulieu;
                        }
                        if (chieukhuvuc != "All" && lbl_ChieuThoiGian.Text == "Nam")
                        {
                            dataGridView_DuLieuDaPhanTich.Columns[0].HeaderText = "Ten Khu Vuc";
                            dataGridView_DuLieuDaPhanTich.Columns[1].HeaderText = "Ten Chi Nhanh";
                            dataGridView_DuLieuDaPhanTich.Columns[2].HeaderText = lbl_ChieuThoiGian.Text;
                            dataGridView_DuLieuDaPhanTich.Columns[3].HeaderText = chieusanpham;
                            dataGridView_DuLieuDaPhanTich.Columns[4].HeaderText = chieudulieu;
                        }
                        if (chieukhuvuc != "All" && lbl_ChieuThoiGian.Text == "Quy" || lbl_ChieuThoiGian.Text == "Thang")
                        {
                            dataGridView_DuLieuDaPhanTich.Columns[0].HeaderText = "Ten Khu Vuc";
                            dataGridView_DuLieuDaPhanTich.Columns[1].HeaderText = "Ten Chi Nhanh";
                            dataGridView_DuLieuDaPhanTich.Columns[2].HeaderText = "Nam";
                            dataGridView_DuLieuDaPhanTich.Columns[3].HeaderText = chieusanpham;
                            dataGridView_DuLieuDaPhanTich.Columns[4].HeaderText = chieuthoigian;
                            dataGridView_DuLieuDaPhanTich.Columns[5].HeaderText = chieudulieu;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi khi thực hiện truy vấn MDX: " + e.Message);
            }
        }

        private void LoadData_KhuVuc_ChiNhanh_DuLieu_KhachHang_ThoiGian(string chieukhuvuc, string chieudulieu, string chieukhachhang, string chieuthoigian)
        {
            try
            {
                string tungay = lbl_TuNam.Text;
                string denngay = lbl_DenNam.Text;

                string themchieu = "";
                if (lbl_ChieuThoiGian.Text == "Nam")
                {
                    themchieu = "[Dim Thoi Gian].[Nam].[Nam].members * ";
                }
                if (lbl_ChieuThoiGian.Text == "Quy")
                {
                    themchieu = "[Dim Thoi Gian].[Nam].[Nam].members * [Dim Thoi Gian].[Quy].[Quy].members * ";
                }
                if (lbl_ChieuThoiGian.Text == "Thang")
                {
                    themchieu = "[Dim Thoi Gian].[Nam].[Nam].members * [Dim Thoi Gian].[Thang].[Thang].members * ";
                }

                if (chieukhachhang == "Tuoi")
                {
                    themchieu += "[Dim Khach Hang].[Tuoi].[Tuoi].members";
                }
                if (chieukhachhang == "Ten Loai Khach Hang")
                {
                    themchieu += "[Dim Khach Hang].[Ten Loai Khach Hang].[Ten Loai Khach Hang].members";
                }

                if (chieukhuvuc != "null" && chieudulieu != "null")
                {
                    string mdxQuery = "SELECT NON EMPTY { [Measures].[" + chieudulieu + "] } ON COLUMNS, " +
                                      "NON EMPTY { ([Dim Chi Nhanh].[Ten Khu Vuc].[Ten Khu Vuc].members * " +
                                      themchieu + ") } " +
                                      "DIMENSION PROPERTIES MEMBER_CAPTION ON ROWS " +
                                      "FROM [DB ACECOOK DDS] " +
                                      "WHERE ([Dim Thoi Gian].[Nam].&[" + tungay + "] : " +
                                      "[Dim Thoi Gian].[Nam].&[" + denngay + "]);";

                    if (chieukhuvuc != "All")
                    {
                        mdxQuery = "SELECT NON EMPTY { [Measures].[" + chieudulieu + "] } ON COLUMNS, " +
                                    "NON EMPTY { ([Dim Chi Nhanh].[Ten Khu Vuc].[Ten Khu Vuc].members * " +
                                    "[Dim Chi Nhanh].[Ten Chi Nhanh].[Ten Chi Nhanh].members *" +
                                    themchieu + ")} " +
                                    "DIMENSION PROPERTIES MEMBER_CAPTION ON ROWS " +
                                    "FROM [DB ACECOOK DDS] " +
                                    "WHERE ([Dim Chi Nhanh].[Ma Khu Vuc].&[" + chieukhuvuc + "]) * " +
                                    "([Dim Thoi Gian].[Nam].&[" + tungay + "] : " +
                                    "[Dim Thoi Gian].[Nam].&[" + denngay + "]);";

                        if (lbl_ChieuChiNhanh.Text != "All" && lbl_ChieuChiNhanh.Text != "null")
                        {
                            mdxQuery = "SELECT NON EMPTY { [Measures].[" + chieudulieu + "] } ON COLUMNS, " +
                                    "NON EMPTY { ([Dim Chi Nhanh].[Ten Khu Vuc].[Ten Khu Vuc].members * " +
                                    "[Dim Chi Nhanh].[Ten Chi Nhanh].[Ten Chi Nhanh].members *" +
                                    themchieu + ")} " +
                                    "DIMENSION PROPERTIES MEMBER_CAPTION ON ROWS " +
                                    "FROM [DB ACECOOK DDS] " +
                                    "WHERE ([Dim Chi Nhanh].[Ma Chi Nhanh].&[" + lbl_ChieuChiNhanh.Text + "]) * " +
                                    "([Dim Thoi Gian].[Nam].&[" + tungay + "] : " +
                                    "[Dim Thoi Gian].[Nam].&[" + denngay + "]);";
                        }
                    }

                    dataGridView_DuLieuDaPhanTich.DataSource = bus_olap.GetMDXData(mdxQuery);

                    if (dataGridView_DuLieuDaPhanTich.Rows.Count > 0)
                    {
                        if (lbl_ChieuThoiGian.Text == "Nam" && lbl_ChieuKhuVuc.Text == "All")
                        {
                            dataGridView_DuLieuDaPhanTich.Columns[0].HeaderText = "Ten Khu Vuc";
                            dataGridView_DuLieuDaPhanTich.Columns[1].HeaderText = "Nam";
                            dataGridView_DuLieuDaPhanTich.Columns[2].HeaderText = chieukhachhang;
                            dataGridView_DuLieuDaPhanTich.Columns[3].HeaderText = chieudulieu;
                        }
                        if (lbl_ChieuThoiGian.Text == "Quy" || lbl_ChieuThoiGian.Text == "Thang" && lbl_ChieuKhuVuc.Text == "All")
                        {
                            dataGridView_DuLieuDaPhanTich.Columns[0].HeaderText = "Ten Khu Vuc";
                            dataGridView_DuLieuDaPhanTich.Columns[1].HeaderText = "Nam";
                            dataGridView_DuLieuDaPhanTich.Columns[2].HeaderText = lbl_ChieuThoiGian.Text;
                            dataGridView_DuLieuDaPhanTich.Columns[3].HeaderText = chieukhachhang;
                            dataGridView_DuLieuDaPhanTich.Columns[4].HeaderText = chieudulieu;
                        }
                        if (chieukhuvuc != "All" && lbl_ChieuThoiGian.Text == "Nam")
                        {
                            dataGridView_DuLieuDaPhanTich.Columns[0].HeaderText = "Ten Khu Vuc";
                            dataGridView_DuLieuDaPhanTich.Columns[1].HeaderText = "Ten Chi Nhanh";
                            dataGridView_DuLieuDaPhanTich.Columns[2].HeaderText = lbl_ChieuThoiGian.Text;
                            dataGridView_DuLieuDaPhanTich.Columns[3].HeaderText = chieukhachhang;
                            dataGridView_DuLieuDaPhanTich.Columns[4].HeaderText = chieudulieu;
                        }
                        if (chieukhuvuc != "All" && lbl_ChieuThoiGian.Text == "Quy" || lbl_ChieuThoiGian.Text == "Thang")
                        {
                            dataGridView_DuLieuDaPhanTich.Columns[0].HeaderText = "Ten Khu Vuc";
                            dataGridView_DuLieuDaPhanTich.Columns[1].HeaderText = "Ten Chi Nhanh";
                            dataGridView_DuLieuDaPhanTich.Columns[2].HeaderText = "Nam";
                            dataGridView_DuLieuDaPhanTich.Columns[3].HeaderText = chieukhachhang;
                            dataGridView_DuLieuDaPhanTich.Columns[4].HeaderText = chieuthoigian;
                            dataGridView_DuLieuDaPhanTich.Columns[5].HeaderText = chieudulieu;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi khi thực hiện truy vấn MDX: " + e.Message);
            }
        }

        private void LoadData_KhuVuc_ChiNhanh_DuLieu_KhachHang_SanPham_ThoiGian(string chieukhuvuc, string chieudulieu, string chieukhachhang, string chieusanpham, string chieuthoigian)
        {
            try
            {
                string tungay = lbl_TuNam.Text;
                string denngay = lbl_DenNam.Text;

                string themchieu = "";
                if (lbl_ChieuThoiGian.Text == "Nam")
                {
                    themchieu = "[Dim Thoi Gian].[Nam].[Nam].members * ";
                }
                if (lbl_ChieuThoiGian.Text == "Quy")
                {
                    themchieu = "[Dim Thoi Gian].[Nam].[Nam].members * [Dim Thoi Gian].[Quy].[Quy].members * ";
                }
                if (lbl_ChieuThoiGian.Text == "Thang")
                {
                    themchieu = "[Dim Thoi Gian].[Nam].[Nam].members * [Dim Thoi Gian].[Thang].[Thang].members * ";
                }

                if (chieukhachhang == "Tuoi")
                {
                    themchieu += "[Dim Khach Hang].[Tuoi].[Tuoi].members * ";
                }
                if (chieukhachhang == "Ten Loai Khach Hang")
                {
                    themchieu += "[Dim Khach Hang].[Ten Loai Khach Hang].[Ten Loai Khach Hang].members * ";
                }

                if (chieusanpham == "Ten San Pham")
                {
                    themchieu += "[Dim San Pham].[Ten San Pham].[Ten San Pham].members";
                }

                if (chieukhuvuc != "null" && chieudulieu != "null")
                {
                    string mdxQuery = "SELECT NON EMPTY { [Measures].[" + chieudulieu + "] } ON COLUMNS, " +
                                      "NON EMPTY { ([Dim Chi Nhanh].[Ten Khu Vuc].[Ten Khu Vuc].members * " +
                                      themchieu + ") } " +
                                      "DIMENSION PROPERTIES MEMBER_CAPTION ON ROWS " +
                                      "FROM [DB ACECOOK DDS] " +
                                      "WHERE ([Dim Thoi Gian].[Nam].&[" + tungay + "] : " +
                                      "[Dim Thoi Gian].[Nam].&[" + denngay + "]);";

                    if (chieukhuvuc != "All")
                    {
                        mdxQuery = "SELECT NON EMPTY { [Measures].[" + chieudulieu + "] } ON COLUMNS, " +
                                    "NON EMPTY { ([Dim Chi Nhanh].[Ten Khu Vuc].[Ten Khu Vuc].members * " +
                                    "[Dim Chi Nhanh].[Ten Chi Nhanh].[Ten Chi Nhanh].members *" +
                                    themchieu + ")} " +
                                    "DIMENSION PROPERTIES MEMBER_CAPTION ON ROWS " +
                                    "FROM [DB ACECOOK DDS] " +
                                    "WHERE ([Dim Chi Nhanh].[Ma Khu Vuc].&[" + chieukhuvuc + "]) * " +
                                    "([Dim Thoi Gian].[Nam].&[" + tungay + "] : " +
                                    "[Dim Thoi Gian].[Nam].&[" + denngay + "]);";

                        if (lbl_ChieuChiNhanh.Text != "All" && lbl_ChieuChiNhanh.Text != "null")
                        {
                            mdxQuery = "SELECT NON EMPTY { [Measures].[" + chieudulieu + "] } ON COLUMNS, " +
                                    "NON EMPTY { ([Dim Chi Nhanh].[Ten Khu Vuc].[Ten Khu Vuc].members * " +
                                    "[Dim Chi Nhanh].[Ten Chi Nhanh].[Ten Chi Nhanh].members *" +
                                    themchieu + ")} " +
                                    "DIMENSION PROPERTIES MEMBER_CAPTION ON ROWS " +
                                    "FROM [DB ACECOOK DDS] " +
                                    "WHERE ([Dim Chi Nhanh].[Ma Chi Nhanh].&[" + lbl_ChieuChiNhanh.Text + "]) * " +
                                    "([Dim Thoi Gian].[Nam].&[" + tungay + "] : " +
                                    "[Dim Thoi Gian].[Nam].&[" + denngay + "]);";
                        }
                    }

                    dataGridView_DuLieuDaPhanTich.DataSource = bus_olap.GetMDXData(mdxQuery);

                    if (dataGridView_DuLieuDaPhanTich.Rows.Count > 0)
                    {
                        if (lbl_ChieuThoiGian.Text == "Nam" && lbl_ChieuKhuVuc.Text == "All")
                        {
                            dataGridView_DuLieuDaPhanTich.Columns[0].HeaderText = "Ten Khu Vuc";
                            dataGridView_DuLieuDaPhanTich.Columns[1].HeaderText = "Nam";
                            dataGridView_DuLieuDaPhanTich.Columns[2].HeaderText = chieukhachhang;
                            dataGridView_DuLieuDaPhanTich.Columns[3].HeaderText = chieusanpham;
                            dataGridView_DuLieuDaPhanTich.Columns[4].HeaderText = chieudulieu;
                        }
                        if (lbl_ChieuThoiGian.Text == "Quy" || lbl_ChieuThoiGian.Text == "Thang" && lbl_ChieuKhuVuc.Text == "All")
                        {
                            dataGridView_DuLieuDaPhanTich.Columns[0].HeaderText = "Ten Khu Vuc";
                            dataGridView_DuLieuDaPhanTich.Columns[1].HeaderText = "Nam";
                            dataGridView_DuLieuDaPhanTich.Columns[2].HeaderText = lbl_ChieuThoiGian.Text;
                            dataGridView_DuLieuDaPhanTich.Columns[3].HeaderText = chieukhachhang;
                            dataGridView_DuLieuDaPhanTich.Columns[4].HeaderText = chieusanpham;
                            dataGridView_DuLieuDaPhanTich.Columns[5].HeaderText = chieudulieu;
                        }
                        if (chieukhuvuc != "All" && lbl_ChieuThoiGian.Text == "Nam")
                        {
                            dataGridView_DuLieuDaPhanTich.Columns[0].HeaderText = "Ten Khu Vuc";
                            dataGridView_DuLieuDaPhanTich.Columns[1].HeaderText = "Ten Chi Nhanh";
                            dataGridView_DuLieuDaPhanTich.Columns[2].HeaderText = lbl_ChieuThoiGian.Text;
                            dataGridView_DuLieuDaPhanTich.Columns[3].HeaderText = chieukhachhang;
                            dataGridView_DuLieuDaPhanTich.Columns[4].HeaderText = chieusanpham;
                            dataGridView_DuLieuDaPhanTich.Columns[5].HeaderText = chieudulieu;
                        }
                        if (chieukhuvuc != "All" && lbl_ChieuThoiGian.Text == "Quy" || lbl_ChieuThoiGian.Text == "Thang")
                        {
                            dataGridView_DuLieuDaPhanTich.Columns[0].HeaderText = "Ten Khu Vuc";
                            dataGridView_DuLieuDaPhanTich.Columns[1].HeaderText = "Ten Chi Nhanh";
                            dataGridView_DuLieuDaPhanTich.Columns[2].HeaderText = "Nam";
                            dataGridView_DuLieuDaPhanTich.Columns[3].HeaderText = chieukhachhang;
                            dataGridView_DuLieuDaPhanTich.Columns[4].HeaderText = chieusanpham;
                            dataGridView_DuLieuDaPhanTich.Columns[5].HeaderText = chieuthoigian;
                            dataGridView_DuLieuDaPhanTich.Columns[6].HeaderText = chieudulieu;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi khi thực hiện truy vấn MDX: " + e.Message);
            }
        }

        private void LoadData_ChieuDuLieu_ChieuKhachHang(string chieudulieu, string chieukhachhang)
        {
            try
            {
                string mdxQuery = "SELECT NON EMPTY { [Measures].[" + chieudulieu + "] } ON COLUMNS, " +
                                      "NON EMPTY { ([Dim Khach Hang].[" + chieukhachhang + "].[" + chieukhachhang + "].ALLMEMBERS ) }" +
                                      "DIMENSION PROPERTIES MEMBER_CAPTION ON ROWS " +
                                      "FROM [DB ACECOOK DDS]";

                dataGridView_DuLieuDaPhanTich.DataSource = null;

                dataGridView_DuLieuDaPhanTich.DataSource = bus_olap.GetMDXData(mdxQuery);

                dataGridView_DuLieuDaPhanTich.Columns[0].HeaderText = chieukhachhang;
                dataGridView_DuLieuDaPhanTich.Columns[1].HeaderText = chieudulieu;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện truy vấn MDX: " + ex.Message);
            }
        }

        private void LoadData_ChieuDuLieu_ChieuSanPham(string chieudulieu, string chieusanpham)
        {
            try
            {
                string mdxQuery = "SELECT NON EMPTY { [Measures].[" + chieudulieu + "] } ON COLUMNS, " +
                                      "NON EMPTY { ([Dim San Pham].[" + chieusanpham + "].[" + chieusanpham + "].ALLMEMBERS ) }" +
                                      "DIMENSION PROPERTIES MEMBER_CAPTION ON ROWS " +
                                      "FROM [DB ACECOOK DDS]";

                dataGridView_DuLieuDaPhanTich.DataSource = null;

                dataGridView_DuLieuDaPhanTich.DataSource = bus_olap.GetMDXData(mdxQuery);

                dataGridView_DuLieuDaPhanTich.Columns[0].HeaderText = chieusanpham;
                dataGridView_DuLieuDaPhanTich.Columns[1].HeaderText = chieudulieu;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện truy vấn MDX: " + ex.Message);
            }
        }

        private void LoadData_ChieuDuLieu_ChieuThoiGian(string chieudulieu, string chieuthoigian)
        {
            try
            {
                string mdxQuery = "SELECT NON EMPTY { [Measures].[" + chieudulieu + "] } ON COLUMNS, " +
                                      "NON EMPTY { ([Dim Thoi Gian].[" + chieuthoigian + "].[" + chieuthoigian + "].ALLMEMBERS ) }" +
                                      "DIMENSION PROPERTIES MEMBER_CAPTION ON ROWS " +
                                      "FROM [DB ACECOOK DDS]";

                dataGridView_DuLieuDaPhanTich.DataSource = null;

                dataGridView_DuLieuDaPhanTich.DataSource = bus_olap.GetMDXData(mdxQuery);

                dataGridView_DuLieuDaPhanTich.Columns[0].HeaderText = chieuthoigian;
                dataGridView_DuLieuDaPhanTich.Columns[1].HeaderText = chieudulieu;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện truy vấn MDX: " + ex.Message);
            }
        }
        private void LoadData_ChieuDuLieu_ChieuKhachHang_ChieuSanPham(string chieudulieu, string chieukhachhang, string chieusanpham)
        {
            try
            {
                string mdxQuery = " SELECT NON EMPTY { [Measures].[" + chieudulieu + "] } ON COLUMNS, " +
                                     "NON EMPTY { ([Dim Khach Hang].[" + chieukhachhang + "].[" + chieukhachhang + "].ALLMEMBERS * [Dim San Pham].[Ten San Pham].[Ten San Pham].ALLMEMBERS) } " +
                                     "DIMENSION PROPERTIES MEMBER_CAPTION ON ROWS " +
                                     "FROM[DB ACECOOK DDS]";

                dataGridView_DuLieuDaPhanTich.DataSource = null;
                dataGridView_DuLieuDaPhanTich.DataSource = bus_olap.GetMDXData(mdxQuery);

                dataGridView_DuLieuDaPhanTich.Columns[0].HeaderText = chieukhachhang;
                dataGridView_DuLieuDaPhanTich.Columns[1].HeaderText = chieusanpham;
                dataGridView_DuLieuDaPhanTich.Columns[2].HeaderText = chieudulieu;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện truy vấn MDX: " + ex.Message);
            }
        }
        private void LoadData_ChieuDuLieu_ChieuSanPham_ChieuThoiGian(string chieudulieu, string chieusanpham, string chieuthoigian)
        {
            try
            {
                string mdxQuery = "SELECT NON EMPTY { [Measures].[" + chieudulieu + "] } ON COLUMNS, " +
                    "NON EMPTY { ([Dim San Pham].[Ten San Pham].[Ten San Pham].ALLMEMBERS * [Dim Thoi Gian].[" + chieuthoigian + "].[" + chieuthoigian + "].ALLMEMBERS ) } " +
                    "DIMENSION PROPERTIES MEMBER_CAPTION ON ROWS FROM [DB ACECOOK DDS]";

                dataGridView_DuLieuDaPhanTich.DataSource = null;
                dataGridView_DuLieuDaPhanTich.DataSource = bus_olap.GetMDXData(mdxQuery);

                dataGridView_DuLieuDaPhanTich.Columns[0].HeaderText = chieusanpham;
                dataGridView_DuLieuDaPhanTich.Columns[1].HeaderText = chieuthoigian;
                dataGridView_DuLieuDaPhanTich.Columns[2].HeaderText = chieudulieu;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện truy vấn MDX: " + ex.Message);
            }
        }
        private void LoadData_ChieuDuLieu_ChieuKhachHang_ChieuThoiGian(string chieudulieu, string chieukhachhang, string chieuthoigian)
        {
            try
            {
                string mdxQuery = "SELECT NON EMPTY { [Measures].[" + chieudulieu + "] } ON COLUMNS, " +
                    "NON EMPTY { ([Dim Khach Hang].[" + chieukhachhang + "].[" + chieukhachhang + "].ALLMEMBERS * [Dim Thoi Gian].[" + chieuthoigian + "].[" + chieuthoigian + "].ALLMEMBERS ) } " +
                    "DIMENSION PROPERTIES MEMBER_CAPTION ON ROWS FROM [DB ACECOOK DDS]";

                dataGridView_DuLieuDaPhanTich.DataSource = null;
                dataGridView_DuLieuDaPhanTich.DataSource = bus_olap.GetMDXData(mdxQuery);

                dataGridView_DuLieuDaPhanTich.Columns[0].HeaderText = chieukhachhang;
                dataGridView_DuLieuDaPhanTich.Columns[1].HeaderText = chieuthoigian;
                dataGridView_DuLieuDaPhanTich.Columns[2].HeaderText = chieudulieu;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện truy vấn MDX: " + ex.Message);
            }
        }
        private void LoadData_ChieuDuLieu_ChieuKhachHang_ChieuSanPham_ChieuThoiGian(string chieudulieu, string chieusanpham, string chieukhachhang, string chieuthoigian)
        {
            try
            {
                string mdxQuery = "   SELECT NON EMPTY { [Measures].[" + chieudulieu + "] } ON COLUMNS, " +
                            "NON EMPTY { ([Dim Khach Hang].[" + chieukhachhang + "].[" + chieukhachhang + "].ALLMEMBERS * [Dim San Pham].[" + chieusanpham + "].[" + chieusanpham + "].ALLMEMBERS * [Dim Thoi Gian].[" + chieuthoigian + "].[" + chieuthoigian + "].ALLMEMBERS) } " +
                            "DIMENSION PROPERTIES MEMBER_CAPTION ON ROWS FROM[DB ACECOOK DDS] ";

                dataGridView_DuLieuDaPhanTich.DataSource = null;
                dataGridView_DuLieuDaPhanTich.DataSource = bus_olap.GetMDXData(mdxQuery);

                dataGridView_DuLieuDaPhanTich.Columns[0].HeaderText = chieukhachhang;
                dataGridView_DuLieuDaPhanTich.Columns[1].HeaderText = chieusanpham;
                dataGridView_DuLieuDaPhanTich.Columns[2].HeaderText = chieuthoigian;
                dataGridView_DuLieuDaPhanTich.Columns[3].HeaderText = chieudulieu;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện truy vấn MDX: " + ex.Message);
            }
        }
        private void LoadData_ChieuDuLieu_ChieuKhuVuc_ChieuChiNhanh(string chieudulieu, string chieukhuvuc, string chieuchinhanh)
        {
            try
            {
                string mdxQuery = "SELECT NON EMPTY { [Measures].[" + chieudulieu + "] } ON COLUMNS, " +
                    "NON EMPTY { ([Dim Chi Nhanh].[" + chieukhuvuc + "].[" + chieukhuvuc + "].ALLMEMBERS * [Dim Chi Nhanh].[" + chieuchinhanh + "].[" + chieuchinhanh + "].ALLMEMBERS ) } " +
                    "DIMENSION PROPERTIES MEMBER_CAPTION ON ROWS " +
                    "FROM [DB ACECOOK DDS]";

                dataGridView_DuLieuDaPhanTich.DataSource = null;
                dataGridView_DuLieuDaPhanTich.DataSource = bus_olap.GetMDXData(mdxQuery);

                dataGridView_DuLieuDaPhanTich.Columns[0].HeaderText = chieukhuvuc;
                dataGridView_DuLieuDaPhanTich.Columns[1].HeaderText = chieuchinhanh;
                dataGridView_DuLieuDaPhanTich.Columns[2].HeaderText = chieudulieu;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện truy vấn MDX: " + ex.Message);
            }
        }

        private void LoadData_ChieuKhuVuc_ChieuDuLieu( string chieukhuvuc, string chieudulieu)
        {
            try
            {
                string mdxQuery = "";
                if (chieukhuvuc == "All")
                {
                    mdxQuery = "SELECT NON EMPTY { [Measures].[" + chieudulieu + "] } ON COLUMNS, NON EMPTY { ([Dim Chi Nhanh].[Ten Khu Vuc].[Ten Khu Vuc].ALLMEMBERS ) } DIMENSION PROPERTIES MEMBER_CAPTION ON ROWS FROM [DB ACECOOK DDS]";
                }
                else
                {
                    mdxQuery = "SELECT NON EMPTY { [Measures].[" + chieudulieu + "] } ON COLUMNS, NON EMPTY { ([Dim Chi Nhanh].[Ten Khu Vuc].[Ten Khu Vuc].ALLMEMBERS * [Dim Chi Nhanh].[Ten Chi Nhanh].[Ten Chi Nhanh].ALLMEMBERS ) } DIMENSION PROPERTIES MEMBER_CAPTION ON ROWS FROM [DB ACECOOK DDS] WHERE ([Dim Chi Nhanh].[Ma Khu Vuc].&[" + chieukhuvuc + "])";
                }

                dataGridView_DuLieuDaPhanTich.DataSource = null;
                dataGridView_DuLieuDaPhanTich.DataSource = bus_olap.GetMDXData(mdxQuery);
                if (chieukhuvuc == "All")
                {
                    dataGridView_DuLieuDaPhanTich.Columns[0].HeaderText = "Ten Khu Vuc";
                    dataGridView_DuLieuDaPhanTich.Columns[1].HeaderText = chieudulieu;
                }
                else
                {
                    dataGridView_DuLieuDaPhanTich.Columns[0].HeaderText = "Ten Khu Vuc";
                    dataGridView_DuLieuDaPhanTich.Columns[1].HeaderText = "Ten Chi Nhanh";
                    dataGridView_DuLieuDaPhanTich.Columns[2].HeaderText = chieudulieu;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện truy vấn MDX: " + ex.Message);
            }
        }

        private void btn_PhanTich_Click(object sender, EventArgs e)
        {
            // chiều khu vực, chi nhánh và chiều dữ liệu
            //if (!lbl_ChieuKhuVuc.Text.Trim().Equals("null") && !lbl_ChieuDuLieu.Text.Trim().Equals("null"))
            //{
            //    LoadData_KhuVuc_ChiNhanh_DuLieu(lbl_ChieuKhuVuc.Text, lbl_ChieuDuLieu.Text, lbl_ChieuChiNhanh.Text);
            //}
            // chiều khu vực, chi nhánh và dữ liệu và thời gian
            //if (!lbl_ChieuKhuVuc.Text.Trim().Equals("null") &&
            //    lbl_ChieuChiNhanh.Text.Trim().Equals("null") &&
            //    !lbl_ChieuDuLieu.Text.Trim().Equals("null") &&
            //    lbl_ChieuKhachHang.Text.Trim().Equals("null") &&
            //    lbl_ChieuSanPham.Text.Trim().Equals("null") &&
            //    !lbl_ChieuThoiGian.Text.Trim().Equals("null") &&
            //    !lbl_TuNam.Text.Trim().Equals("null") &&
            //    !lbl_DenNam.Text.Trim().Equals("null")
            //   )
            //{
            //    LoadData_KhuVuc_ChiNhanh_DuLieu_ThoiGian(lbl_ChieuKhuVuc.Text, lbl_ChieuDuLieu.Text, lbl_ChieuThoiGian.Text);
            //}
            //// chiều khu vực, chi nhanh và dữ liệu và sản phẩm
            //if (!lbl_ChieuKhuVuc.Text.Trim().Equals("null") &&
            //    !lbl_ChieuChiNhanh.Text.Trim().Equals("null") &&
            //    !lbl_ChieuDuLieu.Text.Trim().Equals("null") &&
            //    lbl_ChieuKhachHang.Text.Trim().Equals("null") &&
            //    !lbl_ChieuSanPham.Text.Trim().Equals("null") &&
            //    lbl_ChieuThoiGian.Text.Trim().Equals("null") &&
            //    !lbl_TuNam.Text.Trim().Equals("null") &&
            //    !lbl_DenNam.Text.Trim().Equals("null")
            //   )
            //{
            //    LoadData_KhuVuc_ChiNhanh_DuLieu_SanPham(lbl_ChieuKhuVuc.Text, lbl_ChieuDuLieu.Text, lbl_ChieuSanPham.Text);
            //}
            //// chiều khu vực, chi nhanh và dữ liệu và khách hàng
            //if (!lbl_ChieuKhuVuc.Text.Trim().Equals("null") &&
            //    !lbl_ChieuChiNhanh.Text.Trim().Equals("null") &&
            //    !lbl_ChieuDuLieu.Text.Trim().Equals("null") &&
            //    !lbl_ChieuKhachHang.Text.Trim().Equals("null") &&
            //    lbl_ChieuSanPham.Text.Trim().Equals("null") &&
            //    lbl_ChieuThoiGian.Text.Trim().Equals("null") &&
            //    !lbl_TuNam.Text.Trim().Equals("null") &&
            //    !lbl_DenNam.Text.Trim().Equals("null")
            //   )
            //{
            //    LoadData_KhuVuc_ChiNhanh_DuLieu_KhachHang(lbl_ChieuKhuVuc.Text, lbl_ChieuDuLieu.Text, lbl_ChieuKhachHang.Text);
            //}
            //// chiều khu vực, chi nhánh và dữ liệu và sản phẩm và thời gian
            //if (!lbl_ChieuKhuVuc.Text.Trim().Equals("null") &&
            //    !lbl_ChieuChiNhanh.Text.Trim().Equals("null") &&
            //    !lbl_ChieuDuLieu.Text.Trim().Equals("null") &&
            //    lbl_ChieuKhachHang.Text.Trim().Equals("null") &&
            //    !lbl_ChieuSanPham.Text.Trim().Equals("null") &&
            //    !lbl_ChieuThoiGian.Text.Trim().Equals("null") &&
            //    !lbl_TuNam.Text.Trim().Equals("null") &&
            //    !lbl_DenNam.Text.Trim().Equals("null")
            //   )
            //{
            //    LoadData_KhuVuc_ChiNhanh_DuLieu_SanPham_ThoiGian(lbl_ChieuKhuVuc.Text, lbl_ChieuDuLieu.Text, lbl_ChieuSanPham.Text, lbl_ChieuThoiGian.Text);
            //}
            //// chiều khu vực, chi nhánh và dữ liệu và khach hang và thời gian
            //if (!lbl_ChieuKhuVuc.Text.Trim().Equals("null") &&
            //    !lbl_ChieuChiNhanh.Text.Trim().Equals("null") &&
            //    !lbl_ChieuDuLieu.Text.Trim().Equals("null") &&
            //    !lbl_ChieuKhachHang.Text.Trim().Equals("null") &&
            //    lbl_ChieuSanPham.Text.Trim().Equals("null") &&
            //    !lbl_ChieuThoiGian.Text.Trim().Equals("null") &&
            //    !lbl_TuNam.Text.Trim().Equals("null") &&
            //    !lbl_DenNam.Text.Trim().Equals("null")
            //   )
            //{
            //    LoadData_KhuVuc_ChiNhanh_DuLieu_KhachHang_ThoiGian(lbl_ChieuKhuVuc.Text, lbl_ChieuDuLieu.Text, lbl_ChieuKhachHang.Text, lbl_ChieuThoiGian.Text);
            //}
            //// chiều khu vực, chi nhánh và dữ liệu và khach hang và sản phẩm và thời gian
            //if (!lbl_ChieuKhuVuc.Text.Trim().Equals("null") &&
            //    !lbl_ChieuChiNhanh.Text.Trim().Equals("null") &&
            //    !lbl_ChieuDuLieu.Text.Trim().Equals("null") &&
            //    !lbl_ChieuKhachHang.Text.Trim().Equals("null") &&
            //    !lbl_ChieuSanPham.Text.Trim().Equals("null") &&
            //    !lbl_ChieuThoiGian.Text.Trim().Equals("null") &&
            //    !lbl_TuNam.Text.Trim().Equals("null") &&
            //    !lbl_DenNam.Text.Trim().Equals("null")
            //   )
            //{
            //    LoadData_KhuVuc_ChiNhanh_DuLieu_KhachHang_SanPham_ThoiGian(lbl_ChieuKhuVuc.Text, lbl_ChieuDuLieu.Text, lbl_ChieuKhachHang.Text, lbl_ChieuSanPham.Text, lbl_ChieuThoiGian.Text);
            //}
            // 
            if (lbl_ChieuKhuVuc.Text.Trim().Equals("null") &&
                lbl_ChieuChiNhanh.Text.Trim().Equals("null") &&
                !lbl_ChieuDuLieu.Text.Trim().Equals("null") &&
                !lbl_ChieuKhachHang.Text.Trim().Equals("null") &&
                lbl_ChieuSanPham.Text.Trim().Equals("null") &&
                lbl_ChieuThoiGian.Text.Trim().Equals("null") &&
                lbl_TuNam.Text.Trim().Equals("null") &&
                lbl_DenNam.Text.Trim().Equals("null")
                )
            {
                LoadData_ChieuDuLieu_ChieuKhachHang(lbl_ChieuDuLieu.Text, lbl_ChieuKhachHang.Text);
            }

            if (lbl_ChieuKhuVuc.Text.Trim().Equals("null") &&
                lbl_ChieuChiNhanh.Text.Trim().Equals("null") &&
                !lbl_ChieuDuLieu.Text.Trim().Equals("null") &&
                lbl_ChieuKhachHang.Text.Trim().Equals("null") &&
                !lbl_ChieuSanPham.Text.Trim().Equals("null") &&
                lbl_ChieuThoiGian.Text.Trim().Equals("null") &&
                lbl_TuNam.Text.Trim().Equals("null") &&
                lbl_DenNam.Text.Trim().Equals("null")
                )
            {
                LoadData_ChieuDuLieu_ChieuSanPham(lbl_ChieuDuLieu.Text, lbl_ChieuSanPham.Text);
            }
            if (lbl_ChieuKhuVuc.Text.Trim().Equals("null") &&
                lbl_ChieuChiNhanh.Text.Trim().Equals("null") &&
                !lbl_ChieuDuLieu.Text.Trim().Equals("null") &&
                lbl_ChieuKhachHang.Text.Trim().Equals("null") &&
                lbl_ChieuSanPham.Text.Trim().Equals("null") &&
                !lbl_ChieuThoiGian.Text.Trim().Equals("null") &&
                lbl_TuNam.Text.Trim().Equals("null") &&
                lbl_DenNam.Text.Trim().Equals("null")
                )
            {
                LoadData_ChieuDuLieu_ChieuThoiGian(lbl_ChieuDuLieu.Text, lbl_ChieuThoiGian.Text);
            }
            if (lbl_ChieuKhuVuc.Text.Trim().Equals("null") &&
                lbl_ChieuChiNhanh.Text.Trim().Equals("null") &&
                !lbl_ChieuDuLieu.Text.Trim().Equals("null") &&
                !lbl_ChieuKhachHang.Text.Trim().Equals("null") &&
                !lbl_ChieuSanPham.Text.Trim().Equals("null") &&
                lbl_ChieuThoiGian.Text.Trim().Equals("null") &&
                lbl_TuNam.Text.Trim().Equals("null") &&
                lbl_DenNam.Text.Trim().Equals("null")
                )
            {
                LoadData_ChieuDuLieu_ChieuKhachHang_ChieuSanPham(lbl_ChieuDuLieu.Text, lbl_ChieuKhachHang.Text, lbl_ChieuSanPham.Text);
            }
            if (lbl_ChieuKhuVuc.Text.Trim().Equals("null") &&
               lbl_ChieuChiNhanh.Text.Trim().Equals("null") &&
               !lbl_ChieuDuLieu.Text.Trim().Equals("null") &&
               lbl_ChieuKhachHang.Text.Trim().Equals("null") &&
               !lbl_ChieuSanPham.Text.Trim().Equals("null") &&
               !lbl_ChieuThoiGian.Text.Trim().Equals("null") &&
                lbl_TuNam.Text.Trim().Equals("null") &&
                lbl_DenNam.Text.Trim().Equals("null")
               )
            {
                LoadData_ChieuDuLieu_ChieuSanPham_ChieuThoiGian(lbl_ChieuDuLieu.Text, lbl_ChieuSanPham.Text, lbl_ChieuThoiGian.Text);
            }
            if (lbl_ChieuKhuVuc.Text.Trim().Equals("null") &&
               lbl_ChieuChiNhanh.Text.Trim().Equals("null") &&
               !lbl_ChieuDuLieu.Text.Trim().Equals("null") &&
               !lbl_ChieuKhachHang.Text.Trim().Equals("null") &&
               lbl_ChieuSanPham.Text.Trim().Equals("null") &&
               !lbl_ChieuThoiGian.Text.Trim().Equals("null") &&
                lbl_TuNam.Text.Trim().Equals("null") &&
                lbl_DenNam.Text.Trim().Equals("null")
               )
            {
                LoadData_ChieuDuLieu_ChieuKhachHang_ChieuThoiGian(lbl_ChieuDuLieu.Text, lbl_ChieuKhachHang.Text, lbl_ChieuThoiGian.Text);
            }
            if (lbl_ChieuKhuVuc.Text.Trim().Equals("null") &&
               lbl_ChieuChiNhanh.Text.Trim().Equals("null") &&
               !lbl_ChieuDuLieu.Text.Trim().Equals("null") &&
               !lbl_ChieuKhachHang.Text.Trim().Equals("null") &&
               !lbl_ChieuSanPham.Text.Trim().Equals("null") &&
               !lbl_ChieuThoiGian.Text.Trim().Equals("null") &&
                lbl_TuNam.Text.Trim().Equals("null") &&
                lbl_DenNam.Text.Trim().Equals("null")
               )
            {
                LoadData_ChieuDuLieu_ChieuKhachHang_ChieuSanPham_ChieuThoiGian(lbl_ChieuDuLieu.Text, lbl_ChieuSanPham.Text, lbl_ChieuKhachHang.Text, lbl_ChieuThoiGian.Text);
            }
            if (!lbl_ChieuKhuVuc.Text.Trim().Equals("null") &&
               lbl_ChieuChiNhanh.Text.Trim().Equals("null") &&
               !lbl_ChieuDuLieu.Text.Trim().Equals("null") &&
               lbl_ChieuKhachHang.Text.Trim().Equals("null") &&
               lbl_ChieuSanPham.Text.Trim().Equals("null") &&
               lbl_ChieuThoiGian.Text.Trim().Equals("null") &&
                lbl_TuNam.Text.Trim().Equals("null") &&
                lbl_DenNam.Text.Trim().Equals("null")
               )
            {
                LoadData_ChieuKhuVuc_ChieuDuLieu(lbl_ChieuKhuVuc.Text,lbl_ChieuDuLieu.Text);
            }
        }

        //  Chiều khu vực
        private void cbo_KhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_KhuVuc.ForeColor = System.Drawing.Color.Black;
            if (cbo_KhuVuc.SelectedIndex != 0)
            {
                List<DTO_ChiNhanh> listChiNhanh = new List<DTO_ChiNhanh>();
                listChiNhanh.Add(new DTO_ChiNhanh { MaChiNhanh = "All", TenChiNhanh = "Tất cả chi nhánh ..." });

                string selectedValue = cbo_KhuVuc.SelectedValue.ToString();
                listChiNhanh.AddRange(bus_chinhanh.GetAllByID(selectedValue));

                cbo_ChiNhanh.DataSource = listChiNhanh;
                cbo_ChiNhanh.DisplayMember = "TenChiNhanh";
                cbo_ChiNhanh.ValueMember = "MaChiNhanh";

                lbl_ChieuKhuVuc.Text = cbo_KhuVuc.SelectedValue.ToString();
                lbl_ChieuChiNhanh.Text = cbo_ChiNhanh.SelectedValue.ToString();
            }
            else
            {
                lbl_ChieuKhuVuc.Text = cbo_KhuVuc.SelectedValue.ToString();
                lbl_ChieuChiNhanh.Text = "null";
                cbo_ChiNhanh.Text = "Tất cả chi nhánh ...";
            }
        }

        //  Chiều chi nhánh
        private void cbo_ChiNhanh_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbo_ChiNhanh.SelectedIndex != -1)
            {
                lbl_ChieuChiNhanh.Text = cbo_ChiNhanh.SelectedValue.ToString();
            }

        }

        //  Chiều dữ liệu
        private void rdo_DoanhThu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_DoanhThu.Checked)
            {
                lbl_ChieuDuLieu.Text = "Tong Tien Ban";
            }
            else
            {
                lbl_ChieuDuLieu.Text = "";
            }
        }

        private void rdo_LoiNhuan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_LoiNhuan.Checked)
            {
                lbl_ChieuDuLieu.Text = "Doanh Thu";
            }
            else
            {
                lbl_ChieuDuLieu.Text = "";
            }
        }

        private void rdo_SoLuongBan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_SoLuongBan.Checked)
            {
                lbl_ChieuDuLieu.Text = "So Luong Ban";
            }
            else
            {
                lbl_ChieuDuLieu.Text = "";
            }
        }

        private void rdo_ChiPhiVanChuyen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_ChiPhiVanChuyen.Checked)
            {
                lbl_ChieuDuLieu.Text = "Chi Phi Van Chuyen";
            }
            else
            {
                lbl_ChieuDuLieu.Text = "";
            }
        }

        //  Chiều thời gian
        private void rdo_Thang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Thang.Checked)
            {
                lbl_ChieuThoiGian.Text = "Thang";
            }
            else
            {
                lbl_ChieuThoiGian.Text = "";
            }
        }

        private void rdo_Nam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Nam.Checked)
            {
                lbl_ChieuThoiGian.Text = "Nam";
            }
            else
            {
                lbl_ChieuThoiGian.Text = "";
            }
        }

        private void rdo_Quy_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Quy.Checked)
            {
                lbl_ChieuThoiGian.Text = "Quy";
            }
            else
            {
                lbl_ChieuThoiGian.Text = "";
            }
        }


        //  Chiều khách hàng
        private void rdo_LoaiKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_LoaiKhachHang.Checked)
            {
                lbl_ChieuKhachHang.Text = "Ten Loai Khach Hang";
            }
            else
            {
                lbl_ChieuKhachHang.Text = "";
            }
        }

        private void rdo_GioiTinh_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Tuoi.Checked)
            {
                lbl_ChieuKhachHang.Text = "Tuoi";
            }
            else
            {
                lbl_ChieuKhachHang.Text = "";
            }
        }

        //  Chiều sản phẩm
        private void rdo_SanPham_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_SanPham.Checked)
            {
                lbl_ChieuSanPham.Text = "Ten San Pham";
            }
            else
            {
                lbl_ChieuSanPham.Text = "";
            }
        }

        //  Chiều từ ngày, đến ngày
        private void dateTimePicker_TuNgay_ValueChanged(object sender, EventArgs e)
        {
            lbl_TuNam.Text = dateTimePicker_TuNam.Value.Year.ToString();
        }

        private void dateTimePicker_DenNgay_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker_DenNam.Value.Year < dateTimePicker_TuNam.Value.Year)
            {
                MessageBox.Show("Năm kết thúc phải lớn hơn hoặc bằng năm bắt đầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                dateTimePicker_DenNam.Value = dateTimePicker_TuNam.Value;
            }
            else
            {
                lbl_DenNam.Text = dateTimePicker_DenNam.Value.Year.ToString();
            }
        }

        private void cbo_LocTheoKhuVuc_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_LocTheoKhuVuc.Checked == true)
            {
                cbo_KhuVuc.Enabled = true;
                cbo_ChiNhanh.Enabled = true;
                cbo_KhuVuc.Text = "Hãy chọn khu vực";
                cbo_ChiNhanh.Text = "Hãy chọn khu vực";
            }
            else
            {
                lbl_ChieuKhuVuc.Text = "null";
                lbl_ChieuChiNhanh.Text = "null";
                cbo_KhuVuc.Enabled = false;
                cbo_ChiNhanh.Enabled = false;
                cbo_KhuVuc.Text = "Hãy chọn khu vực";
                cbo_ChiNhanh.Text = "Hãy chọn khu vực";
            }
        }

        private void cbo_LocTheoNam_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_LocTheoNam.Checked == true)
            {
                dateTimePicker_TuNam.Enabled = true;
                dateTimePicker_DenNam.Enabled = true;
            }
            else
            {
                lbl_TuNam.Text = "null";
                lbl_DenNam.Text = "null";
                dateTimePicker_TuNam.Enabled = false;
                dateTimePicker_DenNam.Enabled = false;
            }
        }
    }
}