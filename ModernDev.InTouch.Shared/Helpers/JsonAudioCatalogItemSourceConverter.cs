using System;
using Newtonsoft.Json;

namespace ModernDev.InTouch
{
    internal class JsonAudioCatalogItemSourceConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == typeof(AudioCatalogItemSource);

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var type = (AudioCatalogItemSource)value;
            switch (type)
            {
                case AudioCatalogItemSource.RecomsRecoms:
                    writer.WriteValue(RECOMS_RECOMS);
                    break;
                case AudioCatalogItemSource.RecomsFriends:
                    writer.WriteValue(RECOMS_FRIENDS);
                    break;
                case AudioCatalogItemSource.RecomsNewAudios:
                    writer.WriteValue(RECOMS_NEW_AUDIOS);
                    break;
                case AudioCatalogItemSource.RecomsNewAlbums:
                    writer.WriteValue(RECOMS_NEW_ALBUMS);
                    break;
                case AudioCatalogItemSource.RecomsNewArtists:
                    writer.WriteValue(RECOMS_NEW_ARTISTS);
                    break;
                case AudioCatalogItemSource.RecomsCommunities:
                    writer.WriteValue(RECOMS_COMMUNITIES);
                    break;
                case AudioCatalogItemSource.RecomsAddedRecommendation:
                    writer.WriteValue(RECOMS_ADDED_RECOMMENDATIONS);
                    break;
                case AudioCatalogItemSource.RecomsPlaylists:
                    writer.WriteValue(RECOMS_PLAYLISTS);
                    break;
                case AudioCatalogItemSource.RecomsTopAudiosGlobal:
                    writer.WriteValue(RECOMS_TOP_AUDIOS_GLOBAL);
                    break;
                case AudioCatalogItemSource.RecomsRecentAudios:
                    writer.WriteValue(RECOMS_RECENT_AUDIOS);
                    break;
                default:
                    writer.WriteValue(RECOMS_UNKNOWN);
                    break;
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            string value = reader.Value.ToString();
            switch (value)
            {
                case RECOMS_RECOMS:
                    return AudioCatalogItemSource.RecomsRecoms;
                case RECOMS_FRIENDS:
                    return AudioCatalogItemSource.RecomsFriends;
                case RECOMS_NEW_AUDIOS:
                    return AudioCatalogItemSource.RecomsNewAudios;
                case RECOMS_NEW_ALBUMS:
                    return AudioCatalogItemSource.RecomsNewAlbums;
                case RECOMS_NEW_ARTISTS:
                    return AudioCatalogItemSource.RecomsNewArtists;
                case RECOMS_COMMUNITIES:
                    return AudioCatalogItemSource.RecomsCommunities;
                case RECOMS_ADDED_RECOMMENDATIONS:
                    return AudioCatalogItemSource.RecomsAddedRecommendation;
                case RECOMS_PLAYLISTS:
                    return AudioCatalogItemSource.RecomsPlaylists;
                case RECOMS_TOP_AUDIOS_GLOBAL:
                    return AudioCatalogItemSource.RecomsTopAudiosGlobal;
                case RECOMS_RECENT_AUDIOS:
                    return AudioCatalogItemSource.RecomsRecentAudios;
                default:
                    return AudioCatalogItemSource.Unknown;
            }
        }

        private const string RECOMS_RECOMS = "recoms_recoms";
        private const string RECOMS_FRIENDS = "recoms_friends";
        private const string RECOMS_NEW_AUDIOS = "recoms_new_audios";
        private const string RECOMS_NEW_ALBUMS = "recoms_new_albums";
        private const string RECOMS_NEW_ARTISTS = "recoms_new_artists";
        private const string RECOMS_COMMUNITIES = "recoms_communities";
        private const string RECOMS_ADDED_RECOMMENDATIONS = "recoms_added_recommendation";
        private const string RECOMS_PLAYLISTS = "recoms_playlists";
        private const string RECOMS_TOP_AUDIOS_GLOBAL = "recoms_top_audios_global";
        private const string RECOMS_RECENT_AUDIOS = "recoms_recent_audios";
        private const string RECOMS_UNKNOWN = "unknown";
    }
}
