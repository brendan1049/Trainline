using System;
using FluentAssertions;
using SearchService.Contract;
using SearchService.Service;
using Xunit;

namespace SearchService.Test
{
    public class SearchLocationMapperTest
    {
        private readonly SearchLocationMapper _sut;

        public SearchLocationMapperTest()
        {
            _sut = new SearchLocationMapper();
        }
        
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("Something")]
        public void MapLocation_Test(string code)
        {
            var result = _sut.MapToUkCode(new Location{Code = code});
            result.Should().Be(code);
        }
    }
}