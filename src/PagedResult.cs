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
    /// The number of items returned per page in the response. 
    /// This may reflect the client's requested page size, or a server-defined default or limit.
    /// </summary>
    [JsonPropertyName("pageSize")]
    [JsonProperty("pageSize")]
    public int PageSize { get; set; }

    /// <summary>
    /// The total number of items that match the query across all pages.
    /// May be null if the count is not computed or not applicable (e.g., in continuation-based pagination).
    /// </summary>
    [JsonPropertyName("totalCount")]
    [JsonProperty("totalCount")]
    public int? TotalCount { get; set; }

    /// <summary>
    /// Opaque storage continuation token.  
    /// ‑ `null` → the current page was the last page.
    /// </summary>
    [JsonPropertyName("continuationToken")]
    [JsonProperty("continuationToken")]
    public string? ContinuationToken { get; set; }
}