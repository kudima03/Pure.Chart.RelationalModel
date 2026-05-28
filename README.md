# Pure.Chart.RelationalModel

Concrete relational model records for the **Pure** ecosystem — immutable implementations of chart, axis, and series domain entities.

[![.NET build & test](https://github.com/kudima03/Pure.Chart.RelationalModel/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Chart.RelationalModel/actions/workflows/build-and-test.yml)
[![Build and Deploy](https://github.com/kudima03/Pure.Chart.RelationalModel/actions/workflows/publish-nuget.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Chart.RelationalModel/actions/workflows/publish-nuget.yml)
[![NuGet](https://img.shields.io/nuget/v/Pure.Chart.RelationalModel)](https://www.nuget.org/packages/Pure.Chart.RelationalModel)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

## Overview

`Pure.Chart.RelationalModel` provides sealed record implementations of the chart domain contracts defined in `Pure.Chart.RelationalModel.Abstractions`. Each record is immutable, holds only `IGuid` and `IString` properties, and is fully compatible with Native AOT.

## Records

| Type | Implements | Properties |
|------|-----------|------------|
| `ChartRelationalModel` | `IChartRelationalModel` | `Id`, `Title`, `Description`, `TypeId`, `XAxisId`, `YAxisId` |
| `ChartTypeRelationalModel` | `IChartTypeRelationalModel` | `Id`, `Name` |
| `ChartSeriesRelationalModel` | `IChartSeriesRelationalModel` | `Id`, `ChartId`, `Legend`, `XAxisSource`, `YAxisSource` |
| `AxisRelationalModel` | `IAxisRelationalModel` | `Id`, `Legend` |

All properties are constructor-assigned and exposed as read-only `get`-only members. No setters, no mutation.

## Dependencies

- [`Pure.Chart.RelationalModel.Abstractions` 0.1.0-preview.6.0.0](https://github.com/kudima03/Pure.Chart.RelationalModel.Abstractions/tree/0.1.0-preview.6.0.0) — interface contracts for chart, chart type, series, and axis relational models

## Target Frameworks

- .NET 7
- .NET 8
- .NET 9
- .NET 10

## Installation

```shell
dotnet add package Pure.Chart.RelationalModel
```

## Usage

```csharp
using Pure.Chart.RelationalModel;

// All constructor parameters implement IGuid or IString from Pure.Primitives.Abstractions.
var chart = new ChartRelationalModel(id, title, description, typeId, xAxisId, yAxisId);
var chartType = new ChartTypeRelationalModel(id, name);
var series = new ChartSeriesRelationalModel(id, chartId, legend, xAxisSource, yAxisSource);
var axis = new AxisRelationalModel(id, legend);
```
