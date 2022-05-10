﻿using System;

namespace ItchioLibrary.Models
{
    public class GameRecord
    {
        /// <summary>
        /// Site-wide unique identifier generated by itch.io
        /// </summary>
        public int id;

        /// <summary>
        /// Human-friendly title (may contain any character)
        /// </summary>
        public string title;

        /// <summary>
        /// Url of the game cover
        /// </summary>
        public string cover;
    }
}