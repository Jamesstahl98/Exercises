using ÖvningarUnitTests.Core.Services;

namespace ÖvningarUnitTests.Tests;

public class InventoryServiceTests
{
    [Fact]
    public void GetStock_ItemAvailable_ReturnsTrue()
    {
        var inventory = new Dictionary<string, int>
        {
            { "ItemA", 10 },
            { "ItemB", 0 }
        };
        var inventoryService = new InventoryService();

        inventoryService.AddStock("ItemA", 10);
        var result = inventoryService.GetStock("ItemA") > 0;
        Assert.True(result);
    }

    [Fact]
    public void RemoveItem_Then_GetStock_ReturnsFalse()
    {
        var inventory = new Dictionary<string, int>
        {
            { "ItemA", 10 },
            { "ItemB", 0 }
        };
        var inventoryService = new InventoryService();

        inventoryService.AddStock("ItemA", 10);
        inventoryService.AddStock("ItemA", 10);
        inventoryService.AddStock("ItemA", 10);
        inventoryService.RemoveStock("ItemA", 30);
        var result = inventoryService.GetStock("ItemA") > 0;
        Assert.False(result);
    }

    [Fact]
    public void RemoveItem_MoreThanQuantity_ThrowsException()
    {
        var inventory = new Dictionary<string, int>
        {
            { "ItemA", 10 },
            { "ItemB", 0 }
        };
        var inventoryService = new InventoryService();

        inventoryService.AddStock("ItemA", 10);
        Assert.Throws<InvalidOperationException>(() => inventoryService.RemoveStock("ItemA", 30));
    }
}
