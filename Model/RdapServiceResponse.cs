namespace CodingPracticalTest.Model
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class RdapServiceResponse
    {
        [JsonProperty("rdapConformance")]
        public List<string> RdapConformance { get; set; }

        [JsonProperty("notices")]
        public List<Notice> Notices { get; set; }

        [JsonProperty("handle")]
        public string Handle { get; set; }

        [JsonProperty("startAddress")]
        public string StartAddress { get; set; }

        [JsonProperty("endAddress")]
        public string EndAddress { get; set; }

        [JsonProperty("ipVersion")]
        public string IpVersion { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("parentHandle")]
        public string ParentHandle { get; set; }

        [JsonProperty("events")]
        public List<Event> Events { get; set; }

        [JsonProperty("links")]
        public List<Link> Links { get; set; }

        [JsonProperty("entities")]
        public List<RdapServiceResponseEntity> Entities { get; set; }

        [JsonProperty("port43")]
        public string Port43 { get; set; }

        [JsonProperty("status")]
        public List<string> Status { get; set; }

        [JsonProperty("objectClassName")]
        public string ObjectClassName { get; set; }

        [JsonProperty("cidr0_cidrs")]
        public List<Cidr0Cidr> Cidr0Cidrs { get; set; }

        [JsonProperty("arin_originas0_originautnums")]
        public List<object> ArinOriginas0Originautnums { get; set; }
    }

    public partial class Cidr0Cidr
    {
        [JsonProperty("v4prefix")]
        public string V4Prefix { get; set; }

        [JsonProperty("length")]
        public long Length { get; set; }
    }

    public partial class RdapServiceResponseEntity
    {
        [JsonProperty("handle")]
        public string Handle { get; set; }

        [JsonProperty("vcardArray")]
        public List<IndecentVcardArray> VcardArray { get; set; }

        [JsonProperty("roles")]
        public List<string> Roles { get; set; }

        [JsonProperty("remarks")]
        public List<Remark> Remarks { get; set; }

        [JsonProperty("links")]
        public List<Link> Links { get; set; }

        [JsonProperty("events")]
        public List<Event> Events { get; set; }

        [JsonProperty("entities")]
        public List<EntityEntity> Entities { get; set; }

        [JsonProperty("port43")]
        public string Port43 { get; set; }

        [JsonProperty("objectClassName")]
        public string ObjectClassName { get; set; }
    }

    public partial class EntityEntity
    {
        [JsonProperty("handle")]
        public string Handle { get; set; }

        [JsonProperty("vcardArray")]
        public List<StickyVcardArray> VcardArray { get; set; }

        [JsonProperty("roles")]
        public List<string> Roles { get; set; }

        [JsonProperty("remarks", NullValueHandling = NullValueHandling.Ignore)]
        public List<Remark> Remarks { get; set; }

        [JsonProperty("links")]
        public List<Link> Links { get; set; }

        [JsonProperty("events")]
        public List<Event> Events { get; set; }

        [JsonProperty("port43")]
        public string Port43 { get; set; }

        [JsonProperty("objectClassName")]
        public string ObjectClassName { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Status { get; set; }
    }

    public partial class Event
    {
        [JsonProperty("eventAction")]
        public string EventAction { get; set; }

        [JsonProperty("eventDate")]
        public DateTimeOffset EventDate { get; set; }
    }

    public partial class Link
    {
        [JsonProperty("value")]
        public Uri Value { get; set; }

        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("href")]
        public Uri Href { get; set; }
    }

    public partial class Remark
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public List<string> Description { get; set; }
    }

    public partial class PurpleVcardArray
    {
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Type { get; set; }
    }

    public partial class FluffyVcardArray
    {
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }
    }

    public partial class Notice
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public List<string> Description { get; set; }

        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Link> Links { get; set; }
    }

    public enum TypeEnum { ApplicationRdapJson, ApplicationXml, TextHtml };

    public partial struct TentacledVcardArray
    {
        public PurpleVcardArray PurpleVcardArray;
        public string String;
        public List<string> StringArray;

        public static implicit operator TentacledVcardArray(PurpleVcardArray PurpleVcardArray) => new TentacledVcardArray { PurpleVcardArray = PurpleVcardArray };
        public static implicit operator TentacledVcardArray(string String) => new TentacledVcardArray { String = String };
        public static implicit operator TentacledVcardArray(List<string> StringArray) => new TentacledVcardArray { StringArray = StringArray };
    }

    public partial struct StickyVcardArray
    {
        public List<List<TentacledVcardArray>> AnythingArrayArray;
        public string String;

        public static implicit operator StickyVcardArray(List<List<TentacledVcardArray>> AnythingArrayArray) => new StickyVcardArray { AnythingArrayArray = AnythingArrayArray };
        public static implicit operator StickyVcardArray(string String) => new StickyVcardArray { String = String };
    }

    public partial struct IndigoVcardArray
    {
        public FluffyVcardArray FluffyVcardArray;
        public string String;
        public List<string> StringArray;

        public static implicit operator IndigoVcardArray(FluffyVcardArray FluffyVcardArray) => new IndigoVcardArray { FluffyVcardArray = FluffyVcardArray };
        public static implicit operator IndigoVcardArray(string String) => new IndigoVcardArray { String = String };
        public static implicit operator IndigoVcardArray(List<string> StringArray) => new IndigoVcardArray { StringArray = StringArray };
    }

    public partial struct IndecentVcardArray
    {
        public List<List<IndigoVcardArray>> AnythingArrayArray;
        public string String;

        public static implicit operator IndecentVcardArray(List<List<IndigoVcardArray>> AnythingArrayArray) => new IndecentVcardArray { AnythingArrayArray = AnythingArrayArray };
        public static implicit operator IndecentVcardArray(string String) => new IndecentVcardArray { String = String };
    }

    public partial class RdapServiceResponse
    {
        public static RdapServiceResponse FromJson(string json) => JsonConvert.DeserializeObject<RdapServiceResponse>(json, CodingPracticalTest.Model.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this RdapServiceResponse self) => JsonConvert.SerializeObject(self, CodingPracticalTest.Model.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                TypeEnumConverter.Singleton,
                StickyVcardArrayConverter.Singleton,
                TentacledVcardArrayConverter.Singleton,
                IndecentVcardArrayConverter.Singleton,
                IndigoVcardArrayConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "application/rdap+json":
                    return TypeEnum.ApplicationRdapJson;
                case "application/xml":
                    return TypeEnum.ApplicationXml;
                case "text/html":
                    return TypeEnum.TextHtml;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            switch (value)
            {
                case TypeEnum.ApplicationRdapJson:
                    serializer.Serialize(writer, "application/rdap+json");
                    return;
                case TypeEnum.ApplicationXml:
                    serializer.Serialize(writer, "application/xml");
                    return;
                case TypeEnum.TextHtml:
                    serializer.Serialize(writer, "text/html");
                    return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }

    internal class StickyVcardArrayConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StickyVcardArray) || t == typeof(StickyVcardArray?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new StickyVcardArray { String = stringValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<List<TentacledVcardArray>>>(reader);
                    return new StickyVcardArray { AnythingArrayArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type StickyVcardArray");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (StickyVcardArray)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArrayArray != null)
            {
                serializer.Serialize(writer, value.AnythingArrayArray);
                return;
            }
            throw new Exception("Cannot marshal type StickyVcardArray");
        }

        public static readonly StickyVcardArrayConverter Singleton = new StickyVcardArrayConverter();
    }

    internal class TentacledVcardArrayConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TentacledVcardArray) || t == typeof(TentacledVcardArray?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new TentacledVcardArray { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<PurpleVcardArray>(reader);
                    return new TentacledVcardArray { PurpleVcardArray = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<string>>(reader);
                    return new TentacledVcardArray { StringArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type TentacledVcardArray");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TentacledVcardArray)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.StringArray != null)
            {
                serializer.Serialize(writer, value.StringArray);
                return;
            }
            if (value.PurpleVcardArray != null)
            {
                serializer.Serialize(writer, value.PurpleVcardArray);
                return;
            }
            throw new Exception("Cannot marshal type TentacledVcardArray");
        }

        public static readonly TentacledVcardArrayConverter Singleton = new TentacledVcardArrayConverter();
    }

    internal class IndecentVcardArrayConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(IndecentVcardArray) || t == typeof(IndecentVcardArray?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new IndecentVcardArray { String = stringValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<List<IndigoVcardArray>>>(reader);
                    return new IndecentVcardArray { AnythingArrayArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type IndecentVcardArray");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (IndecentVcardArray)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArrayArray != null)
            {
                serializer.Serialize(writer, value.AnythingArrayArray);
                return;
            }
            throw new Exception("Cannot marshal type IndecentVcardArray");
        }

        public static readonly IndecentVcardArrayConverter Singleton = new IndecentVcardArrayConverter();
    }

    internal class IndigoVcardArrayConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(IndigoVcardArray) || t == typeof(IndigoVcardArray?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new IndigoVcardArray { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<FluffyVcardArray>(reader);
                    return new IndigoVcardArray { FluffyVcardArray = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<string>>(reader);
                    return new IndigoVcardArray { StringArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type IndigoVcardArray");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (IndigoVcardArray)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.StringArray != null)
            {
                serializer.Serialize(writer, value.StringArray);
                return;
            }
            if (value.FluffyVcardArray != null)
            {
                serializer.Serialize(writer, value.FluffyVcardArray);
                return;
            }
            throw new Exception("Cannot marshal type IndigoVcardArray");
        }

        public static readonly IndigoVcardArrayConverter Singleton = new IndigoVcardArrayConverter();
    }
}
