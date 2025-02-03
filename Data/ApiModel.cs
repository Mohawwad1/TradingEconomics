using System.Text.Json.Serialization;

namespace tradingeconomics.Data
{
   
        public class ApiModel
        {
            [JsonPropertyName("info")]
            public Info Info { get; set; }

            [JsonPropertyName("hits")]
            public List<Hit> Hits { get; set; }

            [JsonPropertyName("stance")]
            public string Stance { get; set; }
        }

        public class Info
        {
            [JsonPropertyName("hits")]
            public HitsInfo Hits { get; set; }

            [JsonPropertyName("page")]
            public int Page { get; set; }

            [JsonPropertyName("facets")]
            public Facets Facets { get; set; }
        }

        public class HitsInfo
        {
            [JsonPropertyName("value")]
            public int Value { get; set; }

            [JsonPropertyName("relation")]
            public string Relation { get; set; }
        }

        public class Facets
        {
            [JsonPropertyName("country")]
            public List<object> Country { get; set; } // Adjust type if needed

            [JsonPropertyName("unit")]
            public List<FacetItem> Unit { get; set; }

            [JsonPropertyName("currency")]
            public List<FacetItem> Currency { get; set; }

            [JsonPropertyName("category")]
            public List<object> Category { get; set; } // Adjust type if needed

            [JsonPropertyName("type")]
            public List<FacetItem> Type { get; set; }

            [JsonPropertyName("group")]
            public List<FacetItem> Group { get; set; }

            [JsonPropertyName("frequency")]
            public List<FacetItem> Frequency { get; set; }
        }

        public class FacetItem
        {
            [JsonPropertyName("key")]
            public string Key { get; set; }

            [JsonPropertyName("doc_count")]
            public int DocCount { get; set; }
        }

        public class Hit
        {
            [JsonPropertyName("country")]
            public string Country { get; set; }

            [JsonPropertyName("category")]
            public string Category { get; set; }

            [JsonPropertyName("currency")]
            public string Currency { get; set; }

            [JsonPropertyName("iids")]
            public string Iids { get; set; }

            [JsonPropertyName("esID")]
            public string EsID { get; set; }

            [JsonPropertyName("s")]
            public string S { get; set; }

            [JsonPropertyName("importance")]
            public int Importance { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("type")]
            public string Type { get; set; }

            [JsonPropertyName("group")]
            public string Group { get; set; }

            [JsonPropertyName("frequency")]
            public string Frequency { get; set; }

            [JsonPropertyName("unit")]
            public string Unit { get; set; }

            [JsonPropertyName("pretty_name")]
            public string PrettyName { get; set; }

            [JsonPropertyName("url")]
            public string Url { get; set; }
        }
    }

