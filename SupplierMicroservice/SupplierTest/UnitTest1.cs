
using Moq;
using SupplierMicroservice;
using SupplierMicroservice.Repository;

namespace SupplierTest
{
    public class Tests
    {
        List<Supplier> dtls;
        
        [SetUp]
        public void Setup()
        {
            dtls = new List<Supplier>();
            {
                new Supplier()
                {
                    supplier_id= 2,
                    name = "Name1",
                    email = "email1@gmail.com",
                    phone = "1234567890",
                    location = "Location1",
                    feedback = 5
                };
            }

            
        }

        

        [TestCase(2)]
        public async Task GetSupplierOfPart_SupplierDetails(int PartId)
        {
            Mock<ISupplierRepo> mock = new Mock<ISupplierRepo>();

            mock.Setup(p => p.GetSupplierOfPart(PartId)).ReturnsAsync(dtls);
            //PlantRepo pro = new PlantRepo();

            //Part a = await pro.ViewStockInHand(PartId);

            List<Supplier > a = await mock.Object.GetSupplierOfPart(PartId);
            Assert.IsNotNull(a);
        }
    }
}