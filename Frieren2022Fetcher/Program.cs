using Newtonsoft.Json;
using Tweetinvi;
using Tweetinvi.Iterators;
using Tweetinvi.Models;

var appCredentials = new ConsumerOnlyCredentials(
    Environment.GetEnvironmentVariable("TWITTER_API_KEY"),
    Environment.GetEnvironmentVariable("TWITTER_API_KEY_SECRET"))
{
    BearerToken = Environment.GetEnvironmentVariable("TWITTER_BEARER_TOKEN")
};

var appClient = new TwitterClient(appCredentials);

var tweetsOf1000 = await FetchAllAsync(appClient.Search.GetSearchTweetsIterator("#ツイートで1000票"));
var tweetsOf10000 = await FetchAllAsync(appClient.Search.GetSearchTweetsIterator("#ツイートと葬送のフリーレンフォローで10000票"));
var raw = tweetsOf1000
    .Where(x => x.Hashtags.Exists(tag => tag.Text == "フリーレンアニメ化記念キャラ人気投票"))
    .Select(x => new RawVote(
        Timestamp: x.CreatedAt,
        Target: x.Hashtags.LastOrDefault()?.Text ?? "-",
        Count: 1000
    )).Concat(tweetsOf10000
    .Where(x => x.Hashtags.Exists(tag => tag.Text == "フリーレンアニメ化記念キャラ人気投票"))
    .Select(x => new RawVote(
        Timestamp: x.CreatedAt,
        Target: x.Hashtags.LastOrDefault()?.Text ?? "-",
        Count: 10000
    ))).OrderBy(x => x.Timestamp).ToList();
;

var votes = JsonConvert.SerializeObject(raw);
//File.WriteAllText($"./votes.json", JsonConvert.SerializeObject(raw));
Console.Write(votes);

static async Task<IEnumerable<ITweet>> FetchAllAsync(ITwitterIterator<ITweet, long?> ite)
{
    var res = new List<ITweet>();
    while (!ite.Completed)
    {
        res.AddRange((await ite.NextPageAsync()));
    }
    return res;
}

public record RawVote(
    DateTimeOffset Timestamp,
    string Target,
    int Count
)
{ }