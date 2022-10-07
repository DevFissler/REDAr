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

        // 정지훈 해쉬

        //델리게이트
        public delegate void DataPassEventHandler(List<double> xdatas, List<double> ydatas);

        SortedSet<String> guList = new SortedSet<String>();
        SortedSet<String> dongList = new SortedSet<String>();
        SortedSet<String> danjiList = new SortedSet<String>();
        SortedSet<double> pyeongList = new SortedSet<double>();
        

        //이벤트 생성
        public event DataPassEventHandler DataPassEvent;

        public static List<DateTime> xdatas = new List<DateTime>();
        public static List<double> ydatas = new List<double>();

        public Form1()
        {
            InitializeComponent();

            dataGridView1.Columns.Add("Period", "ID");
            dataGridView1.Columns.Add("Period", "시/도");
            dataGridView1.Columns.Add("Entire", "구/군");
            dataGridView1.Columns.Add("Normal", "동/면");
            dataGridView1.Columns.Add("Electric", "단지");
            dataGridView1.Columns.Add("Cultural", "면적");
            dataGridView1.Columns.Add("Nupower", "계약년");
            dataGridView1.Columns.Add("ETC", "계약월");
            dataGridView1.Columns.Add("Period", "계약일");
            dataGridView1.Columns.Add("Entire", "계약금액");
            dataGridView1.Columns.Add("Normal", "층");
            dataGridView1.Columns.Add("Electric", "건축년도");
        }

        private void 도움말ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("이 프로그램은  \n김규석(kyuseokkim@kopo.ac.kr), \n안재형(oruma66@gmail.com), \n정지훈(codingnb306@naver.com)에 의해 개발되었습니다.", "Real Estate Data Analyzer 2022");
        }


        private void 사용법ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.파일 탭 - 파일 열기로 txt,csv 파일을 로드\n   (현재 txt(탭으로 분리) 파일만 가능) \n   (로드할 파일이 실행파일과 같은 폴더에 있어야합니다)\n\n" +
                "2. 구 목록에서 원하는 구를 고른 후 ① 버튼 클릭 \n\n" +
                "3-1. 동 목록에서 원하는 동을 고른 후 ② 버튼 클릭하면\n      동 내 아파트 단지 목록만 단지 목록에 출력\n\n" +
                "3-2. 동 목록에서 동을 고르지 않으면\n      구 내 모든 아파트 단지가 단지목록에 출력\n\n" +
                "4. 단지 목록에서 원하는 단지 고른 후 ③ 버튼 클릭하면\n   자동으로 년도와 가격의 최소 최대 범위가 설정됨 \n\n" +
                "5. 평형 목록에서 원하는 평형 고른 후\n   가격, 년도 범위 설정 후 ④ 버튼 클릭 \n\n" +
                "6. Clear 버튼으로 입력사항 초기화 가능 \n\n" +
                "7. 조건에 맞는 데이터 들만 출력 되고,\n   Export 버튼으로 그 데이터를 csv파일로 추출 \n\n" +
                "8. Graph 버튼으로 그래프 그리기 ", "Manual");
        }

        private void 파일열기ToolStripMenuItem_Click(object sender, EventArgs e)
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


            // 마지막이 될 때까지 루프
            while (!rd.EndOfStream)
            {
                // 한 라인을 읽는다
                string line = rd.ReadLine();

                // 라인을 콤마로 분리하여 컬럼을 만든다
                string[] cols = line.Split('\t');

           
                    // 정지훈 해쉬
                guList.Add(cols[1].Trim());

            }

            foreach (String gu in guList)
            {
                ComboBox_Gu.Items.Add(gu);
            }
            ComboBox_Gu.SelectedIndex = 0;
            // 내용물 바꿀수 없게 함
            ComboBox_Gu.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        //파일 로드하고 구 고른 후 버튼 눌렀을 때(①) - 구내 모든 데이터 출력
        private void Button_Gu_Click(object sender, EventArgs e)
        {

            dongList.Clear();
            danjiList.Clear();
            dataGridView1.Rows.Clear();
            ComboBox_Dong.Items.Clear();
            ComboBox_Danji.Items.Clear();
            ComboBox_Dong.Items.Add("==미선택==");

            StreamReader rd = new StreamReader(Filename);

            string firstline = rd.ReadLine();

            string[] cols_name = firstline.Split('\t');

            count = 0;

            // 마지막이 될 때까지 루프
            while (!rd.EndOfStream)
            {
                // 한 라인을 읽는다
                string line = rd.ReadLine();

                // 라인을 콤마로 분리하여 컬럼을 만든다
                string[] cols = line.Split('\t');


                if (cols[1] == ComboBox_Gu.Text)
                {
                    count++;
                    //cols[0]=시 , cols[1]=구 , cols[2]=동 , cols[3]=단지명, cols[4]=면적, cols[5]=계약년, cols[6]=계약월, cols[7]=계약일, cols[8]=계약금액, cols[9]=층, cols[10]=건축년도 
                    dataGridView1.Rows.Add(count, cols[0], cols[1], cols[2], cols[3], Double.Parse(cols[4]), cols[5], cols[6], cols[7], cols[8], cols[9], cols[10]);

                    

                    // 정지훈 해쉬
                    dongList.Add(cols[2].Trim());
                    danjiList.Add(cols[3].Trim());

                }

            }

            TextBox_Count.Text = string.Format("{0:#,###}", count);

            //동 콤보박스 만들기
            foreach (String dong in dongList)
            {
                ComboBox_Dong.Items.Add(dong);
            }
            //단지 콤보박스 만들기
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
            // 내용물 바꿀수 없게 함
            ComboBox_Dong.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Danji.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //동 목록에서 고르고 버튼 눌렀을 때(②) - 동 내 모든 데이터 출력
        private void Button_Dong_Click(object sender, EventArgs e)
        {
            danjiList.Clear();
            dataGridView1.Rows.Clear();
            ComboBox_Danji.Items.Clear();

            StreamReader rd = new StreamReader(Filename);

            string firstline = rd.ReadLine();

            string[] cols_name = firstline.Split('\t');

            count = 0;

            // 마지막이 될 때까지 루프
            while (!rd.EndOfStream)
            {
                // 한 라인을 읽는다
                string line = rd.ReadLine();

                // 라인을 콤마로 분리하여 컬럼을 만든다
                string[] cols = line.Split('\t');

                
                    if (cols[2] == ComboBox_Dong.Text)
                    {

                        count++;
                        //cols[0]=시 , cols[1]=구 , cols[2]=동 , cols[3]=단지명, cols[4]=면적, cols[5]=계약년, cols[6]=계약월, cols[7]=계약일, cols[8]=계약금액, cols[9]=층, cols[10]=건축년도 
                        dataGridView1.Rows.Add(count, cols[0], cols[1], cols[2], cols[3], Double.Parse(cols[4]), cols[5], cols[6], cols[7], cols[8], cols[9], cols[10]);

                        // 정지훈 해쉬
                        danjiList.Add(cols[3].Trim());


                    }
                

            }
            //단지 콤보박스 만들기
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
            // 내용물 바꿀수 없게 함
            ComboBox_Danji.DropDownStyle = ComboBoxStyle.DropDownList;
        }



        //단지 고른 후 검색 버튼(③)
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

            // 마지막이 될 때까지 루프
            while (!rd.EndOfStream)
            {
                // 한 라인을 읽는다
                string line = rd.ReadLine();

                // 라인을 콤마로 분리하여 컬럼을 만든다
                string[] cols = line.Split('\t');

                if (ComboBox_Dong.Text == "==미선택==")
                {
                    if (cols[1] == ComboBox_Gu.Text && cols[3]==ComboBox_Danji.Text)
                    {
                        count++;
                        //cols[0]=시 , cols[1]=구 , cols[2]=동 , cols[3]=단지명, cols[4]=면적, cols[5]=계약년, cols[6]=계약월, cols[7]=계약일, cols[8]=계약금액, cols[9]=층, cols[10]=건축년도 
                        dataGridView1.Rows.Add(count, cols[0], cols[1], cols[2], cols[3], Double.Parse(cols[4]), cols[5], cols[6], cols[7], cols[8], cols[9], cols[10]);

                        

                        // 정지훈 해쉬
                        pyeongList.Add(double.Parse(cols[4]));
                        yearDatas.Add(cols[5]);
                        priceDatas.Add(int.Parse(cols[8]));

                    }
                } else
                {
                    if (cols[2] == ComboBox_Dong.Text && cols[3].Trim().Contains(ComboBox_Danji.Text))
                    {
                        count++;
                        //cols[0]=시 , cols[1]=구 , cols[2]=동 , cols[3]=단지명, cols[4]=면적, cols[5]=계약년, cols[6]=계약월, cols[7]=계약일, cols[8]=계약금액, cols[9]=층, cols[10]=건축년도 
                        dataGridView1.Rows.Add(count, cols[0], cols[1], cols[2], cols[3], Double.Parse(cols[4]), cols[5], cols[6], cols[7], cols[8], cols[9], cols[10]);

                        // 정지훈 해쉬
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
                ComboBox_Area.Items.Add((int)(pyeong / 3.3)+"평( "+pyeong+" ㎡)");
            }

            // 내용물 바꿀수 없게 함
            ComboBox_Area.DropDownStyle = ComboBoxStyle.DropDownList;

            // StreamReader는 사용 후 반드시 닫는다
            rd.Close();
        }


        //조건 모두 입력 후 검색 버튼 (④)
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
            int cutIndex = ComboBox_Area.Text.IndexOf("평");
            String [] Strarr = ComboBox_Area.Text.Split(" ");
            double area = double.Parse(Strarr[1]);
            int startPrice = int.Parse(TextBox_StartPrice.Text);
            int endPrice = int.Parse(TextBox_EndPrice.Text);
            int startYear = int.Parse(TextBox_StartYear.Text);
            int endYear = int.Parse(TextBox_EndYear.Text);


            // 마지막이 될 때까지 루프
            while (!rd.EndOfStream)
            {
                // 한 라인을 읽는다
                string line = rd.ReadLine();

                // 라인을 콤마로 분리하여 컬럼을 만든다
                string[] cols = line.Split('\t');

                //cols[0]=시 , cols[1]=구 , cols[2]=동 , cols[3]=단지명, cols[4]=면적, cols[5]=계약년, cols[6]=계약월, cols[7]=계약일, cols[8]=계약금액, cols[9]=층, cols[10]=건축년도 

                if (ComboBox_Dong.Text == "==미선택==")
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
                dataGridView1.Rows.Add("데이터가 없습니다");
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

            // StreamReader는 사용 후 반드시 닫는다
            rd.Close();
        }

        //Export 버튼 눌렀을 때
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

        //Graph 버튼
        private void Button_Graph_Click(object sender, EventArgs e)
        {

            Form3 showForm3 = new Form3();
            showForm3.ShowDialog();


        }


        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //조건 초기화 버튼
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