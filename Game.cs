using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_Price_Austin
{
    internal class Game
    {
        // Public fields
        public string title;
        public string genre;

        // Constructor with default values
        public Game(string title = "Unknown Title", string genre = "Casual")
        {
            this.title = title;
            this.genre = genre;
        }
    }
}
