﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindWayGame.Entities
{
    public class GameInfo
    {
        [Key]
        public int GameId { get; set; }

        public double Duration { get; set; }

        public bool IsWon { get; set; }

        public virtual Player Player { get; set; }

        [NotMapped]
        public int GuessedCells { get; set; }
    }
}
