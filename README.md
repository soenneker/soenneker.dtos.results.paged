[![](https://img.shields.io/nuget/v/soenneker.dtos.results.paged.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.results.paged/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.results.paged/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.results.paged/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.results.paged.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.results.paged/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.results.paged/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.results.paged/actions/workflows/codeql.yml)

# Soenneker.Dtos.Results.Paged

Returns one page of query results together with page-size, optional total-count, and opaque continuation-cursor metadata.

## Install

```bash
dotnet add package Soenneker.Dtos.Results.Paged
```

## What you get

- `PagedResult<T>` — Returns one page of query results together with page-size, optional total-count, and opaque continuation-cursor metadata.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `PagedResult<T>.Items` | Items included in the current page, in the order determined by the query. | Items included in the current page, in the order determined by the query. |
| `PagedResult<T>.PageSize` | Effective page-size limit used for this response, which may differ from the requested size because of server defaults or limits. | Effective page-size limit used for this response, which may differ from the requested size because of server defaults or limits. |
| `PagedResult<T>.TotalCount` | Total number of records matching the query across all pages, or `null` when counting was not requested or computed. | Total number of records matching the query across all pages, or `null` when counting was not requested or computed. |
| `PagedResult<T>.ContinuationToken` | Opaque cursor for requesting the next page, or `null` when no additional page is available; clients must not parse or modify it. | Opaque cursor for requesting the next page, or `null` when no additional page is available; clients must not parse or modify it. |
