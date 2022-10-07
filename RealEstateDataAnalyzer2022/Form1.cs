using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Collections.Immutable;
using System.Collections;

namespace RealEstateDataAnalyzer2022
{
    public partial class Form1 : Form
    {
        static int count = 0;
        public static String danjiName = "";
        public static double pyeongName = 0.0;
        public static String pyeongFullName = ""; 

        String Filename = null;

        // ������ �ؽ�

        //��������Ʈ
        public delegate void DataPassEventHandler(List<double> xdatas, List<double> ydatas);

        SortedSet<String> guList = new SortedSet<String>();
        SortedSet<String> dongList = new SortedSet<String>();
        SortedSet<String> danjiList = new SortedSet<String>();
        SortedSet<double> pyeongList = new SortedSet<double>();
        

        //�̺�Ʈ ����
        public event DataPassEventHandler DataPassEvent;

        public static List<DateTime> xdatas = new List<DateTime>();
        public static List<double> ydatas = new List<double>();

        public Form1()
        {
            InitializeComponent();

            dataGridView1.Columns.Add("Period", "ID");
            dataGridView1.Columns.Add("Period", "��/��");
            dataGridView1.Columns.Add("Entire", "��/��");
            dataGridView1.Columns.Add("Normal", "��/��");
            dataGridView1.Columns.Add("Electric", "����");
            dataGridView1.Columns.Add("Cultural", "����");
            dataGridView1.Columns.Add("Nupower", "����");
            dataGridView1.Columns.Add("ETC", "����");
            dataGridView1.Columns.Add("Period", "�����");
            dataGridView1.Columns.Add("Entire", "���ݾ�");
            dataGridView1.Columns.Add("Normal", "��");
            dataGridView1.Columns.Add("Electric", "����⵵");
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�� ���α׷���  \n��Լ�(kyuseokkim@kopo.ac.kr), \n������(oruma66@gmail.com), \n������(codingnb306@naver.com)�� ���� ���ߵǾ����ϴ�.", "Real Estate Data Analyzer 2022");
        }


        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.���� �� - ���� ����� txt,csv ������ �ε�\n   (���� txt(������ �и�) ���ϸ� ����) \n   (�ε��� ������ �������ϰ� ���� ������ �־���մϴ�)\n\n" +
                "2. �� ��Ͽ��� ���ϴ� ���� �� �� �� ��ư Ŭ�� \n\n" +
                "3-1. �� ��Ͽ��� ���ϴ� ���� �� �� �� ��ư Ŭ���ϸ�\n      �� �� ����Ʈ ���� ��ϸ� ���� ��Ͽ� ���\n\n" +
                "3-2. �� ��Ͽ��� ���� ���� ������\n      �� �� ��� ����Ʈ ������ ������Ͽ� ���\n\n" +
                "4. ���� ��Ͽ��� ���ϴ� ���� �� �� �� ��ư Ŭ���ϸ�\n   �ڵ����� �⵵�� ������ �ּ� �ִ� ������ ������ \n\n" +
                "5. ���� ��Ͽ��� ���ϴ� ���� �� ��\n   ����, �⵵ ���� ���� �� �� ��ư Ŭ�� \n\n" +
                "6. Clear ��ư���� �Է»��� �ʱ�ȭ ���� \n\n" +
                "7. ���ǿ� �´� ������ �鸸 ��� �ǰ�,\n   Export ��ư���� �� �����͸� csv���Ϸ� ���� \n\n" +
                "8. Graph ��ư���� �׷��� �׸��� ", "Manual");
        }

        private void ���Ͽ���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guList.Clear();
            ComboBox_Gu.Items.Clear();

            xdatas.Clear();
            ydatas.Clear();

            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.DefaultExt = "db";
            openFileDlg.Filter = "Files(*.xlsx;*.csv;*.txt)|*.xlsx;*.csv;*.txt";
            openFileDlg.ShowDialog();
            if (openFileDlg.FileName.Length > 0)
            {
                foreach (string filename in openFileDlg.FileNames)
                {
                    // taking full path of a file
                    string strPath = openFileDlg.FileName;

                    // initialize the value of filename


                    // using the method
                    Filename = Path.GetFileName(strPath);
                }
            } else
            {
                Application.Restart();
            }

            StreamReader rd = new StreamReader(Filename);

            string firstline = rd.ReadLine();

            string[] cols_name = firstline.Split('\t');


            // �������� �� ������ ����
            while (!rd.EndOfStream)
            {
                // �� ������ �д´�
                string line = rd.ReadLine();

                // ������ �޸��� �и��Ͽ� �÷��� �����
                string[] cols = line.Split('\t');

           
                    // ������ �ؽ�
                guList.Add(cols[1].Trim());

            }

            foreach (String gu in guList)
            {
                ComboBox_Gu.Items.Add(gu);
            }
            ComboBox_Gu.SelectedIndex = 0;
            // ���빰 �ٲܼ� ���� ��
            ComboBox_Gu.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        //���� �ε��ϰ� �� �� �� ��ư ������ ��(��) - ���� ��� ������ ���
        private void Button_Gu_Click(object sender, EventArgs e)
        {

            dongList.Clear();
            danjiList.Clear();
            dataGridView1.Rows.Clear();
            ComboBox_Dong.Items.Clear();
            ComboBox_Danji.Items.Clear();
            ComboBox_Dong.Items.Add("==�̼���==");

            StreamReader rd = new StreamReader(Filename);

            string firstline = rd.ReadLine();

            string[] cols_name = firstline.Split('\t');

            count = 0;

            // �������� �� ������ ����
            while (!rd.EndOfStream)
            {
                // �� ������ �д´�
                string line = rd.ReadLine();

                // ������ �޸��� �и��Ͽ� �÷��� �����
                string[] cols = line.Split('\t');


                if (cols[1] == ComboBox_Gu.Text)
                {
                    count++;
                    //cols[0]=�� , cols[1]=�� , cols[2]=�� , cols[3]=������, cols[4]=����, cols[5]=����, cols[6]=����, cols[7]=�����, cols[8]=���ݾ�, cols[9]=��, cols[10]=����⵵ 
                    dataGridView1.Rows.Add(count, cols[0], cols[1], cols[2], cols[3], Double.Parse(cols[4]), cols[5], cols[6], cols[7], cols[8], cols[9], cols[10]);

                    

                    // ������ �ؽ�
                    dongList.Add(cols[2].Trim());
                    danjiList.Add(cols[3].Trim());

                }

            }

            TextBox_Count.Text = string.Format("{0:#,###}", count);

            //�� �޺��ڽ� �����
            foreach (String dong in dongList)
            {
                ComboBox_Dong.Items.Add(dong);
            }
            //���� �޺��ڽ� �����
            foreach (String danji in danjiList)
            {
                ComboBox_Danji.Items.Add(danji);
            }

            TextBox_Average.Clear();
            TextBox_Max.Clear();
            TextBox_Min.Clear();
            TextBox_Min.Visible = false;
            TextBox_Max.Visible = false;
            TextBox_Average.Visible = false;
            Label_Average.Visible = false;
            Label_Max.Visible = false;
            Label_Min.Visible = false;
            ComboBox_Dong.SelectedIndex = 0;
            // ���빰 �ٲܼ� ���� ��
            ComboBox_Dong.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Danji.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //�� ��Ͽ��� ���� ��ư ������ ��(��) - �� �� ��� ������ ���
        private void Button_Dong_Click(object sender, EventArgs e)
        {
            danjiList.Clear();
            dataGridView1.Rows.Clear();
            ComboBox_Danji.Items.Clear();

            StreamReader rd = new StreamReader(Filename);

            string firstline = rd.ReadLine();

            string[] cols_name = firstline.Split('\t');

            count = 0;

            // �������� �� ������ ����
            while (!rd.EndOfStream)
            {
                // �� ������ �д´�
                string line = rd.ReadLine();

                // ������ �޸��� �и��Ͽ� �÷��� �����
                string[] cols = line.Split('\t');

                
                    if (cols[2] == ComboBox_Dong.Text)
                    {

                        count++;
                        //cols[0]=�� , cols[1]=�� , cols[2]=�� , cols[3]=������, cols[4]=����, cols[5]=����, cols[6]=����, cols[7]=�����, cols[8]=���ݾ�, cols[9]=��, cols[10]=����⵵ 
                        dataGridView1.Rows.Add(count, cols[0], cols[1], cols[2], cols[3], Double.Parse(cols[4]), cols[5], cols[6], cols[7], cols[8], cols[9], cols[10]);

                        // ������ �ؽ�
                        danjiList.Add(cols[3].Trim());


                    }
                

            }
            //���� �޺��ڽ� �����
            foreach (String danji in danjiList)
            {
                ComboBox_Danji.Items.Add(danji);
            }

            TextBox_Count.Text = string.Format("{0:#,###}", count);
            TextBox_Average.Clear();
            TextBox_Max.Clear();
            TextBox_Min.Clear();
            TextBox_Min.Visible = false;
            TextBox_Max.Visible = false;
            TextBox_Average.Visible = false;
            Label_Average.Visible = false;
            Label_Max.Visible = false;
            Label_Min.Visible = false;
            // ���빰 �ٲܼ� ���� ��
            ComboBox_Danji.DropDownStyle = ComboBoxStyle.DropDownList;
        }



        //���� �� �� �˻� ��ư(��)
        private void Button_Danji_Click(object sender, EventArgs e)
        {

            List<String> yearDatas = new();
            List<int> priceDatas = new();

            pyeongList.Clear();
            ComboBox_Area.Items.Clear();
            dataGridView1.Rows.Clear();

            StreamReader rd = new StreamReader(Filename);

            string firstline = rd.ReadLine();

            string[] cols_name = firstline.Split('\t');

            count = 0;

            // �������� �� ������ ����
            while (!rd.EndOfStream)
            {
                // �� ������ �д´�
                string line = rd.ReadLine();

                // ������ �޸��� �и��Ͽ� �÷��� �����
                string[] cols = line.Split('\t');

                if (ComboBox_Dong.Text == "==�̼���==")
                {
                    if (cols[1] == ComboBox_Gu.Text && cols[3]==ComboBox_Danji.Text)
                    {
                        count++;
                        //cols[0]=�� , cols[1]=�� , cols[2]=�� , cols[3]=������, cols[4]=����, cols[5]=����, cols[6]=����, cols[7]=�����, cols[8]=���ݾ�, cols[9]=��, cols[10]=����⵵ 
                        dataGridView1.Rows.Add(count, cols[0], cols[1], cols[2], cols[3], Double.Parse(cols[4]), cols[5], cols[6], cols[7], cols[8], cols[9], cols[10]);

                        

                        // ������ �ؽ�
                        pyeongList.Add(double.Parse(cols[4]));
                        yearDatas.Add(cols[5]);
                        priceDatas.Add(int.Parse(cols[8]));

                    }
                } else
                {
                    if (cols[2] == ComboBox_Dong.Text && cols[3].Trim().Contains(ComboBox_Danji.Text))
                    {
                        count++;
                        //cols[0]=�� , cols[1]=�� , cols[2]=�� , cols[3]=������, cols[4]=����, cols[5]=����, cols[6]=����, cols[7]=�����, cols[8]=���ݾ�, cols[9]=��, cols[10]=����⵵ 
                        dataGridView1.Rows.Add(count, cols[0], cols[1], cols[2], cols[3], Double.Parse(cols[4]), cols[5], cols[6], cols[7], cols[8], cols[9], cols[10]);

                        // ������ �ؽ�
                        pyeongList.Add(double.Parse(cols[4]));
                        yearDatas.Add(cols[5]);
                        priceDatas.Add(int.Parse(cols[8]));

                    }
                }
            }

            TextBox_StartYear.Text = yearDatas.Min();
            TextBox_EndYear.Text = yearDatas.Max();
            
            TextBox_StartPrice.Text = priceDatas.Min().ToString();
            TextBox_EndPrice.Text = priceDatas.Max().ToString();

            TextBox_Count.Text = string.Format("{0:#,###}", count);

            TextBox_Average.Clear();
            TextBox_Max.Clear();
            TextBox_Min.Clear();
            TextBox_Min.Visible = false;
            TextBox_Max.Visible = false;
            TextBox_Average.Visible = false;
            Label_Average.Visible = false;
            Label_Max.Visible = false;
            Label_Min.Visible = false;

            foreach (double pyeong in pyeongList)
            {
                ComboBox_Area.Items.Add((int)(pyeong / 3.3)+"��( "+pyeong+" ��)");
            }

            // ���빰 �ٲܼ� ���� ��
            ComboBox_Area.DropDownStyle = ComboBoxStyle.DropDownList;

            // StreamReader�� ��� �� �ݵ�� �ݴ´�
            rd.Close();
        }


        //���� ��� �Է� �� �˻� ��ư (��)
        public void Button_FinalSearch_Click(object sender, EventArgs e)
        {

            List<int> priceDatas = new();

            StreamReader rd = new StreamReader(Filename);
            int sum = 0;
            count = 0;
            xdatas.Clear();
            ydatas.Clear();
            priceDatas.Clear();
            dataGridView1.Rows.Clear();

            string firstline = rd.ReadLine();
            string[] cols_name = firstline.Split('\t');


            /*double startArea = Double.Parse(textBox5.Text);
            double endArea = Double.Parse(textBox2.Text);*/
            int cutIndex = ComboBox_Area.Text.IndexOf("��");
            String [] Strarr = ComboBox_Area.Text.Split(" ");
            double area = double.Parse(Strarr[1]);
            int startPrice = int.Parse(TextBox_StartPrice.Text);
            int endPrice = int.Parse(TextBox_EndPrice.Text);
            int startYear = int.Parse(TextBox_StartYear.Text);
            int endYear = int.Parse(TextBox_EndYear.Text);


            // �������� �� ������ ����
            while (!rd.EndOfStream)
            {
                // �� ������ �д´�
                string line = rd.ReadLine();

                // ������ �޸��� �и��Ͽ� �÷��� �����
                string[] cols = line.Split('\t');

                //cols[0]=�� , cols[1]=�� , cols[2]=�� , cols[3]=������, cols[4]=����, cols[5]=����, cols[6]=����, cols[7]=�����, cols[8]=���ݾ�, cols[9]=��, cols[10]=����⵵ 

                if (ComboBox_Dong.Text == "==�̼���==")
                {
                    if ((cols[1] == ComboBox_Gu.Text) && (cols[3] == ComboBox_Danji.Text) && (double.Parse(cols[4]) == area) && (int.Parse(cols[8]) >= startPrice) && (int.Parse(cols[8]) <= endPrice) && (int.Parse(cols[5]) >= startYear) && (int.Parse(cols[5]) <= endYear))
                    {

                        count++;

                        dataGridView1.Rows.Add(count, cols[0], cols[1], cols[2], cols[3], cols[4], cols[5], cols[6], cols[7], cols[8], cols[9], cols[10]);

                        xdatas.Add(DateTime.Parse(cols[5] + "." + cols[6] + "." + cols[7]));
                        ydatas.Add(double.Parse(cols[8]));
                        priceDatas.Add(int.Parse(cols[8]));
                        
                    }
                } else
                {
                    if (cols[2] == ComboBox_Dong.Text && cols[3].Contains(ComboBox_Danji.Text) && (double.Parse(cols[4]) == area) && (int.Parse(cols[8]) >= startPrice) && (int.Parse(cols[8]) <= endPrice) && (int.Parse(cols[5]) >= startYear) && (int.Parse(cols[5]) <= endYear))
                    {

                        count++;

                        dataGridView1.Rows.Add(count, cols[0], cols[1], cols[2], cols[3], cols[4], cols[5], cols[6], cols[7], cols[8], cols[9], cols[10]);
                       
                        xdatas.Add(DateTime.Parse(cols[5] + "." + cols[6] + "." + cols[7]));
                        ydatas.Add(double.Parse(cols[8]));
                        priceDatas.Add(int.Parse(cols[8]));
                        
                    }
                }

            }

            if (count == 0)
            {
                dataGridView1.Rows.Add("�����Ͱ� �����ϴ�");
            }

            TextBox_Average.Visible = true;
            TextBox_Max.Visible = true;
            TextBox_Min.Visible = true;
            Label_Average.Visible = true;
            Label_Max.Visible = true;
            Label_Min.Visible = true;

            var Max = string.Format("{0:#,###}", priceDatas.Max());
            var Min = string.Format("{0:#,###}", priceDatas.Min());
            var Avg = string.Format("{0:#,###}", priceDatas.Average());


            TextBox_Count.Text = string.Format("{0:#,###}", count); ;
            TextBox_Max.Text = string.Format("{0:#,###}", Max);
            TextBox_Min.Text = string.Format("{0:#,###}", Min);
            TextBox_Average.Text = string.Format("{0:#,###}", Avg);
            danjiName = ComboBox_Danji.Text;
            pyeongName = int.Parse(ComboBox_Area.Text.Substring(0, cutIndex));
            pyeongFullName = ComboBox_Area.Text;

            // StreamReader�� ��� �� �ݵ�� �ݴ´�
            rd.Close();
        }

        //Export ��ư ������ ��
        private void Button_Export_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "txt (*.txt)|*.txt";
                sfd.FileName = ComboBox_Danji.Text + " " + pyeongFullName +"_"+ TextBox_StartYear.Text + " ~ " + TextBox_EndYear.Text + ".txt";
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
                            int columnCount = dataGridView1.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dataGridView1.Rows.Count + 1];


                            for (int i = 1; i < columnCount; i++)
                            {
                                columnNames += dataGridView1.Columns[i].HeaderText.ToString() + "\t";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 1; j < columnCount; j++)
                                {
                                    outputCsv[i+1] += dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t";
                                }
                            }


                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }

        }

        //Graph ��ư
        private void Button_Graph_Click(object sender, EventArgs e)
        {

            Form3 showForm3 = new Form3();
            showForm3.ShowDialog();


        }


        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //���� �ʱ�ȭ ��ư
        private void Button_Clear_Click(object sender, EventArgs e)
        {
            ComboBox_Dong.Items.Clear();
            ComboBox_Danji.Items.Clear();
            ComboBox_Area.Items.Clear();
            TextBox_StartYear.Clear();
            TextBox_EndYear.Clear();
            TextBox_StartPrice.Clear();
            TextBox_EndPrice.Clear();
            TextBox_Count.Clear();
            TextBox_Average.Clear();
            TextBox_Max.Clear();
            TextBox_Min.Clear();
            TextBox_Min.Visible = false;
            TextBox_Max.Visible = false;
            TextBox_Average.Visible = false;
            Label_Average.Visible = false;
            Label_Max.Visible = false;
            Label_Min.Visible = false;
            ComboBox_Gu.SelectedIndex = 0;

        }

     
    }
}