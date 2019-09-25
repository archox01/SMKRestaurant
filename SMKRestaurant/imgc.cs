using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Drawing;
using System.IO;

namespace SMKRestaurant
{
    class imgc
    {
        public Byte img2array;
        public byte[] imgtoarray ( System.Drawing.Image imagein)
        {
            MemoryStream ms = new MemoryStream();
            imagein.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        public Image array2img;
        public Image arraytoimg (byte[] bytearrayin)
        {
            MemoryStream ms = new MemoryStream();
            Image img = Image.FromStream(ms);
            return img;
        }
    }
}
