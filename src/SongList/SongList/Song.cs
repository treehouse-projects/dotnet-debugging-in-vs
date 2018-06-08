namespace SongList
{
    /// <summary>
    /// Represents a song with a name and artist
    /// </summary>
    class Song
    {
        /// <summary>
        /// Gets or sets the name of the song.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the artist associated with the song.
        /// </summary>
        public string Artist { get; set; }

        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return Name + " by " + Artist;
        }
    }
}
