using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSDL_IDM_P2.Lib.Entity.Common
{
    public class LabelName
    {
        private string valueEn;
        private string valueBn;
        private string codeAsString;
        private int codeAsInt;
        public int CodeAsInt
        {
            get
            {
                return codeAsInt;
            }
            set
            {
                codeAsInt = value;
            }
        }
        public string ValueEn
        {
            get
            {
                return valueEn;
            }

            set
            {
                valueEn = value;
            }
        }

        public string ValueBn
        {
            get
            {
                return valueBn;
            }

            set
            {
                valueBn = value;
            }
        }

        public string CodeAsString
        {
            get
            {
                return codeAsString;
            }

            set
            {
                codeAsString = value;
            }
        }
        public LabelName(string valueEn, string valueBn, int code)
        {
            this.valueEn = valueEn;
            this.valueBn = valueBn;
            this.codeAsInt = code;
        }
        public LabelName(string valueEn, string valueBn, string code)
        {
            this.valueEn = valueEn;
            this.valueBn = valueBn;
            this.codeAsString = code;
        }
    }
}
