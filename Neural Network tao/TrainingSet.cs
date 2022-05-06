using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network_tao
{
    class TrainingSet
    {
       // เนื่องจาก input มีจำนวนหลายค่ามากๆจึงต้องใช้งานโครงสร้าง list
        [JsonProperty("inputs")]
        public List<int> Inputs { get; set; }

       // out-put มีแค่ทางเดียวเลยเขียนแบบปกติเลย
        [JsonProperty("output")]
        public int Output { get; set; }
    }
}
