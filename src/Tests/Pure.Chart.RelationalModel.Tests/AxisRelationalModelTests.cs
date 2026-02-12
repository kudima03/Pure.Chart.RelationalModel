using Pure.Chart.RelationalModel.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;
using Pure.Primitives.Random.String;
using Guid = Pure.Primitives.Guid.Guid;

namespace Pure.Chart.RelationalModel.Tests;

public sealed record AxisRelationalModelTests
{
    [Fact]
    public void InitializeGuidCorrectly()
    {
        IGuid guid = new Guid();
        IAxisRelationalModel type = new AxisRelationalModel(guid, new RandomString());

        Assert.Equal(guid.GuidValue, type.Id.GuidValue);
    }

    [Fact]
    public void InitializeLegendCorrectly()
    {
        IString legend = new RandomString();
        IAxisRelationalModel type = new AxisRelationalModel(new Guid(), legend);

        Assert.Equal(legend.TextValue, type.Legend.TextValue);
    }
}
