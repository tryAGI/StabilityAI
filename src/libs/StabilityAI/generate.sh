#!/usr/bin/env bash
set -euo pipefail

readonly openapi_url="https://raw.githubusercontent.com/Stability-AI/rest-api-support/main/generated/spec/merged.json"

dotnet tool update --global autosdk.cli --prerelease || dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location "$openapi_url" -o openapi.yaml

# Fix upstream security scheme: 'Authorization' as apiKey header name is invalid for AutoSDK.
# Replace with standard HTTP bearer auth and add top-level security requirement.
jq '
  .components.securitySchemes.STABILITY_API_KEY = {"type": "http", "scheme": "bearer", "x-default": "$STABILITY_API_KEY"} |
  .security = [{"STABILITY_API_KEY": []}]
' openapi.yaml > openapi_fixed.yaml
mv openapi_fixed.yaml openapi.yaml

autosdk generate openapi.yaml \
  --namespace StabilityAI \
  --clientClassName StabilityAIClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
