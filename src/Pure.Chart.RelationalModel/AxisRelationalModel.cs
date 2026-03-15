using Pure.Chart.RelationalModel.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;

namespace Pure.Chart.RelationalModel;

public sealed record AxisRelationalModel : IAxisRelationalModel
{
    public AxisRelationalModel(IGuid id, IGuid chartId, IString legend)
    {
        Id = id;
        Legend = legend;
        ChartId = chartId;
    }

    public IGuid Id { get; }

    public IGuid ChartId { get; }

    public IString Legend { get; }
}
