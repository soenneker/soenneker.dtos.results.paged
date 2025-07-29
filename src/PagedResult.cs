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
    /// The zero-based index of the current page (e.g., 0 for the first page).
    /// </summary>
    [JsonPropertyName("pageIndex")]
    [JsonProperty("pageIndex")]
    public int PageIndex { get; set; }

    /// <summary>
    /// The maximum number of items requested per page.
    /// </summary>
    [JsonPropertyName("pageSize")]
    [JsonProperty("pageSize")]
    public int PageSize { get; set; }

    /// <summary>
    /// The total number of items across all pages (i.e., before paging was applied).
    /// </summary>
    [JsonPropertyName("totalCount")]
    [JsonProperty("totalCount")]
    public int TotalCount { get; set; }
}