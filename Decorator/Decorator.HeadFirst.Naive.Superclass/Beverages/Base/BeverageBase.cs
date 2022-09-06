using System.Text;

using Decorator.HeadFirst.StarBuzzCoffee.Common.Condiments;

namespace Decorator.HeadFirst.Naive.Superclass.Beverages.Base;

public abstract class BeverageBase
{
    private string description;

    protected BeverageBase()
    {
        description = "Unknown beverage";
    }

    /// <remarks>
    /// TODO: note that the description needs to be updated every time a new condiment is added to the system.
    /// TODO: also note that if a beverage is added to which condiments do not apply (e.g. mocha into tea) additional checks need to be introduced
    /// </remarks>
    public string Description
    {
        get
        {
            var result = new StringBuilder(description);
            if (CountCondiments() > 0)
            {
                result.Append(" with");
            }

            var describedCondimentCount = 0;

            DescribeSteamedMilk(result, ref describedCondimentCount);
            DescribeSoy(result, ref describedCondimentCount);
            DescribeMocha(result, ref describedCondimentCount);
            DescribeWhip(result, ref describedCondimentCount);

            return result.ToString();
        }
        protected set => description = value;
    }

    public bool HasSteamedMilk { get; set; }

    public bool HasSoy { get; set; }

    public bool HasMocha { get; set; }

    public bool HasWhip { get; set; }

    protected abstract decimal BaseCost { get; }

    /// <remarks>
    /// TODO: note that the cost calculation also needs to be updated every time a new condiment is added to the system.
    /// </remarks>
    public virtual decimal CalculateCost()
    {
        decimal condimentCost = 0;

        if (HasMocha)
        {
            condimentCost += CondimentData.Mocha.Cost;
        }

        if (HasSoy)
        {
            condimentCost += CondimentData.Soy.Cost;
        }

        if (HasSteamedMilk)
        {
            condimentCost += CondimentData.SteamedMilk.Cost;
        }

        if (HasWhip)
        {
            condimentCost += CondimentData.Whip.Cost;
        }

        return condimentCost;
    }

    private void DescribeSteamedMilk(StringBuilder result, ref int describedCondimentCount)
    {
        if (HasSteamedMilk)
        {
            result.Append($" {CondimentData.SteamedMilk.Description}");
            describedCondimentCount++;
            AddContinuation(result, describedCondimentCount);
        }
    }

    private void DescribeMocha(StringBuilder result, ref int describedCondimentCount)
    {
        if (HasMocha)
        {
            result.Append($" {CondimentData.Mocha.Description}");
            describedCondimentCount++;
            AddContinuation(result, describedCondimentCount);
        }
    }

    private void DescribeSoy(StringBuilder result, ref int describedCondimentCount)
    {
        if (HasSoy)
        {
            result.Append($" {CondimentData.Soy.Description}");
            describedCondimentCount++;
            AddContinuation(result, describedCondimentCount);
        }
    }

    private void DescribeWhip(StringBuilder result, ref int describedCondimentCount)
    {
        if (HasWhip)
        {
            result.Append($" {CondimentData.Whip.Description}");
            describedCondimentCount++;
            AddContinuation(result, describedCondimentCount);
        }
    }

    private void AddContinuation(StringBuilder result, int describedCondimentCount)
    {
        if (describedCondimentCount + 1 < CountCondiments())
        {
            result.Append(",");
        }

        if (describedCondimentCount + 1 == CountCondiments())
        {
            result.Append(" and");
        }
    }

    /// <remarks>
    /// TODO: note that the condiment count calculation also needs to be updated every time a new condiment is added to the system.
    /// </remarks>
    private int CountCondiments()
    {
        var result = 0;
        if (HasSoy)
        {
            result++;
        }

        if (HasMocha)
        {
            result++;
        }

        if (HasSteamedMilk)
        {
            result++;
        }

        if (HasWhip)
        {
            result++;
        }

        return result;
    }
}
