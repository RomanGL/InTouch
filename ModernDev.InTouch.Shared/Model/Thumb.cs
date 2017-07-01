using System.Diagnostics;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ModernDev.InTouch
{
    /// <summary>
    /// Image thumb.
    /// </summary>
    [DataContract]
    [DebuggerDisplay("Photo {Width}x{Height}")]
    public class Thumb
    {
        /// <summary>
        /// Photo 34x34.
        /// </summary>
        [DataMember]
        [JsonProperty("photo_34")]
        public string Photo34 { get; set; }

        /// <summary>
        /// Photo 68x68.
        /// </summary>
        [DataMember]
        [JsonProperty("photo_68")]
        public string Photo68 { get; set; }

        /// <summary>
        /// Photo 135x135.
        /// </summary>
        [DataMember]
        [JsonProperty("photo_135")]
        public string Photo135 { get; set; }

        /// <summary>
        /// Photo 270x270.
        /// </summary>
        [DataMember]
        [JsonProperty("photo_270")]
        public string Photo270 { get; set; }

        /// <summary>
        /// Photo 300x300.
        /// </summary>
        [DataMember]
        [JsonProperty("photo_300")]
        public string Photo300 { get; set; }

        /// <summary>
        /// Photo 600x600.
        /// </summary>
        [DataMember]
        [JsonProperty("photo_600")]
        public string Photo600 { get; set; }

        /// <summary>
        /// Photo width.
        /// </summary>
        [DataMember]
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// Photo height.
        /// </summary>
        [DataMember]
        [JsonProperty("height")]
        public int Height { get; set; }
    }
}
