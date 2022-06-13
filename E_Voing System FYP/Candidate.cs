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
        private byte[] imageData;
        private String position;
        public Candidate(String cnic, byte[] image, String pos = "")
        {
            this.imageData = image;
            this.cnic = cnic;
            this.position = pos;
        }

        public byte[] getImageData() { return imageData; }
        public String getCNIC() { return cnic; }
        public void setPostion(String posi)
        {
            position = posi;
        }
        public String getPosition() { return position; }
    }
}
