﻿namespace SongSpectre {
    internal static class Utils {
        public static R Sync<R>(Task<R> t) {
            return t.GetAwaiter().GetResult();
        }
        public static void Sync(Task t) {
            t.GetAwaiter().GetResult();
        }
    }
}
