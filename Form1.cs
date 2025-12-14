using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Services.Math;
using System.Globalization;
using System.Drawing.Imaging;
using WindowsFormsApp1.Services.ImageProcessing;
using WindowsFormsApp1.Models.ML;
using WindowsFormsApp1.Services.ML;




namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly IImageProcessor _imageProcessor = new ImageProcessor();
        private Bitmap _inputBitmap;
        private Bitmap _outputBitmap;


        private void memoEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var nums = ReadNumbersFromMemo();
            txtResult.Text = _mathService.Sum(nums).ToString(CultureInfo.InvariantCulture);
        }
        private readonly IClassifier _classifier = new KnnClassifier();
        private BindingList<Models.ML.DataPoint> _trainingData = new BindingList<Models.ML.DataPoint>();

        private void Form1_Load(object sender, EventArgs e)
        {
            _trainingData = new BindingList<Models.ML.DataPoint>
            {
                new Models.ML.DataPoint { Feature1 = 1,  Feature2 = 1,  Label = "Class A" },
                new Models.ML.DataPoint { Feature1 = 2,  Feature2 = 1.5, Label = "Class A" },
                new Models.ML.DataPoint { Feature1 = 1.5, Feature2 = 2,  Label = "Class A" },

                new Models.ML.DataPoint { Feature1 = 5,  Feature2 = 5,  Label = "Class B" },
                new Models.ML.DataPoint { Feature1 = 6,  Feature2 = 5.5, Label = "Class B" },
                new Models.ML.DataPoint { Feature1 = 5.5, Feature2 = 6,  Label = "Class B" }
            };

            gridControlTrain.DataSource = _trainingData;

            _classifier.SetTrainingData(_trainingData);
        }

        private readonly IMathService _mathService = new MathService();

        private double[] ReadNumbersFromMemo()
        {
            var raw = memoNumbers.Text ?? "";
            raw = raw.Replace("\r", " ").Replace("\n", " ").Replace(",", " ");

            var parts = raw.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            return parts
                .Select(p => double.Parse(p, CultureInfo.InvariantCulture))
                .ToArray();
        }

        
        private void pictureEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _inputBitmap = (Bitmap)Image.FromFile(ofd.FileName);
                    pictureBoxInput.Image = _inputBitmap;
                    _outputBitmap = null;
                    pictureBoxOutput.Image = null;
                }
            }
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            if (_inputBitmap == null)
            {
                MessageBox.Show("Please load an image first.");
                return;
            }

            _outputBitmap = _imageProcessor.ToGrayscale(_inputBitmap);
            pictureBoxOutput.Image = _outputBitmap;
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            if (_inputBitmap == null)
            {
                MessageBox.Show("Please load an image first.");
                return;
            }

            _outputBitmap = _imageProcessor.Invert(_inputBitmap);
            pictureBoxOutput.Image = _outputBitmap;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_outputBitmap == null)
            {
                MessageBox.Show("There is no processed image to save.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg;*.jpeg|Bitmap Image|*.bmp";
                sfd.FileName = "output.png";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ImageFormat format = ImageFormat.Png;

                    if (sfd.FilterIndex == 2)
                        format = ImageFormat.Jpeg;
                    else if (sfd.FilterIndex == 3)
                        format = ImageFormat.Bmp;

                    _outputBitmap.Save(sfd.FileName, format);
                    MessageBox.Show("Image saved successfully.");
                }
            }
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            var nums = ReadNumbersFromMemo();
            txtResult.Text = _mathService.Average(nums).ToString(CultureInfo.InvariantCulture);
        }

        private void btnStd_Click(object sender, EventArgs e)
        {
            var nums = ReadNumbersFromMemo();
            txtResult.Text = _mathService.StdDev(nums).ToString(CultureInfo.InvariantCulture);
        }

        private void gridControlTrain_Click(object sender, EventArgs e)
        {

        }

        private void gridViewTrain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            try
            {
                double f1 = double.Parse(txtFeature1.Text, CultureInfo.InvariantCulture);
                double f2 = double.Parse(txtFeature2.Text, CultureInfo.InvariantCulture);

                // K = 3
                string result = _classifier.Predict(f1, f2, 3);

                txtPrediction.Text = result;
            }
            catch
            {
                MessageBox.Show("Please enter valid numeric values for Feature1 and Feature2.");
            }
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
