# Pure.Primitives.Bool.Operations

Boolean operations for **Pure** `IBool` primitives — composable, immutable value objects for logical and bitwise bool operations.

[![.NET build & test](https://github.com/kudima03/Pure.Primitives.Bool.Operations/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Primitives.Bool.Operations/actions/workflows/build-and-test.yml)
[![Build and Deploy](https://github.com/kudima03/Pure.Primitives.Bool.Operations/actions/workflows/publish-nuget.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Primitives.Bool.Operations/actions/workflows/publish-nuget.yml)
[![NuGet](https://img.shields.io/nuget/v/Pure.Primitives.Bool.Operations)](https://www.nuget.org/packages/Pure.Primitives.Bool.Operations)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

## Overview

`Pure.Primitives.Bool.Operations` provides sealed record types that implement logical and bitwise operations over `IBool` values. Each type is a composable value object — the operation is evaluated lazily when `.BoolValue` is accessed.

## Types

| Type | Implements | Description |
|------|-----------|-------------|
| `And` | `IBool` | Logical AND over a sequence of `IBool` values |
| `Or` | `IBool` | Logical OR over a sequence of `IBool` values |
| `Not` | `IBool` | Logical NOT of a single `IBool` value |
| `Xor` | `IBool` | Logical XOR over a sequence of `IBool` values |
| `BitwiseAnd` | `IBool` | Bitwise AND over a sequence of `IBool` values |
| `BitwiseOr` | `IBool` | Bitwise OR over a sequence of `IBool` values |
| `EqualCondition` | `IBool` | `true` if all supplied `IBool` values are equal |
| `NotEqualCondition` | `IBool` | `true` if not all supplied `IBool` values are equal |

All types live in the `Pure.Primitives.Bool.Operations` namespace.

## Design Principles

- **Lazy evaluation** — the operation is computed only when `.BoolValue` is accessed.
- **Composable** — any `IBool` can be nested inside another operation.
- **AOT-compatible** — no reflection; fully compatible with Native AOT.

## Dependencies

- [`Pure.Primitives.Abstractions`](https://github.com/kudima03/Pure.Primitives.Abstractions) — `IBool` interface
