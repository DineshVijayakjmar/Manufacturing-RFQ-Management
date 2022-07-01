using Moq;
using PlantMicros.Models;
using PlantMicros.Repository;

namespace PlantTest
{
    public class Tests
    {
        List<PlantReorderDetails> dtls;
        Part pts;
        [SetUp]
        public void Setup()
        {
            dtls = new List<PlantReorderDetails>();
            {
                new PlantReorderDetails()
                {
                    PlantReorderId = 501,
                    PartId = 1,
                    PartDetails = "Cement",
                    ReorderStatus = "Requested",
                    ReorderDate = Convert.ToDateTime("2022 - 02 - 04")
                };
            }

            pts = new Part();
            {
                new Part()
                {
                    PartId = 1,
                    PartDescription = "Cement",
                    PartSpecification = "best quality",
                    StockInHand = 47

                };
            }
        }

        [Test]
        public async Task ViewPartsReOrder_GetsPartDetails()
        {
            Mock<IPlantRepo> mock = new Mock<IPlantRepo>();

            mock.Setup(p => p.ViewPartsReOrder()).ReturnsAsync(dtls);
            List<PlantReorderDetails> a = await mock.Object.ViewPartsReOrder();
            Assert.AreEqual(a.Count, dtls.Count);
        }

        [TestCase(1)]
        public async Task ViewStockInHand_GetsStock(int PartId)
        {
            Mock<IPlantRepo> mock = new Mock<IPlantRepo>();

            mock.Setup(p => p.ViewStockInHand(PartId)).ReturnsAsync(pts);
            //PlantRepo pro = new PlantRepo();

            //Part a = await pro.ViewStockInHand(PartId);

            Part a = await mock.Object.ViewStockInHand(PartId);
            Assert.IsNotNull(a);
        }

    }
}