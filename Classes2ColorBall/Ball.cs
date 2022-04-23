using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2ColorBall
{
    public class Ball
    {
        public uint Size { get; set; }
        public Color? Color { get; set; }
        public uint ThrowCount { get; set; }

        public Ball(uint size, Color c, uint thrown) { this.Size = size; this.Color = c; this.ThrowCount = thrown; }

        public void Pop()
        {
            Size = 0;
        }
        public void ThrowIt()
        {
            if(Size > 0)
            {
                ThrowCount++;
            } else
            {
                Console.WriteLine("You can't throw it! it's been popped!!");
            }
            
        }
        public uint GetThrowCount()
        {
            return ThrowCount;
        }
    }
}
