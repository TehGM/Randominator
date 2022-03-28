# Randominator Sitemap Renderer
Blazor WASM currently doesn't seem to support outputting sitemap.xml file dynamically - only a static file seems to be supported.

This is an ad-hoc utility to generate sitemap.xml file before deployment (for example with GitHub Actions).

## Usage
Run this after Randominator has been published - `dotnet run` command is recommended.  
CI/CD pipeline should be set to publish Randominator project only, not entire solution.

Supported options. Examples indicate default values:
- `-o` - controls output directory, for example `-o bin/publish/wwwroot`.
- `-f` - controls file name, for example `-f sitemap.xml`.
- `-d` - allows changing domain, for example `-d randominator.tehgm.net`.
- `-p` - specifies procotol/scheme, for example `-p https`.
- `--debug` - enables debug logs.