using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace ModernDev.InTouch
{
    /// <summary>
    /// An <see cref="AudioCatalogItem"/> class describes an audio catalog item.
    /// </summary>
    [DataContract]
    [DebuggerDisplay("{Title} - {Subtitle}")]
    public class AudioCatalogItem
    {
        /// <summary>
        /// Item ID.
        /// </summary>
        [DataMember]
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Item title.
        /// </summary>
        [DataMember]
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Item subtitle.
        /// </summary>
        [DataMember]
        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        /// <summary>
        /// Item type.
        /// </summary>
        [DataMember]
        [JsonProperty("type")]
        public AudioCatalogItemType Type { get; set; }

        /// <summary>
        /// Items count.
        /// </summary>
        [DataMember]
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Item source.
        /// </summary>
        [DataMember]
        [JsonProperty("source")]
        public AudioCatalogItemSource Source { get; set; }

        /// <summary>
        /// Item thumbs.
        /// </summary>
        [DataMember]
        [JsonProperty("thumbs")]
        public List<Thumb> Thumbs { get; set; }

        /// <summary>
        /// Item audios.
        /// </summary>
        [DataMember]
        [JsonProperty("audios")]
        public List<Audio> Audios { get; set; }

        /// <summary>
        /// Item playlists.
        /// </summary>
        [DataMember]
        [JsonProperty("playlists")]
        public List<Playlist> Playlists { get; set; }
    }
}
