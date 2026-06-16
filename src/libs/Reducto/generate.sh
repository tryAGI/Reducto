install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

install_autosdk_cli
rm -rf Generated
fetch_spec -o openapi.yaml "https://storage.googleapis.com/stainless-sdk-openapi-specs/reducto%2Freductoai-9dcbb133ea8d4e419314a5fddc878258610a80acfe82604b328a7eb3cb4f8f5f.yml"
autosdk generate openapi.yaml \
  --namespace Reducto \
  --clientClassName ReductoClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
