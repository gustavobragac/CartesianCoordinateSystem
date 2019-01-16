using System;
using System.Linq;

namespace CartesianCoordinateSystem.Domain
{
    public class CartesianPlane
    {
        public CartesianPlane(int startX, int startY)
        {
            AxisY = startY;
            AxisX = startX;
        }

        public long AxisX { get; set; }
        public long AxisY { get; set; }

        public void Move(char direction, int intensity)
        {
            if (new[] { 'O', 'S' }.Contains(direction))
                intensity = intensity * -1;

            if (new[] { 'N', 'S' }.Contains(direction))
                AxisY += intensity;

            if (new[] { 'O', 'L' }.Contains(direction))
                AxisX += intensity;
        }

        public override string ToString()
        {
            return $"eixo x: {AxisX} \n eixo y: {AxisY}";
        }
        
    }
}
