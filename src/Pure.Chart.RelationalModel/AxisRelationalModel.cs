using Pure.Chart.RelationalModel.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;

namespace Pure.Chart.RelationalModel;

public sealed record AxisRelationalModel : IAxisRelationalModel
{
    public AxisRelationalModel(IGuid id, IString legend)
    {
        Id = id;
        Legend = legend;
    }

    public IGuid Id { get; }

    public IString Legend { get; }
}
