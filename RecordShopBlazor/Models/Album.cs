﻿namespace RecordShopBlazor.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int ArtistId { get; set; }
        public Artist? Artist { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public int YearReleased { get; set; }
    }
}
