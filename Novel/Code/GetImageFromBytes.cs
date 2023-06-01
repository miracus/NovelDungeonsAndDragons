using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novel
{
    internal class GetImageFromBytes
    {
        public static Image action(byte[] picture)
        {
            using (MemoryStream ms = new MemoryStream(picture))
            {
                return Image.FromStream(ms);
            }
        }
    }

}
