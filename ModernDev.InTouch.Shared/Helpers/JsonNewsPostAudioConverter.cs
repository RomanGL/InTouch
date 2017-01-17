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

using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Diagnostics;

namespace ModernDev.InTouch
{
    internal class JsonNewsPostAudioConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteNull();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jObj = serializer.Deserialize<JObject>(reader);
            var itemsObj = jObj["items"];

            if (itemsObj != null)
            {
                var arr = (JArray)itemsObj;
                for (int i = 0; i < arr.Count; i++)
                {
                    if (arr[i].Type == JTokenType.Boolean)
                    {
                        arr[i].Remove();
                        i--;
                    }
                }

                return jObj.ToObject<ItemsList<Audio>>();
            }
            else
            {
                var audios = new ItemsList<Audio>();

                audios.Items.Add(jObj.ToObject<Audio>());

                return audios;
            }
        }

        public override bool CanConvert(Type objectType) => true;
    }
}