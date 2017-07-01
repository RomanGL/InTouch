using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ModernDev.InTouch
{
    [DataContract]
    [JsonConverter(typeof(JsonAudioCatalogItemSourceConverter))]
    public enum AudioCatalogItemSource
    {
        Unknown = 0,
        RecomsRecoms,
        RecomsFriends,
        RecomsNewAudios,
        RecomsNewAlbums,
        RecomsCommunities,
        RecomsAddedRecommendation,
        RecomsPlaylists,
        RecomsTopAudiosGlobal,
        RecomsNewArtists,
        RecomsRecentAudios
    }
}
