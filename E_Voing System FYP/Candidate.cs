using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Voing_System_FYP
{
    public class Candidate
    {
        private String cnic;
        private byte[] ImageData;
        public Candidate(String cnic, byte[] image)
        {
            this.ImageData = image;
            this.cnic = cnic;
        }

        public byte[] getImageData() { return ImageData; }
        public String getCNIC() { return cnic; }
    }
}
