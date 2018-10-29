using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTogetherExercise
{
    class Player
    {
        public Player(string name) : this(name, 100) { }
        public Player(string name, int begBalance)
        {
            Balance = begBalance;
            Name = name;
        }
        
        public int Balance { get; set; }
        public string Name { get; set; }        
    }
}
