namespace RealEstateDataAnalyzer2022
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파일열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사용법ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Button_Export = new System.Windows.Forms.Button();
            this.Button_FinalSearch = new System.Windows.Forms.Button();
            this.Label_YearExample = new System.Windows.Forms.Label();
            this.Label_Areaunit = new System.Windows.Forms.Label();
            this.Lable_Areaunit = new System.Windows.Forms.Label();
            this.Label_YearCon = new System.Windows.Forms.Label();
            this.TextBox_EndYear = new System.Windows.Forms.TextBox();
            this.TextBox_StartYear = new System.Windows.Forms.TextBox();
            this.Lable_Year = new System.Windows.Forms.Label();
            this.Label_PriceCon = new System.Windows.Forms.Label();
            this.TextBox_EndPrice = new System.Windows.Forms.TextBox();
            this.TextBox_StartPrice = new System.Windows.Forms.TextBox();
            this.Label_Price = new System.Windows.Forms.Label();
            this.Label_Area = new System.Windows.Forms.Label();
            this.Label_Danji = new System.Windows.Forms.Label();
            this.Button_Graph = new System.Windows.Forms.Button();
            this.ComboBox_Danji = new System.Windows.Forms.ComboBox();
            this.Button_Danji = new System.Windows.Forms.Button();
            this.ComboBox_Area = new System.Windows.Forms.ComboBox();
            this.ComboBox_Gu = new System.Windows.Forms.ComboBox();
            this.Label_Gu = new System.Windows.Forms.Label();
            this.Button_Gu = new System.Windows.Forms.Button();
            this.ComboBox_Dong = new System.Windows.Forms.ComboBox();
            this.Label_Dong = new System.Windows.Forms.Label();
            this.Button_Dong = new System.Windows.Forms.Button();
            this.Button_Clear = new System.Windows.Forms.Button();
            this.Label_Count = new System.Windows.Forms.Label();
            this.TextBox_Count = new System.Windows.Forms.TextBox();
            this.TextBox_Max = new System.Windows.Forms.TextBox();
            this.Label_Max = new System.Windows.Forms.Label();
            this.Label_Min = new System.Windows.Forms.Label();
            this.TextBox_Min = new System.Windows.Forms.TextBox();
            this.Label_Average = new System.Windows.Forms.Label();
            this.TextBox_Average = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.정보ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1187, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일열기ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 파일열기ToolStripMenuItem
            // 
            this.파일열기ToolStripMenuItem.Name = "파일열기ToolStripMenuItem";
            this.파일열기ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.파일열기ToolStripMenuItem.Text = "파일 열기";
            this.파일열기ToolStripMenuItem.Click += new System.EventHandler(this.파일열기ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // 정보ToolStripMenuItem
            // 
            this.정보ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.사용법ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.정보ToolStripMenuItem.Name = "정보ToolStripMenuItem";
            this.정보ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.정보ToolStripMenuItem.Text = "도움말";
            // 
            // 사용법ToolStripMenuItem
            // 
            this.사용법ToolStripMenuItem.Name = "사용법ToolStripMenuItem";
            this.사용법ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.사용법ToolStripMenuItem.Text = "사용법";
            this.사용법ToolStripMenuItem.Click += new System.EventHandler(this.사용법ToolStripMenuItem_Click);
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.도움말ToolStripMenuItem.Text = "제작자정보";
            this.도움말ToolStripMenuItem.Click += new System.EventHandler(this.도움말ToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList3.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(12, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1067, 552);
            this.dataGridView1.TabIndex = 0;
            // 
            // Button_Export
            // 
            this.Button_Export.Location = new System.Drawing.Point(1086, 604);
            this.Button_Export.Name = "Button_Export";
            this.Button_Export.Size = new System.Drawing.Size(90, 23);
            this.Button_Export.TabIndex = 4;
            this.Button_Export.Text = "Export";
            this.Button_Export.UseVisualStyleBackColor = true;
            this.Button_Export.Click += new System.EventHandler(this.Button_Export_Click);
            // 
            // Button_FinalSearch
            // 
            this.Button_FinalSearch.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Button_FinalSearch.Location = new System.Drawing.Point(1085, 69);
            this.Button_FinalSearch.Name = "Button_FinalSearch";
            this.Button_FinalSearch.Size = new System.Drawing.Size(90, 25);
            this.Button_FinalSearch.TabIndex = 6;
            this.Button_FinalSearch.Text = "④";
            this.Button_FinalSearch.UseVisualStyleBackColor = false;
            this.Button_FinalSearch.Click += new System.EventHandler(this.Button_FinalSearch_Click);
            // 
            // Label_YearExample
            // 
            this.Label_YearExample.AutoSize = true;
            this.Label_YearExample.BackColor = System.Drawing.Color.Transparent;
            this.Label_YearExample.Font = new System.Drawing.Font("맑은 고딕", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_YearExample.Location = new System.Drawing.Point(1021, 38);
            this.Label_YearExample.Name = "Label_YearExample";
            this.Label_YearExample.Size = new System.Drawing.Size(58, 17);
            this.Label_YearExample.TabIndex = 37;
            this.Label_YearExample.Text = "ex) 2022";
            // 
            // Label_Areaunit
            // 
            this.Label_Areaunit.AutoSize = true;
            this.Label_Areaunit.BackColor = System.Drawing.Color.Transparent;
            this.Label_Areaunit.Font = new System.Drawing.Font("맑은 고딕", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Areaunit.Location = new System.Drawing.Point(1021, 72);
            this.Label_Areaunit.Name = "Label_Areaunit";
            this.Label_Areaunit.Size = new System.Drawing.Size(34, 17);
            this.Label_Areaunit.TabIndex = 36;
            this.Label_Areaunit.Text = "만원";
            // 
            // Lable_Areaunit
            // 
            this.Lable_Areaunit.AutoSize = true;
            this.Lable_Areaunit.BackColor = System.Drawing.Color.Transparent;
            this.Lable_Areaunit.Font = new System.Drawing.Font("맑은 고딕", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lable_Areaunit.Location = new System.Drawing.Point(770, 38);
            this.Lable_Areaunit.Name = "Lable_Areaunit";
            this.Lable_Areaunit.Size = new System.Drawing.Size(21, 17);
            this.Lable_Areaunit.TabIndex = 35;
            this.Lable_Areaunit.Text = "평";
            // 
            // Label_YearCon
            // 
            this.Label_YearCon.AutoSize = true;
            this.Label_YearCon.BackColor = System.Drawing.Color.Transparent;
            this.Label_YearCon.Location = new System.Drawing.Point(930, 36);
            this.Label_YearCon.Name = "Label_YearCon";
            this.Label_YearCon.Size = new System.Drawing.Size(15, 15);
            this.Label_YearCon.TabIndex = 32;
            this.Label_YearCon.Text = "~";
            // 
            // TextBox_EndYear
            // 
            this.TextBox_EndYear.Location = new System.Drawing.Point(947, 37);
            this.TextBox_EndYear.Name = "TextBox_EndYear";
            this.TextBox_EndYear.Size = new System.Drawing.Size(68, 23);
            this.TextBox_EndYear.TabIndex = 31;
            // 
            // TextBox_StartYear
            // 
            this.TextBox_StartYear.Location = new System.Drawing.Point(854, 37);
            this.TextBox_StartYear.Name = "TextBox_StartYear";
            this.TextBox_StartYear.Size = new System.Drawing.Size(68, 23);
            this.TextBox_StartYear.TabIndex = 30;
            // 
            // Lable_Year
            // 
            this.Lable_Year.AutoSize = true;
            this.Lable_Year.BackColor = System.Drawing.Color.Transparent;
            this.Lable_Year.Font = new System.Drawing.Font("맑은 고딕", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lable_Year.Location = new System.Drawing.Point(810, 38);
            this.Lable_Year.Name = "Lable_Year";
            this.Lable_Year.Size = new System.Drawing.Size(47, 17);
            this.Lable_Year.TabIndex = 29;
            this.Lable_Year.Text = "년도 : ";
            // 
            // Label_PriceCon
            // 
            this.Label_PriceCon.AutoSize = true;
            this.Label_PriceCon.BackColor = System.Drawing.Color.Transparent;
            this.Label_PriceCon.Location = new System.Drawing.Point(930, 71);
            this.Label_PriceCon.Name = "Label_PriceCon";
            this.Label_PriceCon.Size = new System.Drawing.Size(15, 15);
            this.Label_PriceCon.TabIndex = 28;
            this.Label_PriceCon.Text = "~";
            // 
            // TextBox_EndPrice
            // 
            this.TextBox_EndPrice.Location = new System.Drawing.Point(947, 69);
            this.TextBox_EndPrice.Name = "TextBox_EndPrice";
            this.TextBox_EndPrice.Size = new System.Drawing.Size(68, 23);
            this.TextBox_EndPrice.TabIndex = 27;
            // 
            // TextBox_StartPrice
            // 
            this.TextBox_StartPrice.Location = new System.Drawing.Point(854, 69);
            this.TextBox_StartPrice.Name = "TextBox_StartPrice";
            this.TextBox_StartPrice.Size = new System.Drawing.Size(68, 23);
            this.TextBox_StartPrice.TabIndex = 26;
            // 
            // Label_Price
            // 
            this.Label_Price.AutoSize = true;
            this.Label_Price.BackColor = System.Drawing.Color.Transparent;
            this.Label_Price.Font = new System.Drawing.Font("맑은 고딕", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Price.Location = new System.Drawing.Point(810, 72);
            this.Label_Price.Name = "Label_Price";
            this.Label_Price.Size = new System.Drawing.Size(47, 17);
            this.Label_Price.TabIndex = 25;
            this.Label_Price.Text = "가격 : ";
            // 
            // Label_Area
            // 
            this.Label_Area.AutoSize = true;
            this.Label_Area.BackColor = System.Drawing.Color.Transparent;
            this.Label_Area.Font = new System.Drawing.Font("맑은 고딕", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Area.Location = new System.Drawing.Point(598, 38);
            this.Label_Area.Name = "Label_Area";
            this.Label_Area.Size = new System.Drawing.Size(47, 17);
            this.Label_Area.TabIndex = 21;
            this.Label_Area.Text = "면적 : ";
            // 
            // Label_Danji
            // 
            this.Label_Danji.AutoSize = true;
            this.Label_Danji.BackColor = System.Drawing.Color.Transparent;
            this.Label_Danji.Font = new System.Drawing.Font("맑은 고딕", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Danji.Location = new System.Drawing.Point(238, 39);
            this.Label_Danji.Name = "Label_Danji";
            this.Label_Danji.Size = new System.Drawing.Size(55, 17);
            this.Label_Danji.TabIndex = 20;
            this.Label_Danji.Text = "단지명 :";
            // 
            // Button_Graph
            // 
            this.Button_Graph.Location = new System.Drawing.Point(1085, 633);
            this.Button_Graph.Name = "Button_Graph";
            this.Button_Graph.Size = new System.Drawing.Size(91, 23);
            this.Button_Graph.TabIndex = 39;
            this.Button_Graph.Text = "Graph";
            this.Button_Graph.UseVisualStyleBackColor = true;
            this.Button_Graph.Click += new System.EventHandler(this.Button_Graph_Click);
            // 
            // ComboBox_Danji
            // 
            this.ComboBox_Danji.FormattingEnabled = true;
            this.ComboBox_Danji.Location = new System.Drawing.Point(299, 37);
            this.ComboBox_Danji.Name = "ComboBox_Danji";
            this.ComboBox_Danji.Size = new System.Drawing.Size(221, 23);
            this.ComboBox_Danji.TabIndex = 40;
            // 
            // Button_Danji
            // 
            this.Button_Danji.Location = new System.Drawing.Point(526, 37);
            this.Button_Danji.Name = "Button_Danji";
            this.Button_Danji.Size = new System.Drawing.Size(51, 23);
            this.Button_Danji.TabIndex = 43;
            this.Button_Danji.Text = "③";
            this.Button_Danji.UseVisualStyleBackColor = true;
            this.Button_Danji.Click += new System.EventHandler(this.Button_Danji_Click);
            // 
            // ComboBox_Area
            // 
            this.ComboBox_Area.FormattingEnabled = true;
            this.ComboBox_Area.Location = new System.Drawing.Point(639, 37);
            this.ComboBox_Area.Name = "ComboBox_Area";
            this.ComboBox_Area.Size = new System.Drawing.Size(125, 23);
            this.ComboBox_Area.TabIndex = 44;
            // 
            // ComboBox_Gu
            // 
            this.ComboBox_Gu.FormattingEnabled = true;
            this.ComboBox_Gu.Location = new System.Drawing.Point(48, 37);
            this.ComboBox_Gu.Name = "ComboBox_Gu";
            this.ComboBox_Gu.Size = new System.Drawing.Size(121, 23);
            this.ComboBox_Gu.TabIndex = 45;
            // 
            // Label_Gu
            // 
            this.Label_Gu.AutoSize = true;
            this.Label_Gu.BackColor = System.Drawing.Color.Transparent;
            this.Label_Gu.Font = new System.Drawing.Font("맑은 고딕", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Gu.Location = new System.Drawing.Point(12, 38);
            this.Label_Gu.Name = "Label_Gu";
            this.Label_Gu.Size = new System.Drawing.Size(34, 17);
            this.Label_Gu.TabIndex = 46;
            this.Label_Gu.Text = "구 : ";
            // 
            // Button_Gu
            // 
            this.Button_Gu.Location = new System.Drawing.Point(175, 37);
            this.Button_Gu.Name = "Button_Gu";
            this.Button_Gu.Size = new System.Drawing.Size(43, 23);
            this.Button_Gu.TabIndex = 47;
            this.Button_Gu.Text = "①";
            this.Button_Gu.UseVisualStyleBackColor = true;
            this.Button_Gu.Click += new System.EventHandler(this.Button_Gu_Click);
            // 
            // ComboBox_Dong
            // 
            this.ComboBox_Dong.FormattingEnabled = true;
            this.ComboBox_Dong.Location = new System.Drawing.Point(48, 69);
            this.ComboBox_Dong.Name = "ComboBox_Dong";
            this.ComboBox_Dong.Size = new System.Drawing.Size(121, 23);
            this.ComboBox_Dong.TabIndex = 45;
            // 
            // Label_Dong
            // 
            this.Label_Dong.AutoSize = true;
            this.Label_Dong.BackColor = System.Drawing.Color.Transparent;
            this.Label_Dong.Font = new System.Drawing.Font("맑은 고딕", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Dong.Location = new System.Drawing.Point(12, 72);
            this.Label_Dong.Name = "Label_Dong";
            this.Label_Dong.Size = new System.Drawing.Size(34, 17);
            this.Label_Dong.TabIndex = 46;
            this.Label_Dong.Text = "동 : ";
            // 
            // Button_Dong
            // 
            this.Button_Dong.Location = new System.Drawing.Point(175, 69);
            this.Button_Dong.Name = "Button_Dong";
            this.Button_Dong.Size = new System.Drawing.Size(43, 23);
            this.Button_Dong.TabIndex = 47;
            this.Button_Dong.Text = "②";
            this.Button_Dong.UseVisualStyleBackColor = true;
            this.Button_Dong.Click += new System.EventHandler(this.Button_Dong_Click);
            // 
            // Button_Clear
            // 
            this.Button_Clear.Location = new System.Drawing.Point(1085, 37);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(90, 23);
            this.Button_Clear.TabIndex = 49;
            this.Button_Clear.Text = "Clear";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // Label_Count
            // 
            this.Label_Count.AutoSize = true;
            this.Label_Count.BackColor = System.Drawing.Color.Transparent;
            this.Label_Count.Location = new System.Drawing.Point(1085, 155);
            this.Label_Count.Name = "Label_Count";
            this.Label_Count.Size = new System.Drawing.Size(59, 15);
            this.Label_Count.TabIndex = 50;
            this.Label_Count.Text = "조회 건수";
            // 
            // TextBox_Count
            // 
            this.TextBox_Count.Location = new System.Drawing.Point(1085, 173);
            this.TextBox_Count.Name = "TextBox_Count";
            this.TextBox_Count.ReadOnly = true;
            this.TextBox_Count.Size = new System.Drawing.Size(91, 23);
            this.TextBox_Count.TabIndex = 51;
            this.TextBox_Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TextBox_Max
            // 
            this.TextBox_Max.Location = new System.Drawing.Point(1085, 245);
            this.TextBox_Max.Name = "TextBox_Max";
            this.TextBox_Max.ReadOnly = true;
            this.TextBox_Max.Size = new System.Drawing.Size(90, 23);
            this.TextBox_Max.TabIndex = 52;
            this.TextBox_Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextBox_Max.Visible = false;
            // 
            // Label_Max
            // 
            this.Label_Max.AutoSize = true;
            this.Label_Max.BackColor = System.Drawing.Color.Transparent;
            this.Label_Max.Location = new System.Drawing.Point(1085, 227);
            this.Label_Max.Name = "Label_Max";
            this.Label_Max.Size = new System.Drawing.Size(75, 15);
            this.Label_Max.TabIndex = 53;
            this.Label_Max.Text = "최고가(만원)";
            this.Label_Max.Visible = false;
            // 
            // Label_Min
            // 
            this.Label_Min.AutoSize = true;
            this.Label_Min.BackColor = System.Drawing.Color.Transparent;
            this.Label_Min.Location = new System.Drawing.Point(1085, 283);
            this.Label_Min.Name = "Label_Min";
            this.Label_Min.Size = new System.Drawing.Size(75, 15);
            this.Label_Min.TabIndex = 54;
            this.Label_Min.Text = "최저가(만원)";
            this.Label_Min.Visible = false;
            // 
            // TextBox_Min
            // 
            this.TextBox_Min.Location = new System.Drawing.Point(1085, 301);
            this.TextBox_Min.Name = "TextBox_Min";
            this.TextBox_Min.ReadOnly = true;
            this.TextBox_Min.Size = new System.Drawing.Size(90, 23);
            this.TextBox_Min.TabIndex = 55;
            this.TextBox_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextBox_Min.Visible = false;
            // 
            // Label_Average
            // 
            this.Label_Average.AutoSize = true;
            this.Label_Average.BackColor = System.Drawing.Color.Transparent;
            this.Label_Average.Location = new System.Drawing.Point(1086, 336);
            this.Label_Average.Name = "Label_Average";
            this.Label_Average.Size = new System.Drawing.Size(75, 15);
            this.Label_Average.TabIndex = 56;
            this.Label_Average.Text = "평균가(만원)";
            this.Label_Average.Visible = false;
            // 
            // TextBox_Average
            // 
            this.TextBox_Average.Location = new System.Drawing.Point(1086, 354);
            this.TextBox_Average.Name = "TextBox_Average";
            this.TextBox_Average.ReadOnly = true;
            this.TextBox_Average.Size = new System.Drawing.Size(90, 23);
            this.TextBox_Average.TabIndex = 57;
            this.TextBox_Average.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextBox_Average.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1187, 668);
            this.Controls.Add(this.TextBox_Average);
            this.Controls.Add(this.Label_Average);
            this.Controls.Add(this.TextBox_Min);
            this.Controls.Add(this.Label_Min);
            this.Controls.Add(this.Label_Max);
            this.Controls.Add(this.TextBox_Max);
            this.Controls.Add(this.TextBox_Count);
            this.Controls.Add(this.Label_Count);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.Button_Dong);
            this.Controls.Add(this.Button_Gu);
            this.Controls.Add(this.Label_Dong);
            this.Controls.Add(this.Label_Gu);
            this.Controls.Add(this.ComboBox_Dong);
            this.Controls.Add(this.ComboBox_Gu);
            this.Controls.Add(this.ComboBox_Area);
            this.Controls.Add(this.Button_Danji);
            this.Controls.Add(this.ComboBox_Danji);
            this.Controls.Add(this.Button_Graph);
            this.Controls.Add(this.Label_YearExample);
            this.Controls.Add(this.Label_Areaunit);
            this.Controls.Add(this.Lable_Areaunit);
            this.Controls.Add(this.Label_YearCon);
            this.Controls.Add(this.TextBox_EndYear);
            this.Controls.Add(this.TextBox_StartYear);
            this.Controls.Add(this.Lable_Year);
            this.Controls.Add(this.Label_PriceCon);
            this.Controls.Add(this.TextBox_EndPrice);
            this.Controls.Add(this.TextBox_StartPrice);
            this.Controls.Add(this.Label_Price);
            this.Controls.Add(this.Label_Area);
            this.Controls.Add(this.Label_Danji);
            this.Controls.Add(this.Button_FinalSearch);
            this.Controls.Add(this.Button_Export);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Real Estate Data Analyzer 2022";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 파일ToolStripMenuItem;
        private ToolStripMenuItem 파일열기ToolStripMenuItem;
        private ToolStripMenuItem 종료ToolStripMenuItem;
        private ToolStripMenuItem 도움말ToolStripMenuItem;
        private ToolStripMenuItem 사용법ToolStripMenuItem;
        private ToolStripMenuItem 정보ToolStripMenuItem;
        private NotifyIcon notifyIcon1;
        private ImageList imageList1;
        private ImageList imageList2;
        private ImageList imageList3;

        private Button Button_Gu;
        private Button Button_Dong;
        private Button Button_Danji;
        private Button Button_FinalSearch;
        private Button Button_Export;
        public Button Button_Graph;
        private TextBox TextBox_EndYear;
        private TextBox TextBox_StartYear;
        private TextBox TextBox_EndPrice;
        private TextBox TextBox_StartPrice;

        private Label Label_Gu;
        private Label Label_Dong;
        private Label Label_Price;
        private Label Label_Area;
        private Label Label_Danji;
        private Label Lable_Year;
        private Label Label_PriceCon;
        private Label Label_YearExample;
        private Label Label_Areaunit;
        private Label Lable_Areaunit;
        private Label Label_YearCon;
 
        public DataGridView dataGridView1;
        
        private ComboBox ComboBox_Area;
        public ComboBox ComboBox_Danji;
        private ComboBox ComboBox_Gu;
        private ComboBox ComboBox_Dong;
        private Button Button_Clear;
        private Label Label_Count;
        private TextBox TextBox_Count;
        private Label Label_Max;
        private Label Label_Min;
        private Label Label_Average;
        public TextBox TextBox_Average;
        public TextBox TextBox_Max;
        public TextBox TextBox_Min;
    }

    class dataGridView1 : DataGridView
    {
        public dataGridView1()
        {
            DoubleBuffered = true;
        }
    }

}