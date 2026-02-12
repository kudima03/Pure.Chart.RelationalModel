using Pure.Chart.RelationalModel.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;
using Pure.Primitives.Random.String;
using Guid = Pure.Primitives.Guid.Guid;

namespace Pure.Chart.RelationalModel.Tests;

public sealed record ChartTypeRelationalModelTests
{
    [Fact]
    public void InitializeGuidCorrectly()
    {
        IGuid guid = new Guid();
        IChartTypeRelationalModel type = new ChartTypeRelationalModel(
            guid,
            new RandomString()
        );

        Assert.Equal(guid.GuidValue, type.Id.GuidValue);
    }

    [Fact]
    public void InitializeNameCorrectly()
    {
        IString name = new RandomString();
        IChartTypeRelationalModel type = new ChartTypeRelationalModel(new Guid(), name);

        Assert.Equal(name.TextValue, type.Name.TextValue);
    }
}
