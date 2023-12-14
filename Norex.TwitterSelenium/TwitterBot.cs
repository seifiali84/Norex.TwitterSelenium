

namespace Norex.TwitterSelenium;
/// <summary>
/// the object from this class logs a bot into target twitter account then you can control the accoutn with bot.
/// </summary>
public class TwitterBot
{
    /// <summary>
    /// The constructor will log you into the account
    /// </summary>
    /// <param name="username"> the username of twitter account that you need to run the bot on</param>
    /// <param name="password"> the password of twitter account that you need to run the bot on</param>
    /// <param name="OpenBrowser">set this argument false to browser doesn't open</param>
    public TwitterBot(string username , string password , bool OpenBrowser = true)
    {
        
    }
    /// <summary>
    /// the Browser Driver of the bot
    /// </summary>
    private Browser Browser { set; get; }
}
