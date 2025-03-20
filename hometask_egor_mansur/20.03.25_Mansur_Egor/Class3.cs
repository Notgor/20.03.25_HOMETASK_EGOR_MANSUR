using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMETASK_MANSUR_EGOR
{
    public enum Color
    {
        Red,
        Blue,
        Green,
        Black,
        White
    }
    class CarWithEnum
    {
        public string Model { get; set; }
        public Color CarColor { get; set; }

        public CarWithEnum(string model, Color carColor)
        {
            Model = model;
            CarColor = carColor;
        }
    }
}
