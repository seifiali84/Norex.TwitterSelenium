using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Norex.TwitterSelenium;
namespace Norex.TwitterSelenium.Test
{
    public class TwitterBotTest
    {
        [Fact]
        public void TestTwitterBot1() // Constructor
        {
            string username = AccountData.Username;
            string password = AccountData.Password;
            
            TwitterBot bot = new TwitterBot(username , password);

            //Assert.Equal(bot.url , "https://twitter.com/" + username);
        }
        [Fact]
        public void TestTwitterBot2() // Constructor
        {
            // Given
        
            // When
        
            // Then
        }
    }
}