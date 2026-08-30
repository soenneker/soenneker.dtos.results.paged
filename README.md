[![](https://img.shields.io/nuget/v/soenneker.dtos.results.paged.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.results.paged/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.results.paged/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.results.paged/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.results.paged.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.results.paged/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.results.paged/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.results.paged/actions/workflows/codeql.yml)

# Soenneker.Dtos.Results.Paged

A generic response DTO for one page of items plus the effective page size, optional total count, and an opaque next-page cursor.

## Install

```bash
dotnet add package Soenneker.Dtos.Results.Paged
```

## Create a page

```csharp
using Soenneker.Dtos.Results.Paged;

var page = new PagedResult<OrderDto>
{
    Items = orders,
    PageSize = 50,
    TotalCount = includeCount ? totalCount : null,
    ContinuationToken = nextCursor
};
```

`Items` starts as an empty list, so an empty page can be represented without assigning it. `PageSize` describes the effective limit for the response; it is not necessarily equal to `Items.Count`, particularly on the final page.

## Fetch the next page

```csharp
if (page.ContinuationToken is { } cursor)
{
    request.ContinuationToken = cursor;
}
```

Treat `ContinuationToken` as opaque and send it back unchanged. A null token conventionally means there is no next page, but the API producing the DTO defines that contract. `TotalCount` is null when a count was not requested or computed and may be more expensive for the server to produce.

The JSON property names are `items`, `pageSize`, `totalCount`, and `continuationToken` under both `System.Text.Json` and Newtonsoft.Json. Null-member omission follows the configured serializer options.
