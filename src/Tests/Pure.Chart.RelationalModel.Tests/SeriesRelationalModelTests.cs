using Pure.Chart.RelationalModel.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;
using Pure.Primitives.Random.String;
using Guid = Pure.Primitives.Guid.Guid;

namespace Pure.Chart.RelationalModel.Tests;

public sealed record SeriesRelationalModelTests
{
    [Fact]
    public void InitializeIdCorrectly()
    {
        IGuid guid = new Guid();
        ISeriesRelationalModel type = new SeriesRelationalModel(
            guid,
            new Guid(),
            new RandomString(),
            new RandomString(),
            new RandomString()
        );

        Assert.Equal(guid.GuidValue, type.Id.GuidValue);
    }

    [Fact]
    public void InitializeChartIdCorrectly()
    {
        IGuid guid = new Guid();
        ISeriesRelationalModel type = new SeriesRelationalModel(
            new Guid(),
            guid,
            new RandomString(),
            new RandomString(),
            new RandomString()
        );

        Assert.Equal(guid.GuidValue, type.ChartId.GuidValue);
    }

    [Fact]
    public void InitializeLegendCorrectly()
    {
        IString legend = new RandomString();
        ISeriesRelationalModel type = new SeriesRelationalModel(
            new Guid(),
            new Guid(),
            legend,
            new RandomString(),
            new RandomString()
        );

        Assert.Equal(legend.TextValue, type.Legend.TextValue);
    }

    [Fact]
    public void InitializeXAxisSourceCorrectly()
    {
        IString source = new RandomString();
        ISeriesRelationalModel type = new SeriesRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            source,
            new RandomString()
        );

        Assert.Equal(source.TextValue, type.XAxisSource.TextValue);
    }

    [Fact]
    public void InitializeYAxisSourceCorrectly()
    {
        IString source = new RandomString();
        ISeriesRelationalModel type = new SeriesRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString(),
            source
        );

        Assert.Equal(source.TextValue, type.YAxisSource.TextValue);
    }
}
