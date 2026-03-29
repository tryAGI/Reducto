dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml "https://storage.googleapis.com/stainless-sdk-openapi-specs/reducto%2Freductoai-9dcbb133ea8d4e419314a5fddc878258610a80acfe82604b328a7eb3cb4f8f5f.yml"
autosdk generate openapi.yaml \
  --namespace Reducto \
  --clientClassName ReductoClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
