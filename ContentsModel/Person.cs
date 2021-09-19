using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentsModel {
    public class Person {
        public int Age { get; set; }
        public string Name { get; set; }
        public bool IsOver40 { get { return this.Age >= 40; }  }
    }
}
