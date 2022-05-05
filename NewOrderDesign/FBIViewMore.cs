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
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace NewOrderDesign
{
    public partial class FBIViewMore : Form
    {
        public FBIViewMore()
        {
            InitializeComponent();
            if (Form6.fullscreentoggle == 1)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            comboBox1.SelectedItem = "Crimes Against Persons";
            dataGridView1.Columns[1].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns[2].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns[3].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns[4].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns[7].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns[8].DefaultCellStyle.Format = "N0";
            dataGridView2.Columns[1].DefaultCellStyle.Format = "N0";
            dataGridView2.Columns[2].DefaultCellStyle.Format = "N0";
            dataGridView2.Columns[3].DefaultCellStyle.Format = "N0";
            dataGridView2.Columns[4].DefaultCellStyle.Format = "N0";
            dataGridView2.Columns[5].DefaultCellStyle.Format = "N0";
            dataGridView2.Columns[6].DefaultCellStyle.Format = "N0";
            dataGridView2.Columns[7].DefaultCellStyle.Format = "N0";
            dataGridView2.Columns[8].DefaultCellStyle.Format = "N0";
            dataGridView2.Columns[9].DefaultCellStyle.Format = "N0";
            dataGridView2.Columns[10].DefaultCellStyle.Format = "N0";
            dataGridView2.Columns[11].DefaultCellStyle.Format = "N0";
            dataGridView2.Columns[12].DefaultCellStyle.Format = "N0";
            dataGridView2.Columns[13].DefaultCellStyle.Format = "N0";
            dataGridView2.Columns[14].DefaultCellStyle.Format = "N0";
            dataGridView2.Columns[15].DefaultCellStyle.Format = "N0";
            dataGridView3.Columns[1].DefaultCellStyle.Format = "N0";
            dataGridView3.Columns[2].DefaultCellStyle.Format = "N0";
            dataGridView3.Columns[3].DefaultCellStyle.Format = "N0";
            dataGridView3.Columns[4].DefaultCellStyle.Format = "N0";
            dataGridView3.Columns[5].DefaultCellStyle.Format = "N0";
            dataGridView3.Columns[6].DefaultCellStyle.Format = "N0";
            dataGridView3.Columns[7].DefaultCellStyle.Format = "N0";
            dataGridView3.Columns[8].DefaultCellStyle.Format = "N0";
            dataGridView3.Columns[9].DefaultCellStyle.Format = "N0";


        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            //set the connection string
            string connString = @"Server = 173.217.234.232\SQLEXPRESS,20222; Database = FBI; User Id = apeuser2; Password = daylonswallows1234;";

            try
            {
                //sql connection object
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query;

                    //retrieve the SQL Server instance version
                    if (String.IsNullOrEmpty(state))
                    {
                        query = $"SELECT * FROM Crimes_Against_" + table + $"_Offenses_Offense_Category_by_State_2020";
                    }
                    else
                    {
                        query = $"SELECT * FROM Crimes_Against_" + table + $"_Offenses_Offense_Category_by_State_2020 WHERE State = '{state}'";
                    }
                    

                    //define the SqlCommand object
                    SqlCommand cmd = new SqlCommand(query, conn);


                    //Set the SqlDataAdapter object
                    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                    //define dataset
                    DataSet ds = new DataSet();

                    //fill dataset with query results

                    dAdapter.Fill(ds);

                    //set DataGridView control to read-only
                    if (table.Equals("Persons"))
                    {
                        exporttoggle = 1;
                        dataGridView1.Show();
                        dataGridView2.Hide();
                        dataGridView3.Hide();
                    }
                    else if (table.Equals("Property"))
                    {
                        exporttoggle = 2;
                        dataGridView1.Hide();
                        dataGridView2.Show();
                        dataGridView3.Hide();
                    }
                    else if (table.Equals("Society"))
                    {
                        exporttoggle = 3;
                        dataGridView1.Hide();
                        dataGridView2.Hide();
                        dataGridView3.Show();
                    }

                    dataGridView1.ReadOnly = true;
                    dataGridView2.ReadOnly = true;
                    dataGridView3.ReadOnly = true;

                    //set the DataGridView control's data source/data table

                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView2.DataSource = ds.Tables[0];
                    dataGridView3.DataSource = ds.Tables[0];


                    //close connection
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        string state;
        string table;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            state = textBox1.Text;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (Form6.fullscreentoggle == 1)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            // TODO: This line of code loads data into the 'fBIDataSet5.Crimes_Against_Society_Offenses_Offense_Category_by_State_2020' table. You can move, or remove it, as needed.
            this.crimes_Against_Society_Offenses_Offense_Category_by_State_2020TableAdapter1.Fill(this.fBIDataSet5.Crimes_Against_Society_Offenses_Offense_Category_by_State_2020);
            // TODO: This line of code loads data into the 'fBIDataSet5.Crimes_Against_Property_Offenses_Offense_Category_by_State_2020' table. You can move, or remove it, as needed.
            this.crimes_Against_Property_Offenses_Offense_Category_by_State_2020TableAdapter1.Fill(this.fBIDataSet5.Crimes_Against_Property_Offenses_Offense_Category_by_State_2020);
            // TODO: This line of code loads data into the 'fBIDataSet5.Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020' table. You can move, or remove it, as needed.
            this.crimes_Against_Persons_Offenses_Offense_Category_by_State_2020TableAdapter2.Fill(this.fBIDataSet5.Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6.fullscreencheck(this);
            USStateInfo form4 = new USStateInfo();
            form4.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Crimes Against Persons"))
            {
                table = "Persons";
            }
            else if (comboBox1.Text.Equals("Crimes Against Property"))
            {
                table = "Property";
            }
            else if (comboBox1.Text.Equals("Crimes Against Society"))
            {
                table = "Society";
            }
            submitbutton.PerformClick();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                submitbutton.PerformClick();
            }
        }
        int exporttoggle = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (exporttoggle == 1)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "FBI Data Export(Persons).pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value?.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(new Paragraph("TravelSite"));
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            if (exporttoggle == 2)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "FBI Data Export(Property).pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value?.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(new Paragraph("TravelSite"));
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            if (exporttoggle == 3)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "FBI Data Export(Society).pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value?.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(new Paragraph("TravelSite"));
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
        }
    }
}
