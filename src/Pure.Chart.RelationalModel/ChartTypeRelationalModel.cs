using Pure.Chart.RelationalModel.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;

namespace Pure.Chart.RelationalModel;

public sealed record ChartTypeRelationalModel : IChartTypeRelationalModel
{
    public ChartTypeRelationalModel(IGuid id, IString name)
    {
        Id = id;
        Name = name;
    }

    public IGuid Id { get; }

    public IString Name { get; }
}
