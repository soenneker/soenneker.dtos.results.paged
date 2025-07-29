using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Soenneker.Dtos.Results.Paged;

/// <summary>
/// A generic container for paginated results returned to the client.
/// </summary>
/// <typeparam name="T">The type of each item in the result set.</typeparam>
public sealed class PagedResult<T>
{
    /// <summary>
    /// The subset of items returned for the current page.
    /// </summary>
    [JsonPropertyName("items")]
    [JsonProperty("items")]
    public List<T> Items { get; set; } = null!;

    /// <summary>
    /// The maximum number of items requested per page.
    /// </summary>
    [JsonPropertyName("pageSize")]
    [JsonProperty("pageSize")]
    public int PageSize { get; set; }

    /// <summary>
    /// Total rows that match the query (for “showing 51‑100 of 1 234”).
    /// </summary>
    [JsonPropertyName("totalCount")]
    [JsonProperty("totalCount")]
    public int TotalCount { get; set; }

    /// <summary>
    /// Opaque storage continuation token.  
    /// ‑ `null` → the current page was the last page.
    /// </summary>
    [JsonPropertyName("continuationToken")]
    [JsonProperty("continuationToken")]
    public string? ContinuationToken { get; set; }
}