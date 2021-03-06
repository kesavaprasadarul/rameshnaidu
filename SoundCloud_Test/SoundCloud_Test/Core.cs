﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;

namespace SoundCloud_Test
{
    public class Core
    {
       public async Task<string> requestResponse(string url)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage resp = await client.GetAsync(new Uri(url));
            return await resp.Content.ReadAsStringAsync();
        }

        public async Task<string> resolveSCUrl(string url)
        {
           return await requestResponse(Path.Combine(App.SoundCloudLink,"resolve.json?url=",url,"&client_id=",App.SoundCloudClientId));
        }
    }

    public class SoundCloudCreatedWith
    {
        public int id { get; set; }
        public string name { get; set; }
        public string uri { get; set; }
        public string permalink_url { get; set; }
    }

    public class SoundCloudTrack
    {
        public int id { get; set; }
        public string created_at { get; set; }
        public int user_id { get; set; }
        public int duration { get; set; }
        public bool commentable { get; set; }
        public string state { get; set; }
        public string sharing { get; set; }
        public string tag_list { get; set; }
        public string permalink { get; set; }
        public object description { get; set; }
        public bool streamable { get; set; }
        public bool downloadable { get; set; }
        public object genre { get; set; }
        public object release { get; set; }
        public object purchase_url { get; set; }
        public object label_id { get; set; }
        public object label_name { get; set; }
        public object isrc { get; set; }
        public object video_url { get; set; }
        public string track_type { get; set; }
        public object key_signature { get; set; }
        public object bpm { get; set; }
        public string title { get; set; }
        public object release_year { get; set; }
        public object release_month { get; set; }
        public object release_day { get; set; }
        public string original_format { get; set; }
        public int original_content_size { get; set; }
        public string license { get; set; }
        public string uri { get; set; }
        public string permalink_url { get; set; }
        public object artwork_url { get; set; }
        public string waveform_url { get; set; }
        public SoundCloudUser user { get; set; }
        public string stream_url { get; set; }
        public string download_url { get; set; }
        public int playback_count { get; set; }
        public int download_count { get; set; }
        public int favoritings_count { get; set; }
        public int comment_count { get; set; }
        public SoundCloudCreatedWith created_with { get; set; }
        public string attachments_uri { get; set; }
    }

    public class SoundCloudUser
    {
        public int id { get; set; }
        public string permalink { get; set; }
        public string username { get; set; }
        public string uri { get; set; }
        public string permalink_url { get; set; }
        public string avatar_url { get; set; }
    }
}
