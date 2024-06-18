using System;
using System.Collections.Generic;                       // 배주환, 고현호
using System.Drawing;
using System.Linq;
using System.Media;                                     // 싱글톤 패턴
using System.Text;                                      // 게임 실행 중에는 동일한 캐릭터가 적용되도록 조치
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
