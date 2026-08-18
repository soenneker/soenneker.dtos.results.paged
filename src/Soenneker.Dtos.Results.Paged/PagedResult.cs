using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Dtos.Results.Paged;

/// <summary>
/// Returns one page of query results together with page-size, optional total-count, and opaque continuation-cursor metadata.
/// </summary>
/// <typeparam name="T">The type of each item in the result set.</typeparam>
[PublicOpenApiObject]
public sealed class PagedResult<T>
{
    /// <summary>
    /// Items included in the current page, in the order determined by the query.
    /// </summary>
    [JsonPropertyName("items")]
    [JsonProperty("items")]
    public List<T> Items { get; set; } = null!;

    /// <summary>
    /// Effective page-size limit used for this response, which may differ from the requested size because of server defaults or limits.
    /// </summary>
    [JsonPropertyName("pageSize")]
    [JsonProperty("pageSize")]
    public int PageSize { get; set; }

    /// <summary>
    /// Total number of records matching the query across all pages, or <see langword="null"/> when counting was not requested or computed.
    /// </summary>
    [JsonPropertyName("totalCount")]
    [JsonProperty("totalCount")]
    public int? TotalCount { get; set; }

    /// <summary>
    /// Opaque cursor for requesting the next page, or <see langword="null"/> when no additional page is available; clients must not parse or modify it.
    /// </summary>
    [JsonPropertyName("continuationToken")]
    [JsonProperty("continuationToken")]
    public string? ContinuationToken { get; set; }
}
