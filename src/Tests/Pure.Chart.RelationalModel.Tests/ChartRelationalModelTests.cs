using Pure.Chart.RelationalModel.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;
using Pure.Primitives.Random.String;
using Guid = Pure.Primitives.Guid.Guid;

namespace Pure.Chart.RelationalModel.Tests;

public sealed record ChartRelationalModelTests
{
    [Fact]
    public void InitializeIdCorrectly()
    {
        IGuid guid = new Guid();
        IChartRelationalModel type = new ChartRelationalModel(
            guid,
            new RandomString(),
            new RandomString(),
            new Guid(),
            new Guid(),
            new Guid()
        );

        Assert.Equal(guid.GuidValue, type.Id.GuidValue);
    }

    [Fact]
    public void InitializeTitleCorrectly()
    {
        IString title = new RandomString();
        IChartRelationalModel type = new ChartRelationalModel(
            new Guid(),
            title,
            new RandomString(),
            new Guid(),
            new Guid(),
            new Guid()
        );

        Assert.Equal(title.TextValue, type.Title.TextValue);
    }

    [Fact]
    public void InitializeDescriptionCorrectly()
    {
        IString description = new RandomString();
        IChartRelationalModel type = new ChartRelationalModel(
            new Guid(),
            new RandomString(),
            description,
            new Guid(),
            new Guid(),
            new Guid()
        );

        Assert.Equal(description.TextValue, type.Description.TextValue);
    }

    [Fact]
    public void InitializeTypeIdCorrectly()
    {
        IGuid guid = new Guid();
        IChartRelationalModel type = new ChartRelationalModel(
            new Guid(),
            new RandomString(),
            new RandomString(),
            guid,
            new Guid(),
            new Guid()
        );

        Assert.Equal(guid.GuidValue, type.TypeId.GuidValue);
    }

    [Fact]
    public void InitializeXAxisCorrectly()
    {
        IGuid guid = new Guid();
        IChartRelationalModel type = new ChartRelationalModel(
            new Guid(),
            new RandomString(),
            new RandomString(),
            new Guid(),
            guid,
            new Guid()
        );

        Assert.Equal(guid.GuidValue, type.XAxisId.GuidValue);
    }

    [Fact]
    public void InitializeYAxisCorrectly()
    {
        IGuid guid = new Guid();
        IChartRelationalModel type = new ChartRelationalModel(
            new Guid(),
            new RandomString(),
            new RandomString(),
            new Guid(),
            new Guid(),
            guid
        );

        Assert.Equal(guid.GuidValue, type.YAxisId.GuidValue);
    }
}
