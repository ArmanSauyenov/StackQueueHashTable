using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class Staff
    {
        Random rand = new Random();
        public Staff(string _fullName, bool _gender, int _age, int _salarySize)
        {
            fullName = _fullName;
            //fullName = "XJ"+rand.Next().ToString();
            //pol = age < 63 ? pol = false : pol = true;
            gender = _gender;
            age = _age;
            salarySize = _salarySize;
        }
        public string fullName { get; set; }
        public bool gender { get; set; }
        public int age { get; set; }
        public int salarySize { get; set; }
    }
}
