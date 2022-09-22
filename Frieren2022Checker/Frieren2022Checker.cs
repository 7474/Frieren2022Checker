using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Tweetinvi.Models;
using Tweetinvi;
using System.Linq;
using Tweetinvi.Iterators;
using System.Collections.Generic;

namespace Frieren2022Checker
{
    public static class Frieren2022Checker
    {
        [FunctionName("Frieren2022Checker")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            var appCredentials = new ConsumerOnlyCredentials(
                Environment.GetEnvironmentVariable("TWITTER_API_KEY"),
                Environment.GetEnvironmentVariable("TWITTER_API_KEY_SECRET"))
            {
                BearerToken = Environment.GetEnvironmentVariable("TWITTER_BEARER_TOKEN")
            };

            var appClient = new TwitterClient(appCredentials);

            var tweetsOf1000 = await FetchAllAsync(appClient.Search.GetSearchTweetsIterator("#ツイートで1000票"));
            var resOf1000 = tweetsOf1000
                .Where(x => x.Hashtags.Exists(tag => tag.Text == "フリーレンアニメ化記念キャラ人気投票"))
                .Select(x => new
                {
                    Target = x.Hashtags.LastOrDefault()?.Text,
                })
                .GroupBy(x => x.Target)
                .Select(x => new { Target = x.Key, Count = x.Count() * 1000 })
                .OrderByDescending(x => x.Count)
                .ToList();

            var tweetsOf10000 = await FetchAllAsync(appClient.Search.GetSearchTweetsIterator("#ツイートと葬送のフリーレンフォローで10000票"));
            var resOf10000 = tweetsOf10000
                .Where(x => x.Hashtags.Exists(tag => tag.Text == "フリーレンアニメ化記念キャラ人気投票"))
                .Select(x => new
                {
                    Target = x.Hashtags.LastOrDefault()?.Text,
                })
                .GroupBy(x => x.Target)
                .Select(x => new { Target = x.Key, Count = x.Count() * 10000 })
                .OrderByDescending(x => x.Count)
                .ToList();

            return new OkObjectResult(new
            {
                sen = resOf1000,
                man = resOf10000
            });
        }

        static async Task<IEnumerable<ITweet>> FetchAllAsync(ITwitterIterator<ITweet, long?> ite)
        {
            var res = new List<ITweet>();
            while (!ite.Completed)
            {
                res.AddRange((await ite.NextPageAsync()));
            }
            return res;
        }
    }
}
