# Changelog

All notable changes to Pure.Chart.RelationalModel are documented here.

Format follows [Keep a Changelog](https://keepachangelog.com/en/1.1.0/).

---

## [0.1.0-preview.3.0.0] — 2026-04-26

### Changed
- **`AxisRelationalModel`** constructor reverted to `(IGuid id, IString legend)`,
  dropping the `chartId` parameter and `ChartId` property added in the previous
  release.

---

## [0.1.0-preview.2.0.0] — 2026-04-19

### Changed
- **`SeriesRelationalModel`** / `ISeriesRelationalModel` renamed to
  **`ChartSeriesRelationalModel`** / `IChartSeriesRelationalModel`.

---

## [0.1.0-preview.1.0.0] — 2026-03-15

### Changed
- **`AxisRelationalModel`** constructor changed to
  `(IGuid id, IGuid chartId, IString legend)`, adding a `ChartId` property.

---

## [0.1.0-preview.0.1.0] — 2026-02-12

### Added
- **`ChartTypeRelationalModel`** — `Id` (`IGuid`), `Name` (`IString`).
- **`AxisRelationalModel`** — `Id` (`IGuid`), `Legend` (`IString`).
- **`SeriesRelationalModel`** — `Id`, `ChartId` (`IGuid`), `Legend`,
  `XAxisSource`, `YAxisSource` (`IString`).
- **`ChartRelationalModel`** — `Id`, `TypeId`, `XAxisId`, `YAxisId` (`IGuid`),
  `Title`, `Description` (`IString`).

All types implement the corresponding interfaces from
`Pure.Chart.RelationalModel.Abstractions` and target net7.0, net8.0, net9.0,
and net10.0.
