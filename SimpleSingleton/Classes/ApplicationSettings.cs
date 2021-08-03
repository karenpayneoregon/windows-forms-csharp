using System;

namespace SimpleSingleton.Classes
{
    public sealed class ApplicationSettings
    {
        private static readonly Lazy<ApplicationSettings> Lazy = new(() => 
            new ApplicationSettings());
        
        public static ApplicationSettings Instance => Lazy.Value;
        
        public UserInfo Info;
        
        /// <summary>
        /// See if <see cref="Info"/> is set
        /// </summary>
        public bool HasInfo => Info != null;
    }
}