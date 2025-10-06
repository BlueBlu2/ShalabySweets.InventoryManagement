// See https://aka.ms/new-console-template for more information
public class Product
{
    private int id;
    private string name = string.Empty;
    private string? description;

    private int maxItemsInStock = 0;

    private UnitType unitType;
    private int amountInStock = 0;
    private bool isBelowThreshold = false;
}