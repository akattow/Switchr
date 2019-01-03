using Switchr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Switchr.ViewModels
{
    public class GameFormViewModel
    {
        public Game Game { get; set; }
        public IEnumerable<GameType> GameTypes { get; set; }

        public string Title
        {
            get
            {
                if (Game != null && Game.Id != 0)
                    return "Edit Game";

                return "New Game";
            }
        }
    }
}