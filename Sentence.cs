using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevationMaster
{
    public class Sentence
    {
        public Sentence(string s)
        {
            Value = s;
        }
        public string Value { get; set; }
        public char GetFirstCharacter()
        {
            try
            {
                return Value[0];
            }
            catch (NullReferenceException e)
            {
                throw;
            }
        }
    }
}
