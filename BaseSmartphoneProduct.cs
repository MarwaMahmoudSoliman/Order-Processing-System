using Phone;

public interface IProduct
{
    string GetDescription();
    decimal GetPrice();
}

public class BaseSmartphoneProduct : IProduct
{
    private CustomSmartphone phone;
    public BaseSmartphoneProduct(CustomSmartphone phone)
    {
        this.phone = phone;
    }
    public string GetDescription()
    {
        return phone.ToString();
    }
    public decimal GetPrice()
    {
        
        decimal price = 500;
        price += phone.RAM * 20;
        price += phone.Storage * 0.5m;
        return price;
    }
}

public abstract class ProductDecorator : IProduct
{
    protected IProduct _product;
    public ProductDecorator(IProduct product)
    {
        _product = product;
    }
    public virtual string GetDescription()
    {
        return _product.GetDescription();
    }
    public virtual decimal GetPrice()
    {
        return _product.GetPrice();
    }
}

public class ExtendedWarrantyDecorator : ProductDecorator
{
    public ExtendedWarrantyDecorator(IProduct product) : base(product) { }
    public override string GetDescription()
    {
        return _product.GetDescription() + " + Extended Warranty";
    }
    public override decimal GetPrice()
    {
        return _product.GetPrice() + 50;
    }
}

public class EngravingDecorator : ProductDecorator
{
    public EngravingDecorator(IProduct product) : base(product) { }
    public override string GetDescription()
    {
        return _product.GetDescription() + " + Custom Engraving";
    }
    public override decimal GetPrice()
    {
        return _product.GetPrice() + 30;
    }
}
