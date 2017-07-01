/**
 * This file\code is part of InTouch project.
 *
 * InTouch - is a .NET wrapper for the vk.com API.
 * https://github.com/virtyaluk/InTouch
 *
 * Copyright (c) 2016 Bohdan Shtepan
 * http://modern-dev.com/
 *
 * Licensed under the GPLv3 license.
 */

using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ModernDev.InTouch
{
    /// <summary>
    /// Audio album.
    /// </summary>
    [DataContract]
    public class AudioAlbum : BaseAlbum
    {
        /// <summary>
        /// Album thumb.
        /// </summary>
        [DataMember]
        [JsonProperty("thumb")]
        public Thumb Thumb { get; set; }
    }
}