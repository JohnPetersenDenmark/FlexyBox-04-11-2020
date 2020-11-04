using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ApplicationLayer.Common
{
    public class NYTimesResult
    {
       
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("response")]
        public NYTimesResponse Response { get; set; }
    }

    public class NYTimesResponse 
    {
       

        [JsonProperty("docs")]
        public NYTimesDoc[] Docs { get; set; }

        [JsonProperty("meta")]
        public NYTimesMeta Meta { get; set; }
    }

    public class NYTimesDoc
    {
       

        [JsonProperty("abstract")]
        public string Abstract { get; set; }

        [JsonProperty("web_url")]
        public Uri WebUrl { get; set; }

        [JsonProperty("snippet")]
        public string Snippet { get; set; }

        [JsonProperty("lead_paragraph")]
        public string LeadParagraph { get; set; }

        [JsonProperty("print_section")]
        public string PrintSection { get; set; }


        [JsonProperty("print_page")]

        public string PrintPage { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("multimedia")]
        public object[] Multimedia { get; set; }

        [JsonProperty("headline")]
        public NYTimesHeadline Headline { get; set; }

        [JsonProperty("keywords")]
        public object[] Keywords { get; set; }

        [JsonProperty("pub_date")]
        public string PubDate { get; set; }

        [JsonProperty("document_type")]
        public string DocumentType { get; set; }

        [JsonProperty("news_desk")]
        public string NewsDesk { get; set; }

        [JsonProperty("section_name")]
        public string SectionName { get; set; }

        [JsonProperty("byline")]
        public NYTimesByline Byline { get; set; }

        [JsonProperty("type_of_material")]
        public string TypeOfMaterial { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("word_count")]
        public long WordCount { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class NYTimesByline
    {
        [JsonProperty("original")]
        public object Original { get; set; }

        [JsonProperty("person")]
        public object[] Person { get; set; }

        [JsonProperty("organization")]
        public object Organization { get; set; }
    }

    public class NYTimesHeadline
    {
        [JsonProperty("main")]
        public string Main { get; set; }

        [JsonProperty("kicker")]
        public object Kicker { get; set; }

        [JsonProperty("content_kicker")]
        public object ContentKicker { get; set; }

        [JsonProperty("print_headline")]
        public string PrintHeadline { get; set; }

        [JsonProperty("name")]
        public object Name { get; set; }

        [JsonProperty("seo")]
        public object Seo { get; set; }

        [JsonProperty("sub")]
        public object Sub { get; set; }
    }

    public class NYTimesMeta
    {
        [JsonProperty("hits")]
        public long Hits { get; set; }

        [JsonProperty("offset")]
        public long Offset { get; set; }

        [JsonProperty("time")]
        public long Time { get; set; }
    }
}
