using Newtonsoft.Json;

namespace ModernDev.InTouch
{
    /// <summary>
    /// Type of audio catalog item.
    /// </summary>
    [JsonConverter(typeof(JsonAudioCatalogItemTypeConverter))]
    public enum AudioCatalogItemType
    {
        Unknown = 0,
        AudiosSpecial,
        Owners,
        Audios,
        Playlists,
        ExtendedPlaylists
    }
}
