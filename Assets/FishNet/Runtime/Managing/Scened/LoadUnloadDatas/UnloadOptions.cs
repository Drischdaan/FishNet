﻿
namespace FishNet.Managing.Scened.Data
{
    /// <summary>
    /// Settings to apply when loading a scene.
    /// </summary>
    public class UnloadOptions
    {
        /// <summary>
        /// Conditions to unloading a scene on the server.
        /// </summary>
        public enum ServerUnloadModes
        {
            /// <summary>
            /// Unloads the scene if no more connections are within it.
            /// </summary>
            UnloadUnused = 0,
            /// <summary>
            /// Unloads scenes for connections but keeps scene loaded on server even if no connections are within it.
            /// </summary>
            KeepUnused = 1,
            /// <summary>
            /// Unloads scene for connections and on server ignoring conditions.
            /// </summary>
            ForceUnload = 2
        }

        /// <summary>
        /// How to unload scenes on the server. UnloadUnused will unload scenes which have no more clients in them. KeepUnused will not unload a scene even when empty. ForceUnload will unload a scene regardless of if clients are still connected to it.
        /// </summary>
        [System.NonSerialized]
        public ServerUnloadModes Mode = ServerUnloadModes.UnloadUnused;
        /// <summary>
        /// Parameters which can be passed into a scene load. Params can be useful to link personalized data with scene load callbacks, such as a match Id.
        /// </summary>
        [System.NonSerialized]
        public object[] Params = null;
    }


}