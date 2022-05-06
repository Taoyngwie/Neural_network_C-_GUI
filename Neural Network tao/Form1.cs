using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neural_Network_tao
{
    public partial class Form1 : Form
    {
        // ประกาศตัวแปรไว้ด้านบน
        NeuralNetwork neuralNetwork;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Browse

            //ใช้งานการเปิดไฟล์
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // ให้มีการจำ path
                openFileDialog.RestoreDirectory = true;
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // อ่านไฟล์เข้ามา
                    textBox_pathfile.Text = openFileDialog.FileName;

                    //เรียกใช้งาน NeuralNetwork จากบรรทัดที่ 17
                    neuralNetwork = new NeuralNetwork();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Train

            // อ่านไฟล์พร้อมนำไปใส่ใน Trainingset
            List<TrainingSet> training_set_example = JsonConvert.DeserializeObject<List<TrainingSet>>(File.ReadAllText(textBox_pathfile.Text));

            //เมื่อกดปุ่ม train ให้ทำการ train ตามจำนวน iteration
            // โดยที่จะทำการแปลง textbox จาก str เป็น int
            int number_of_iteration = int.Parse(textBox_NumberOfIteration.Text);

            //รีบค่า weight จากการ train
            double[] weight = neuralNetwork.train(training_set_example,number_of_iteration);

            //นำค่า weight ที่ได้จากการ train มาแสดงผลใน label โดยที่เราจะแสดงเป็นทศนิยม 3 ตำแหน่ง
            label_weight1.Text = weight[0].ToString("0.000");
            label_weight2.Text = weight[1].ToString("0.000");
            label_weight3.Text = weight[2].ToString("0.000");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox_input2_TextChanged(object sender, EventArgs e)
        {
            //Input2
        }

        private void textBox_input1_TextChanged(object sender, EventArgs e)
        {
            //Input1
        }

        private void textBox_input3_TextChanged(object sender, EventArgs e)
        {
            //Input3
        }

        private void textBox_Output_TextChanged(object sender, EventArgs e)
        {
            //Output
        }

        private void button_predict_Click(object sender, EventArgs e)
        {
            //Predict
            if(neuralNetwork != null)
            {
                // ทำการหาตัว Predict ใน textbox ทั้ง 3
                double predict = neuralNetwork.predict(new int[] { int.Parse(textBox_input1.Text), int.Parse(textBox_input2.Text), int.Parse(textBox_input3.Text) });


                // หา ratio
                //มากกว่า 0.5 ให้เป็น 1
                if(predict > 0.50)
                {
                    // แสดงค่า predict ใน textbox output
                    textBox_Output.Text = "1";
                }else
                {
                    textBox_Output.Text = "0";
                }
            }

        }

        private void textBox_pathfile_TextChanged(object sender, EventArgs e)
        {
            //textBox_pathfile
        }

        private void textBox_NumberOfIteration_TextChanged(object sender, EventArgs e)
        {
            //NumberOfIteration
        }

        private void label_weight1_Click(object sender, EventArgs e)
        {

        }

        private void label_weight2_Click(object sender, EventArgs e)
        {

        }

        private void label_weight3_Click(object sender, EventArgs e)
        {

        }
    }
}
