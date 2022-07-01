
//using Moq;
//using RFQ_mgmt.Model;
//using RFQ_mgmt.Repository;

//namespace rfqtest
//{
//    public class Tests
//    {
//        List<Rfq> rfqvar;  
//        [SetUp]
//        public void Setup()
//        {
//            rfqvar = new List<Rfq>();
//            {
//                new Rfq()
//                {
//                    Rfq_id = 1,
//                    Demand_id = 101,
//                    Part_Id = 201,
//                    Part_details = "electric",
//                    Quantity = "12",
//                    Expected_supply_date = Convert.ToDateTime("12-04-2022"),
//                    Specifications = "abcde"


//                };
//            }
//        }

//        [TestCase(201)]
//        public async Task Get_RfqDetail(int Part_Id)
//        {
//            Mock<IrfqRepo> mock = new Mock<IrfqRepo>();

//            mock.Setup(p => p.Get(Part_Id)).ReturnsAsync(rfqvar);


//            List<Rfq> a = await mock.Object.Get(Part_Id);
//            Assert.IsNotNull(a);
//        }
//    }
//}