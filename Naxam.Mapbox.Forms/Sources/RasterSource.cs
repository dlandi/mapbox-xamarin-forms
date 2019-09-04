﻿namespace Naxam.Mapbox.Sources
{
    public class RasterSource : Source
    {
        public const int DEFAULT_TILE_SIZE = 512;

        public RasterSource(string id, string configurationURL, double tileSize = DEFAULT_TILE_SIZE)
        {
            Id = id;
            ConfigurationURL = configurationURL;
            TileSize = tileSize;
        }

        public string ConfigurationURL { get; private set; }

        public double TileSize { get; private set; }
    }
}
