using System.Threading.Tasks;
using Xunit;

namespace MyApp.Services.BusinessCard.Test
{
    public class BusinessCardServiceTest
    {
        [Fact]
        public async Task GeneratePDF()
        {
            var sut = new BusinessCardService() as IBusinessCardService;
            var result = await sut.GeneratePDF(new GenerateParameter() 
            {
                Name = "���h�@���Y",
                Organization = "�L����Ж��h���Y"
            });

            Assert.NotNull(result);
            Assert.True(result.Length > 0);
        }
    }
}
