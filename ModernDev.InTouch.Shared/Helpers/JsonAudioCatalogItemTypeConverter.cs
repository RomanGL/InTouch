using System;
using Newtonsoft.Json;

namespace ModernDev.InTouch
{
    internal class JsonAudioCatalogItemTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == typeof(AudioCatalogItemType);

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var type = (AudioCatalogItemType)value;
            switch (type)
            {
                case AudioCatalogItemType.AudiosSpecial:
                    writer.WriteValue(AUDIOS_SPECIAL);
                    break;
                case AudioCatalogItemType.Owners:
                    writer.WriteValue(OWNERS);
                    break;
                case AudioCatalogItemType.Audios:
                    writer.WriteValue(AUDIOS);
                    break;
                case AudioCatalogItemType.Playlists:
                    writer.WriteValue(PLAYLISTS);
                    break;
                case AudioCatalogItemType.ExtendedPlaylists:
                    writer.WriteValue(EXTENDED_PLAYLISTS);
                    break;
                default:
                    writer.WriteValue(UNKNOWN);
                    break;
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            string value = reader.Value.ToString();
            switch (value)
            {
                case AUDIOS_SPECIAL:
                    return AudioCatalogItemType.AudiosSpecial;
                case AUDIOS:
                    return AudioCatalogItemType.Audios;
                case OWNERS:
                    return AudioCatalogItemType.Owners;
                case PLAYLISTS:
                    return AudioCatalogItemType.Playlists;
                case EXTENDED_PLAYLISTS:
                    return AudioCatalogItemType.ExtendedPlaylists;
                default:
                    return AudioCatalogItemType.Unknown;
            }
        }

        private const string AUDIOS_SPECIAL = "audios_special";
        private const string OWNERS = "owners";
        private const string AUDIOS = "audios";
        private const string PLAYLISTS = "playlists";
        private const string EXTENDED_PLAYLISTS = "extended_playlists";
        private const string UNKNOWN = "unknown";
    }
}
