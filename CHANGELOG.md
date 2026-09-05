# Changelog

All notable changes to Pure.Primitives.Bool.Operations are documented here.

Format follows [Keep a Changelog](https://keepachangelog.com/en/1.1.0/).

---

## [0.5.0] — 2025-11-18

### Changed
- Package now multi-targets `net7.0`, `net8.0`, `net9.0`, and `net10.0`
  (previously `net9.0` only).

## [0.4.0] — 2025-11-02

### Changed
- **Breaking:** `BoolValue` is now a public property on `And`, `Or`, `Xor`,
  `Not`, `BitwiseAnd`, `BitwiseOr`, `EqualCondition`, and `NotEqualCondition`,
  instead of being accessible only through an explicit `IBool` interface
  implementation. Code that accessed it via an `IBool`-typed reference
  continues to work unchanged.

## [0.3.0] — 2025-11-02

### Changed
- Package now declares `IsAotCompatible=true`, marking it Native AOT
  compatible.

## [0.2.0] — 2025-06-03

### Added
- **`EqualCondition`** — true when all supplied `IBool` parameters evaluate
  to the same value.
- **`NotEqualCondition`** — true when the supplied `IBool` parameters do not
  all evaluate to the same value.

### Changed
- **Breaking:** `IBool.Value` renamed to `IBool.BoolValue` on all operation
  types (`And`, `Or`, `Xor`, `Not`, `BitwiseAnd`, `BitwiseOr`), following the
  corresponding rename in `Pure.Primitives.Abstractions`.

## [0.1.1] — 2025-05-26

- Maintenance release: dependency and build updates.

## [0.1.0] — 2025-05-25

### Added
- Initial release of boolean composition primitives implementing `IBool`:
  **`And`**, **`Or`**, **`Xor`**, **`Not`**, **`BitwiseAnd`**,
  **`BitwiseOr`**.
