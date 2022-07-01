using PlantMicros.Models;

namespace PlantMicros.Repository
{
    public interface IPlantRepo
    {
        Task<List<PlantReorderDetails>> ViewPartsReOrder();
        Task<Part> ViewStockInHand(int partId);
        Task<string> UpdateMinMax(int min, int max, int id);
    }
}
