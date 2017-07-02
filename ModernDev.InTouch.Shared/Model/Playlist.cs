using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ModernDev.InTouch.Helpers;
using Newtonsoft.Json;

namespace ModernDev.InTouch
{
    /// <summary>
    /// An audio playlist.
    /// </summary>
    [DataContract]
    public class Playlist : IMediaAttachment
    {
        /// <summary>
        /// Playlist id.
        /// </summary>
        [DataMember]
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Playlist owner id.
        /// </summary>
        [DataMember]
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// Playlist type (album or new playlist).
        /// </summary>
        [DataMember]
        [JsonProperty("type")]
        public PlaylistType Type { get; set; }

        /// <summary>
        /// Playlist title.
        /// </summary>
        [DataMember]
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Playlist description.
        /// </summary>
        [DataMember]
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Number of tracks in playlist.
        /// </summary>
        [DataMember]
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// True, if user subscribe to playlist.
        /// </summary>
        [DataMember]
        [JsonProperty("is_following")]
        public bool IsFollowing { get; set; }

        /// <summary>
        /// Number of followers.
        /// </summary>
        [DataMember]
        [JsonProperty("followers")]
        public int Followers { get; set; }

        /// <summary>
        /// Number of plays.
        /// </summary>
        [DataMember]
        [JsonProperty("plays")]
        public int Plays { get; set; }

        /// <summary>
        /// Access key to this album.
        /// </summary>
        [DataMember]
        [JsonProperty("access_key")]
        public string AccessKey { get; set; }

        /// <summary>
        /// Time when playlist was create.
        /// </summary>
        [DataMember]
        [JsonProperty("create_time")]
        [JsonConverter(typeof(JsonNumberDateTimeConverter))]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// Time when playlist was update.
        /// </summary>
        [DataMember]
        [JsonProperty("update_time")]
        [JsonConverter(typeof(JsonNumberDateTimeConverter))]
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// Main artist of playlist.
        /// </summary>
        [DataMember]
        [JsonProperty("main_artist")]
        public string MainArtist { get; set; }

        /// <summary>
        /// Playlist thumb.
        /// </summary>
        [DataMember]
        [JsonProperty("photo")]
        public Thumb Photo { get; set; }
        
        /// <summary>
        /// Album thumbs.
        /// </summary>
        [DataMember]
        [JsonProperty("thumbs")]
        public List<Thumb> Thumbs { get; set; }
    }
}
