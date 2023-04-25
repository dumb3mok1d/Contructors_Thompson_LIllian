using System;
using System.Collections.Generic;
using System.Text;

namespace Contructors_Thompson_LIllian
{
    class Game
    {

        public string title, genre;

        public Game (string titleParam = "Unknown Title", string genreParam = "Casual")
        {
            title = titleParam;
            genre = genreParam;
        }

    }
}
