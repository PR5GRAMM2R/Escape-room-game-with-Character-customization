using System;
using System.Collections.Generic;                       // 배주환, 고현호
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace EscapeGame
{
    public class GlobalSettings
    {
        private static GlobalSettings _instance;

        public int characterNum { get; set; }

        public int frameCount { get; set; }
        public List<Color[,]> frames { get; set; }

        public SoundPlayer backgroundMusicPlayer {  get; set; }

        public static GlobalSettings Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GlobalSettings();
                    _instance.characterNum = 0;
                    _instance.frameCount = 0;
                    _instance.frames = new List<Color[,]>();
                    _instance.backgroundMusicPlayer = null;
                }
                return _instance;
            }
        }

        private GlobalSettings() { }
    }
}
