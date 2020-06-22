using System;

namespace YGGDrafus
{
    public sealed class Constant
    {
        private static volatile Constant instance;
        private static readonly object syncRoot = new Object();

        public string IMG_PATH { get => @"img\"; }
        public string SCREENSHOT_PATH { get => @"screenshot\"; }
        public string SWF_PATH { get => @"swf\"; }
        public string LOG_PATH { get => @"log\"; }
        public string MAIN_ICO_FILE { get => "YGGDrafus.ico"; }
        public string OPTION_ICO_FILE { get => "YGGDrafus-option.ico"; }
        public string PRELOADER_IN_GAME_PATH { get => @"\resources\app\retroclient\preloader.swf"; }
        public string CONFIG_IN_GAME_PATH { get => @"\resources\app\retroclient\config.xml"; }
        public string ITEMS_IN_GAME_PATH { get => @"\resources\app\retroclient\clips\items\"; }
        public int MAX_GAME_INSTANCE { get => 8; }

        private Constant() { }

        public static Constant Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new Constant();
                    }
                }
                return instance;
            }
        }
    }
}
