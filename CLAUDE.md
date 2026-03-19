# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for the [Stability AI](https://stability.ai/) image generation API (text-to-image, image-to-image, upscaling, masking), auto-generated from the official OpenAPI specification using [AutoSDK](https://github.com/HavenDV/AutoSDK). Published as a NuGet package under the `tryAGI` organization.

## Build Commands

```bash
# Build the solution
dotnet build StabilityAI.slnx

# Build for release (also produces NuGet package)
dotnet build StabilityAI.slnx -c Release

# Run integration tests (requires STABILITYAI_API_KEY env var)
dotnet test src/tests/IntegrationTests/StabilityAI.IntegrationTests.csproj

# Regenerate SDK from OpenAPI spec
cd src/libs/StabilityAI && ./generate.sh
```

## Architecture

### Code Generation Pipeline

The SDK code is **entirely auto-generated** -- do not manually edit files in `src/libs/StabilityAI/Generated/`.

1. `src/libs/StabilityAI/openapi.yaml` -- the Stability AI OpenAPI spec (fetched from upstream)
2. `src/libs/StabilityAI/generate.sh` -- orchestrates: download spec, fix auth scheme, run AutoSDK CLI, output to `Generated/`
3. CI auto-updates the spec and creates PRs if changes are detected

### Auth Scheme Fix

The upstream spec uses `apiKey` type auth with `Authorization` header name, which is non-standard. `generate.sh` applies a `jq` fix to convert it to standard HTTP bearer auth before code generation.

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/StabilityAI/` | Main SDK library (`StabilityAIClient`) |
| `src/tests/IntegrationTests/` | Integration tests against real Stability AI API |

### Documentation Generation

Tests in `src/tests/IntegrationTests/Examples` are the single source of truth for both test coverage and documentation:
- Each file has a JSDoc header (`order`, `title`, `slug`) consumed by `autosdk docs sync .`
- Comments prefixed with `////` become prose paragraphs in generated docs
- CI workflow (`.github/workflows/mkdocs.yml`) auto-generates `docs/examples/` and populates `EXAMPLES:START/END` markers in README.md, docs/index.md, and mkdocs.yml
- Config: `autosdk.docs.json` points to `src/tests/IntegrationTests/Examples`
### Build Configuration

- **Target:** `net10.0`
- **Language:** C# preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + AwesomeAssertions

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material
