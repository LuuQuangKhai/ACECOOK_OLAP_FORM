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
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using DTO;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace GUI
{
    public partial class US_PhanTich : UserControl
    {
        BUS_OLAP_MDX bus_olap;
        BUS_KhuVuc bus_khuvuc;
        BUS_ChiNhanh bus_chinhanh;

        private string chieukhuvuc = "";
        private string chieuchinhanh = "";
        private string chieudulieu = "";
        private string chieuthoigian = "";

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
        }

        private void ExportToWord(DataGridView dataGridView, string filePath)
        {
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                Document document = new Document();
                Body body = document.AppendChild(new Body());

                // Thêm tiêu đề
                Paragraph titleParagraph = body.AppendChild(new Paragraph());
                Run titleRun = titleParagraph.AppendChild(new Run());
                titleRun.AppendChild(new Text("Dữ liệu đã được phân tích"));
                titleRun.RunProperties = new RunProperties { Bold = new Bold() };

                // Tạo bảng
                Table table = body.AppendChild(new Table());

                // Thêm thuộc tính bảng
                TableProperties tableProperties = table.AppendChild(new TableProperties());
                tableProperties.AppendChild(new TableBorders(
                    new TopBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 6 },
                    new BottomBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 6 },
                    new LeftBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 6 },
                    new RightBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 6 },
                    new InsideHorizontalBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 6 },
                    new InsideVerticalBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 6 }
                ));

                // Thêm lưới bảng
                TableGrid tableGrid = tableProperties.AppendChild(new TableGrid());
                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    tableGrid.AppendChild(new GridColumn());
                }

                // Thêm tiêu đề cột
                TableRow headerRow = table.AppendChild(new TableRow());
                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    TableCell headerCell = headerRow.AppendChild(new TableCell());
                    TableCellProperties cellProperties = new TableCellProperties();
                    cellProperties.AppendChild(new TableCellWidth { Type = TableWidthUnitValues.Dxa, Width = "2000" }); // Thiết lập chiều rộng ô
                    headerCell.AppendChild(cellProperties);
                    Paragraph headerParagraph = headerCell.AppendChild(new Paragraph());
                    Run headerRun = headerParagraph.AppendChild(new Run());
                    headerRun.AppendChild(new Text(dataGridView.Columns[i].HeaderText));
                }

                // Thêm dữ liệu
                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    TableRow dataRow = table.AppendChild(new TableRow());
                    for (int j = 0; j < dataGridView.ColumnCount; j++)
                    {
                        TableCell dataCell = dataRow.AppendChild(new TableCell());
                        TableCellProperties cellProperties = new TableCellProperties();
                        cellProperties.AppendChild(new TableCellWidth { Type = TableWidthUnitValues.Dxa, Width = "2000" }); // Thiết lập chiều rộng ô
                        dataCell.AppendChild(cellProperties);
                        Paragraph dataParagraph = dataCell.AppendChild(new Paragraph());
                        Run dataRun = dataParagraph.AppendChild(new Run());
                        dataRun.AppendChild(new Text(dataGridView.Rows[i].Cells[j].Value?.ToString() ?? ""));
                    }
                }

                mainPart.Document = document;
                wordDocument.Save();
            }
        }

        private void ExportToExcel(DataGridView dataGridView, string filePath)
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
                ExportToExcel(dataGridView1, excelFilePath);
                MessageBox.Show("Dữ liệu đã được xuất ra file Excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_XuatWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Word Documents (*.docx)|*.docx";
            saveFileDialog.DefaultExt = ".docx";
            saveFileDialog.FileName = "MyACECOOKWordFile.docx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                ExportToWord(dataGridView1, filePath);
                MessageBox.Show("Dữ liệu đã được xuất ra file Word.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
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

                chieukhuvuc = selectedValue;
            }
            else
            {
                chieukhuvuc = "members";
                cbo_ChiNhanh.Text = "Chi nhánh ...";
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

        private void LoadData(string khuvuc, string chieudulieu, string chieuthoigian)
        {
            string mdxQuery = string.Format(@"SELECT NON EMPTY ORDER([Dim Thoi Gian].[{0}].MEMBERS, [Dim Thoi Gian].[{0}], DESC) ON COLUMNS,
                                NON EMPTY [Dim Chi Nhanh].[Ten Chi Nhanh].MEMBERS ON ROWS
                                FROM [DB ACECOOK DDS]
                                WHERE [Measures].[{1}]", chieuthoigian, chieudulieu);

            dataGridView1.DataSource = bus_olap.GetMDXData(mdxQuery);
        }

        private void btn_PhanTich_Click(object sender, EventArgs e)
        {
            if (chieukhuvuc.Trim().Equals("") || chieuthoigian.Trim().Equals("") || chieudulieu.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng chọn đầy đủ các chiều phân tích!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                LoadData(chieukhuvuc, chieudulieu, chieuthoigian);
                btn_XuatExcel.Enabled = true;
                btn_XuatWord.Enabled = true;
            }
        }

        private void rdo_DoanhThu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_DoanhThu.Checked)
            {
                chieudulieu = "Tong Tien Ban";
            }
            else
            {
                chieudulieu = "";
            }
        }

        private void rdo_LoiNhuan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_LoiNhuan.Checked)
            {
                chieudulieu = "Doanh Thu";
            }
            else
            {
                chieudulieu = "";
            }
        }

        private void rdo_SoLuongBan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_SoLuongBan.Checked)
            {
                chieudulieu = "So Luong Ban";
            }
            else
            {
                chieudulieu = "";
            }
        }

        private void rdo_ChiPhiVanChuyen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_ChiPhiVanChuyen.Checked)
            {
                chieudulieu = "Chi Phi Van Chuyen";
            }
            else
            {
                chieudulieu = "";
            }
        }

        private void rdo_Thang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Thang.Checked)
            {
                chieuthoigian = "Thang";
            }
            else
            {
                chieuthoigian = "";
            }
        }

        private void rdo_Nam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Nam.Checked)
            {
                chieuthoigian = "Nam";
            }
            else
            {
                chieuthoigian = "";
            }
        }

        private void rdo_Quy_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Quy.Checked)
            {
                chieuthoigian = "Quy";
            }
            else
            {
                chieuthoigian = "";
            }
        }

    }
}
