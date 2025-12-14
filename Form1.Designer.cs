namespace WindowsFormsApp1
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtResult = new DevExpress.XtraEditors.TextEdit();
            this.btnSum = new DevExpress.XtraEditors.SimpleButton();
            this.btnStd = new DevExpress.XtraEditors.SimpleButton();
            this.btnAvg = new DevExpress.XtraEditors.SimpleButton();
            this.memoNumbers = new DevExpress.XtraEditors.MemoEdit();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnInvert = new DevExpress.XtraEditors.SimpleButton();
            this.btnGray = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBoxOutput = new DevExpress.XtraEditors.PictureEdit();
            this.pictureBoxInput = new DevExpress.XtraEditors.PictureEdit();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.txtPrediction = new DevExpress.XtraEditors.TextEdit();
            this.btnPredict = new DevExpress.XtraEditors.SimpleButton();
            this.txtFeature2 = new DevExpress.XtraEditors.TextEdit();
            this.txtFeature1 = new DevExpress.XtraEditors.TextEdit();
            this.gridViewTrain = new System.Windows.Forms.DataGridView();
            this.gridControlTrain = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtResult.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoNumbers.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput.Properties)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrediction.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFeature2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFeature1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(800, 450);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage4});
            this.xtraTabControl1.Click += new System.EventHandler(this.xtraTabControl1_Click);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtResult);
            this.xtraTabPage1.Controls.Add(this.btnSum);
            this.xtraTabPage1.Controls.Add(this.btnStd);
            this.xtraTabPage1.Controls.Add(this.btnAvg);
            this.xtraTabPage1.Controls.Add(this.memoNumbers);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(798, 425);
            this.xtraTabPage1.Text = "Math";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(327, 213);
            this.txtResult.Name = "txtResult";
            this.txtResult.Properties.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 7;
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(221, 144);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(75, 23);
            this.btnSum.TabIndex = 6;
            this.btnSum.Text = "Sum";
            this.btnSum.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // btnStd
            // 
            this.btnStd.Location = new System.Drawing.Point(454, 144);
            this.btnStd.Name = "btnStd";
            this.btnStd.Size = new System.Drawing.Size(75, 23);
            this.btnStd.TabIndex = 5;
            this.btnStd.Text = "StdDev";
            this.btnStd.Click += new System.EventHandler(this.btnStd_Click);
            // 
            // btnAvg
            // 
            this.btnAvg.Location = new System.Drawing.Point(340, 144);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(75, 23);
            this.btnAvg.TabIndex = 4;
            this.btnAvg.Text = "Average";
            this.btnAvg.Click += new System.EventHandler(this.btnAvg_Click);
            // 
            // memoNumbers
            // 
            this.memoNumbers.Location = new System.Drawing.Point(327, 23);
            this.memoNumbers.Name = "memoNumbers";
            this.memoNumbers.Size = new System.Drawing.Size(100, 96);
            this.memoNumbers.TabIndex = 3;
            this.memoNumbers.EditValueChanged += new System.EventHandler(this.memoEdit1_EditValueChanged);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.btnSave);
            this.xtraTabPage2.Controls.Add(this.btnInvert);
            this.xtraTabPage2.Controls.Add(this.btnGray);
            this.xtraTabPage2.Controls.Add(this.btnLoad);
            this.xtraTabPage2.Controls.Add(this.pictureBoxOutput);
            this.xtraTabPage2.Controls.Add(this.pictureBoxInput);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(798, 425);
            this.xtraTabPage2.Text = "Image Processing";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(328, 295);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save Output Image";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnInvert
            // 
            this.btnInvert.Location = new System.Drawing.Point(481, 232);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(75, 23);
            this.btnInvert.TabIndex = 4;
            this.btnInvert.Text = "Invert Image";
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
            // 
            // btnGray
            // 
            this.btnGray.Location = new System.Drawing.Point(341, 232);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(109, 23);
            this.btnGray.TabIndex = 3;
            this.btnGray.Text = " Convert to Grayscale";
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(241, 232);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load Image";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pictureBoxOutput
            // 
            this.pictureBoxOutput.Location = new System.Drawing.Point(456, 70);
            this.pictureBoxOutput.Name = "pictureBoxOutput";
            this.pictureBoxOutput.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureBoxOutput.Size = new System.Drawing.Size(100, 96);
            this.pictureBoxOutput.TabIndex = 1;
            this.pictureBoxOutput.EditValueChanged += new System.EventHandler(this.pictureEdit2_EditValueChanged);
            // 
            // pictureBoxInput
            // 
            this.pictureBoxInput.Location = new System.Drawing.Point(241, 70);
            this.pictureBoxInput.Name = "pictureBoxInput";
            this.pictureBoxInput.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureBoxInput.Size = new System.Drawing.Size(100, 96);
            this.pictureBoxInput.TabIndex = 0;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.txtPrediction);
            this.xtraTabPage4.Controls.Add(this.btnPredict);
            this.xtraTabPage4.Controls.Add(this.txtFeature2);
            this.xtraTabPage4.Controls.Add(this.txtFeature1);
            this.xtraTabPage4.Controls.Add(this.gridViewTrain);
            this.xtraTabPage4.Controls.Add(this.gridControlTrain);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(798, 425);
            this.xtraTabPage4.Text = "ML";
            // 
            // txtPrediction
            // 
            this.txtPrediction.Location = new System.Drawing.Point(83, 302);
            this.txtPrediction.Name = "txtPrediction";
            this.txtPrediction.Properties.ReadOnly = true;
            this.txtPrediction.Size = new System.Drawing.Size(100, 20);
            this.txtPrediction.TabIndex = 5;
            // 
            // btnPredict
            // 
            this.btnPredict.Location = new System.Drawing.Point(96, 242);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(75, 23);
            this.btnPredict.TabIndex = 4;
            this.btnPredict.Text = "Predict";
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // txtFeature2
            // 
            this.txtFeature2.Location = new System.Drawing.Point(151, 190);
            this.txtFeature2.Name = "txtFeature2";
            this.txtFeature2.Size = new System.Drawing.Size(100, 20);
            this.txtFeature2.TabIndex = 3;
            // 
            // txtFeature1
            // 
            this.txtFeature1.Location = new System.Drawing.Point(11, 190);
            this.txtFeature1.Name = "txtFeature1";
            this.txtFeature1.Size = new System.Drawing.Size(100, 20);
            this.txtFeature1.TabIndex = 2;
            // 
            // gridViewTrain
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewTrain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewTrain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewTrain.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewTrain.Location = new System.Drawing.Point(11, 17);
            this.gridViewTrain.Name = "gridViewTrain";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewTrain.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridViewTrain.Size = new System.Drawing.Size(240, 150);
            this.gridViewTrain.TabIndex = 1;
            this.gridViewTrain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewTrain_CellContentClick);
            // 
            // gridControlTrain
            // 
            this.gridControlTrain.Location = new System.Drawing.Point(282, 17);
            this.gridControlTrain.MainView = this.gridView1;
            this.gridControlTrain.Name = "gridControlTrain";
            this.gridControlTrain.Size = new System.Drawing.Size(505, 383);
            this.gridControlTrain.TabIndex = 0;
            this.gridControlTrain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControlTrain.Click += new System.EventHandler(this.gridControlTrain_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlTrain;
            this.gridView1.Name = "gridView1";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(298, 275);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "Form1";
            this.Text = "D";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtResult.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoNumbers.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput.Properties)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPrediction.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFeature2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFeature1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraEditors.MemoEdit memoNumbers;
        private DevExpress.XtraEditors.SimpleButton btnSum;
        private DevExpress.XtraEditors.SimpleButton btnStd;
        private DevExpress.XtraEditors.SimpleButton btnAvg;
        private DevExpress.XtraEditors.TextEdit txtResult;
        private DevExpress.XtraEditors.PictureEdit pictureBoxInput;
        private DevExpress.XtraEditors.PictureEdit pictureBoxOutput;
        private DevExpress.XtraEditors.SimpleButton btnInvert;
        private DevExpress.XtraEditors.SimpleButton btnGray;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.DataGridView gridViewTrain;
        private DevExpress.XtraGrid.GridControl gridControlTrain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtPrediction;
        private DevExpress.XtraEditors.SimpleButton btnPredict;
        private DevExpress.XtraEditors.TextEdit txtFeature2;
        private DevExpress.XtraEditors.TextEdit txtFeature1;
    }
}

