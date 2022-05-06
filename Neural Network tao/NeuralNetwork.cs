using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network_tao
{
    class NeuralNetwork
    {
        //มี Input 3 ค่า ก็ต้องสร้าง weight 3 ค่า
        double[] weight;

        //กำหนด คอนสทรัทเตอร์
        public NeuralNetwork()
        {
            Random rand = new Random();

            // สุ่มค่าเวทใส่ไป 3 ตัวในอาเรย์เพื่อเอาไว้ใช้งาน
            weight = new double[] { rand.NextDouble(), rand.NextDouble(), rand.NextDouble() };
        }

        public double predict(int[] neroun_inputs)
        {
            //หาผลรวมของweight เพื่อใช้ในการ ทำ activation function เเล้วนำไป predict ต่อ
            double sum_of_weight_inputs = _sum_of_weight_input(neroun_inputs);

            // นำค่าผลรวมของweight มาคำนวนต่อใน Activation function
            double neuron_output = _activation(sum_of_weight_inputs);
            return neuron_output;

        }


        //Trinin เอาไว้ใช้ในการปรับค่า weight
        public double[] train(List<TrainingSet> training_set_examples,long number_of_iterations) 
        {
            //ทำการวนลูปตามจำนวนครั้งที่เราต้องการ train data
            for(int iteration = 0; iteration < number_of_iterations; iteration++)
            {
                foreach(TrainingSet training_set_example in training_set_examples)
                {
                    // ทำการ predict ก่อน
                    double predicted_outout = predict(training_set_example.Inputs.ToArray());
                    // จากนั้นทำการ หา error costfunction เพื่อปรับค่า weight
                    double error_in_output = _error_cost(training_set_example.Output,predicted_outout);


                    //จากนั้นจะทำการ วนลูป เพื่อทีเราจะได้ปรับค่า weight
                    for(int index = 0; index < this.weight.Length; index++)
                    {
                        // หาค่า weight แต่ละตัว
                        int neural_input = training_set_example.Inputs[index];
                        
                        // ค่า weight ที่ได้ทำการปรับ
                        this.weight[index] += _adjust_weight(neural_input, error_in_output, predicted_outout);
                    }
                }
            }
            return this.weight;
        }
            

        //  หาค่าผลรวมของ weight เพื่อนำไปใช้ในการคำนวนใน Activation function
        private double _sum_of_weight_input(int[] neuron_inputs)
        {
            double sum_of_weigh_inputs = 0;
            for(int index=0; index<neuron_inputs.Length; index++)
            {
                sum_of_weigh_inputs += this.weight[index] * neuron_inputs[index];
            }
            return sum_of_weigh_inputs;
        }


        private double _activation(double sum_of_weight_inputs)
        {
            //sigmoid function
            return 1 / (1 + Math.Exp(-sum_of_weight_inputs));

        }


        //เนื่องจากระหว่างเทรน ต้องใช้ค่า cost ฟังก์ชั่นในการปรับดังนั้นต้องสร้างเมธอดขึ้นมา
        private double _error_cost(double output,double predicted)
        {
            //คำนวนหาค่าคาดเคลื่อน cost function เพื่อที่จได้นำมาใช้ในการปรับค่า weight 
            double error_in_output = output - predicted;
            return error_in_output;


        }

        // ใช้สำหรับในการปรับแก้ไขค่าweight
        private double _adjust_weight(double neuron_input,double error_in_output, double predicted_output)
        {
            //นำค่า weight มาปรับเพื่อเพอ่มประสิทธิภาพโดยใช้งาน  gradient descent (โดยที่จะเป็นการหาค่าต่ำสุดจากในกราฟ พาราโบล่า เพื่อหาค่า cost ที่ต่ำที่สุด)
            // โดยที่การปรับ weight  = input * errorcost * sigmoid gradient(Activation function ที่ทำการ div) 
            // เนื่องจากเราใช้สมการ sigmoid ดังนั้น เราต้องนำมาดิพ  เพื่อหาค่า sigmoid gradient
            //หา sigmoid gradient
            double sigmoid_gradient = predicted_output * (1 - predicted_output);
            
            // ปรับค่า weight
            double adjust_weight = neuron_input * error_in_output * sigmoid_gradient;
            return adjust_weight;
        }

    }
}
