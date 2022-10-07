namespace RealEstateDataAnalyzer2022
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_DrawGraph = new System.Windows.Forms.Button();
            this.scatterPlot = new ScottPlot.FormsPlot();
            this.Button_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_DrawGraph
            // 
            this.Button_DrawGraph.Location = new System.Drawing.Point(695, 33);
            this.Button_DrawGraph.Name = "Button_DrawGraph";
            this.Button_DrawGraph.Size = new System.Drawing.Size(93, 23);
            this.Button_DrawGraph.TabIndex = 1;
            this.Button_DrawGraph.Text = "Draw Graph";
            this.Button_DrawGraph.UseVisualStyleBackColor = true;
            this.Button_DrawGraph.Click += new System.EventHandler(this.button1_Click);
            // 
            // scatterPlot
            // 
            this.scatterPlot.Location = new System.Drawing.Point(13, 12);
            this.scatterPlot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.scatterPlot.Name = "scatterPlot";
            this.scatterPlot.Size = new System.Drawing.Size(670, 411);
            this.scatterPlot.TabIndex = 2;
            this.scatterPlot.Visible = false;
            // 
            // Button_Save
            // 
            this.Button_Save.Location = new System.Drawing.Point(696, 65);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(93, 23);
            this.Button_Save.TabIndex = 3;
            this.Button_Save.Text = "Save Image";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.scatterPlot);
            this.Controls.Add(this.Button_DrawGraph);
            this.Name = "Form3";
            this.Text = "Graph";
            this.ResumeLayout(false);

        }

        #endregion

       
        private Button Button_DrawGraph;
        public ScottPlot.FormsPlot scatterPlot;
        private Button Button_Save;
    }
}