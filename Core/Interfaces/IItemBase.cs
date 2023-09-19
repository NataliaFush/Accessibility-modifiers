namespace Core
{
    public interface IItemBase
    {
        uint Discount { get; set; }
        int Id { get; set; }
        string ItemName { get; set; }
        uint Price { get; set; }
        string Unit { get; set; }

        double GetTotalPrice();
    }
}