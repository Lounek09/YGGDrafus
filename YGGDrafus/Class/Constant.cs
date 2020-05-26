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
        public string MAIN_ICO_FILE { get => "YGGDrafus.ico"; }
        public string OPTION_ICO_FILE { get => "YGGDrafus-option.ico"; }

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
