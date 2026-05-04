#!/usr/bin/env bash
set -euo pipefail

# OpenAPI specs:
# - Legacy REST v1: https://raw.githubusercontent.com/Stability-AI/rest-api-support/main/generated/spec/merged.json
# - Stable Image REST v2beta: https://api.stability.ai/v2alpha/openapi

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location https://raw.githubusercontent.com/Stability-AI/rest-api-support/main/generated/spec/merged.json -o openapi.v1.json
curl --fail --silent --show-error --location https://api.stability.ai/v2alpha/openapi -o openapi.v2beta.json

jq -s '
  .[0] as $v1 | .[1] as $v2 |
  $v1
  | .info.version = "v1+v2beta"
  | .info.description = (($v1.info.description // "") + "\n\nThis generated SDK also includes the official REST v2beta Stable Image API from https://api.stability.ai/v2alpha/openapi.")
  | .tags = (($v1.tags // []) + ($v2.tags // []))
  | ."x-tagGroups" = (($v1."x-tagGroups" // []) + ($v2."x-tagGroups" // []))
  | .paths = (($v1.paths // {}) + ($v2.paths // {}))
  | .components.schemas = (($v1.components.schemas // {}) + ($v2.components.schemas // {}))
  | .components.parameters = (($v1.components.parameters // {}) + ($v2.components.parameters // {}))
  | .components.responses = (($v1.components.responses // {}) + ($v2.components.responses // {}))
  | .components.headers = (($v1.components.headers // {}) + ($v2.components.headers // {}))
  | .components.securitySchemes = (($v1.components.securitySchemes // {}) + ($v2.components.securitySchemes // {}))
' openapi.v1.json openapi.v2beta.json > openapi.yaml

# Auth: --security-scheme overrides the spec's apiKey auth with standard HTTP bearer.
autosdk generate openapi.yaml \
  --namespace StabilityAI \
  --clientClassName StabilityAIClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer

rm openapi.v1.json openapi.v2beta.json
