using Pure.Chart.RelationalModel.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;

namespace Pure.Chart.RelationalModel;

public sealed record ChartRelationalModel : IChartRelationalModel
{
    public ChartRelationalModel(
        IGuid id,
        IString title,
        IString description,
        IGuid typeId,
        IGuid xAxisId,
        IGuid yAxisId
    )
    {
        Id = id;
        Title = title;
        Description = description;
        TypeId = typeId;
        XAxisId = xAxisId;
        YAxisId = yAxisId;
    }

    public IGuid Id { get; }

    public IString Title { get; }

    public IString Description { get; }

    public IGuid TypeId { get; }

    public IGuid XAxisId { get; }

    public IGuid YAxisId { get; }
}
