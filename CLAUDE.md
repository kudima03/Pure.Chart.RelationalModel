# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Commands

All `dotnet` commands must be run from the `./src` directory.

```bash
dotnet restore
dotnet build --no-restore -warnaserror
dotnet test --no-build --verbosity normal
dotnet format --verify-no-changes             # check code style (CI enforces this)
csharpier check .                             # check code style (CI enforces this)
dotnet format && csharpier format .           # auto-fix code style
dotnet pack --configuration Release -p:PackageVersion=<version> --output .
```

Mutation testing (run from `./src`; requires `dotnet-stryker` installed globally):

```bash
dotnet stryker --mutation-level Complete --break-at 98
```

## Architecture

This is an **implementation NuGet library** — four sealed records, no abstractions, no services. Every file defines exactly one record.

**Records and their contracts:**

| Record | Interface |
|--------|-----------|
| `ChartRelationalModel` | `IChartRelationalModel` — chart with title, description, and foreign keys to its type and axes |
| `ChartTypeRelationalModel` | `IChartTypeRelationalModel` — named chart type |
| `ChartSeriesRelationalModel` | `IChartSeriesRelationalModel` — series belonging to a chart, with X/Y source columns |
| `AxisRelationalModel` | `IAxisRelationalModel` — axis with a display legend |

All interface contracts are defined in [`Pure.Chart.RelationalModel.Abstractions`](https://github.com/kudima03/Pure.Chart.RelationalModel.Abstractions). All properties use `IGuid` or `IString` from `Pure.Primitives.Abstractions`.

**Multi-targeting:** net7.0, net8.0, net9.0, net10.0. All records must remain AOT-compatible (`IsAotCompatible = true`).

**Package validation:** `EnablePackageValidation = true` with `PackageValidationBaselineVersion = 0.1.0-preview.3.0.0`. Breaking API changes fail the build.

**Publishing:** triggered by pushing a semver tag matching `*.*.*`. The tag becomes the `PackageVersion`.

**CI quality gates:** build with `-warnaserror`, code coverage ≥ 98%, mutation score ≥ 98%.

## Code Style

Enforced via `.editorconfig`, `dotnet format`, and `csharpier`:

- No `var` — always use explicit types, even when the type is obvious from the right-hand side.
- No expression-bodied methods or constructors — only properties, accessors, and indexers may use `=>`.
- No `new()` target-typed creation — always write the full type name (`new MyType(...)` not `new(...)`).
- File-scoped namespaces (`namespace Foo;` not `namespace Foo { ... }`).
- `using` directives go outside the namespace.
- Always use braces for code blocks, even single-line `if`/`for` bodies.
- Private fields: `_camelCase` prefix.
- Max line length: 90 characters.

## Commit Messages

Do not mention Claude or AI assistance in commit messages.
