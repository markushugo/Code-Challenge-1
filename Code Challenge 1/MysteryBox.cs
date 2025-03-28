using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_1
{
    class MysteryBox
    {
        private string _label;
        private string _contains;
        private bool _isExplosive;

        public string Label
        {
            get { return _label; }
            private set { _label = value; } 
        }

        public string Contains
        {
            get { return _contains; }
            private set { _contains = value; }
        }

        public bool IsExplosive
        {
            get { return _isExplosive; }
            private set { _isExplosive = value; }
        }

        public MysteryBox(string label, string contains, bool isExplosive)
        {
            Label = label;
            Contains = contains;
            IsExplosive = isExplosive;
        }

        public override string ToString()
        {
            return $"{Label}: Indeholder {Contains}, eksplosivitet: {IsExplosive}";
        }
    }
}
